using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;

class NPokemon{
  private NPokemon() { }
  static NPokemon obj = new NPokemon();
  public static NPokemon Singleton{get => obj;}
  
  private Pokemon[] pokemons = new Pokemon[10];
  private int np;

  
  public void Abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(Pokemon[])); 
    StreamReader f = new StreamReader("./pokemons.xml",Encoding.Default);
    pokemons = (Pokemon[]) xml.Deserialize(f);
    f.Close();
    np = pokemons.Length;
    AtualizarPokemon();
  }
  private void AtualizarPokemon(){
    // percorrer vetor de pokemons para atualizar a categoria do pokemon
    for(int i = 0; i < np; i++){
      //Cada pokemon no vetor 
      Pokemon p = pokemons[i];
      // Recuperar o tipo do pokemon
      Type t = NType.Singleton.Listar(p.TypeId);
      // Associaçäo entre tipo e pokemon
      if(t != null){
        p.SetType(t);
        t.PokemonInserir(p);
      }
    }
  }
  public void Salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(Pokemon[])); 
    StreamWriter f = new StreamWriter("./pokemons.xml",false,Encoding.Default);
    xml.Serialize(f, Listar());
    f.Close();
  }
  
  public Pokemon[] Listar(){
    Pokemon[] p = new Pokemon[np];
    Array.Copy(pokemons, p, np);
    return p;
  }

  public Pokemon Listar(int id){
    for(int i = 0; i < np; i++){
      if(pokemons[i].GetId() == id) return pokemons[i];
    }
    return null;
  }

  public void Inserir(Pokemon p){
    if(np == pokemons.Length){
      Array.Resize(ref pokemons, 2 * pokemons.Length);
    }
    pokemons[np] = p;
    np++;

    Type t = p.GetType();
    if(t != null) t.PokemonInserir(p);
  }

  public void Atualizar(Pokemon p){
    Pokemon p_atual = Listar(p.GetId());
    p_atual.SetName(p.GetName());
    p_atual.SetHeigth(p.GetHeigth());
    p_atual.SetWeigth(p.GetWeigth());
    p_atual.SetHp(p.GetHp());
    p_atual.SetAttack(p.GetAttack());
    p_atual.SetDefense(p.GetDefense());
    p_atual.SetSpAttack(p.GetSpAttack());
    p_atual.SetSpDefense(p.GetSpDefense());
    p_atual.SetSpeed(p.GetSpeed());
    if(p_atual.GetType() != null){
      p_atual.GetType().PokemonExcluir(p_atual);
    }
    p_atual.SetType(p.GetType());
    if(p_atual.GetType() != null){
      p_atual.GetType().PokemonInserir(p_atual);
    }

  }

  private int Indice(Pokemon p){
    for(int i = 0; i < np; i++){
      if(pokemons[i] == p) return i;
    }
    return -1;
  }

  public void Excluir(Pokemon p){
    int n = Indice(p);
    if(n == -1) return;

    for(int i = n; i < np - 1; i++){
      pokemons[i] = pokemons[i + 1];
    }
    np--;
    Type t = p.GetType();
    if(t != null) t.PokemonExcluir(p);
  }
}
