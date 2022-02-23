using System;

class Type{
  private int id;
  private string description;
  private Pokemon[] pokemons = new Pokemon[1];
  private int np;

  public Type(int id, string description){
    this.id = id;
    this.description = description;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetDescription(string description){
    this.description = description;
  }

  public int GetId(){
    return id;
  }

  public string GetDescription(){
    return description;
  }
  
  public Pokemon[] PokemonListar(){
    Pokemon[] c = new Pokemon[np];
    Array.Copy(pokemons, c, np);
    return c;
  }
  public void PokemonInserir(Pokemon P){
    if(np == pokemons.Length){
      Array.Resize(ref pokemons, 2 * pokemons.Length);
    }
    pokemons[np] = P;
    np++;
  }
  private int PokemonIndice(Pokemon p){
    for(int i = 0; i < np; i++){
      if(pokemons[i] == p) return i;
    }
    return -1;
  }
  public void PokemonExcluir(Pokemon p){
    int n = PokemonIndice(p);
    if(n == -1) return;
    for(int i = 0; i < np - 1; i++){
      pokemons[i] = pokemons[i + 1];
    }
    n--;
  }

  public override string ToString(){
    return id + " - " + description + " - Nº Pokemons:" + np;
  }


}