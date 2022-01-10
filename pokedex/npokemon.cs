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
}
