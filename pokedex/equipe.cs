using System;
using System.Collections.Generic;

class Equipe{
  //Atributos da Equipe
  private int id;
  private string nome;
  //Associação entre Equipe e User
  private User user;
  //Associação entre Equipe e EquipePokemon
  private List<EquipePokemon> pokemons = new List<EquipePokemon>();

  public Equipe(string nome, User user){
    this.nome = nome;
    this.user = user;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetNome(string nome){
    this.nome = nome;
  }

  public void SetUser(User user){
    this.user = user;
  }

  public int GetId(){
    return id;
  }

  public string GetNome(){
    return nome;
  }

  public User GetUser(){
    return user;
  }

  public override string ToString(){
    return id + " - " + nome;
  }

  public void EquipePokemonInserir(Pokemon p){
    EquipePokemon pokemon = new EquipePokemon(p);
    pokemons.Add(pokemon);
  }

  public List<EquipePokemon> EquipePokemonListar(){
    // Retornar a equipe de pokemons
    return pokemons;
  }

  public void EquipePokemonExcluir(){
    // Remove todos os pokemons da equipe
    pokemons.Clear();
  }
}