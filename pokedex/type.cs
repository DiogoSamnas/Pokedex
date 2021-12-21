using System;

class Type{
  private int id;
  private string description;

  public Type(int id, string description){
    this.id = id;
    this.description = description;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetDescripition(string description){
    this.description = description;
  }

  public int GetId(){
    return id;
  }

  public string GetDescription(){
    return description;
  }
  

  public override string ToString(){
    return id + " - " + description;
  }


}