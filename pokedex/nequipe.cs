using System;
using System.Collections.Generic;

class NEquipe{
  private List<Equipe> equipes = new List<Equipe>();

  // Operações
  public List<Equipe> Listar(){
    // Retorna uma lista com as equipes cadastradas
    return equipes;
  }

  public List<Equipe> Listar(User u){
    // Retorna uma lista com as equipes cadastradas do usuário u
    List<Equipe> es = new List<Equipe>();
    foreach(Equipe e in equipes)
      if(e.GetUser() == u) es.Add(e);
    return es;
  }

  public Equipe ListarEquipe(User u){
    // Retorna a equipe do usuário u
    foreach(Equipe e in equipes)
      if(e.GetUser() == u && e.GetSalvo()) return e;
    return null;
  }

  public void Inserir(Equipe e, bool salvo){
    //gerar o id da equipe
    int max = 0;
    foreach(Equipe obj in equipes)
      if(obj.GetId() > max) max = obj.GetId();
    e.SetId(max + 1);
    // Inserir equipe na lista de equipes
    equipes.Add(e);
    // Define o atributo salvo
    e.SetSalvo(salvo);
  }

  public List<EquipePokemon> EquipePokemonListar(Equipe e){
    // Retorna os pokemons da equipe
    return e.EquipePokemonListar();
  }

  public void EquipePokemonInserir(Equipe e, Pokemon p){
    // Inserir um pokemon na lista
    e.EquipePokemonInserir(p);
  }

  public void EquipePokemonExcluir(Equipe e){
    // Remove todos os pokemons da equipe
    e.EquipePokemonExcluir();
  }
}