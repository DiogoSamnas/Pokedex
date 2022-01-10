using System;

class NPokemon{
  private Pokemon[] pokemons = new Pokemon[10];
  private int np;


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
