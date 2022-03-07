using System;
using System.Collections.Generic;

class Equipe{
  //Atributos da Equipe
  private int id;
  private string nome;
  private bool salvo;
  // private string nome;
  //Associação entre Equipe e User
  private User user;
  //Associação entre Equipe e EquipePokemon
  private List<EquipePokemon> pokemons = new List<EquipePokemon>();

  public Equipe(string nome, User user){
    this.user = user;
    this.nome = nome;
    this.salvo = true;
  }

  public void SetId(int id){
    this.id = id;
  }
  public void SetNome(string nome){
    this.nome = nome;
  }
  public void SetSalvo(bool salvo){
    this.salvo = salvo;
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
  public bool GetSalvo(){
    return salvo;
  }

  public User GetUser(){
    return user;
  }

  public override string ToString(){
    if(salvo){
      return id + " - " + nome +" - Criador: " + user.Nome;
    }
    else{
      return "(salvo) " + id + " - " + nome +" - Criador: " + user.Nome;
    }
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