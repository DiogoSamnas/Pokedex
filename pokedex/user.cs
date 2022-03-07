using System;

public class User : IComparable<User>{
  // Propriedades do usuário
  public int Id {get;set;}
  public string Nome{get;set;}
  public int CompareTo(User obj){
    return this.Nome.CompareTo(obj.Nome);
  }


  public override string ToString(){
    return Id + " - " + Nome;
  }
}