using System;


class Pokemon{
  private int id;
  private string name;
  private double heigth;
  private double weigth;
  private int hp;
  private int attack;
  private int defense;
  private int spAttack;
  private int spDefense;
  private int speed;
  private Type type;

  public Pokemon(int id, string name, double heigth, double weigth, int hp, int attack, int defense, int spAttack, int spDefense, int speed, Type type){
    this.id = id;
    this.name = name;
    this.heigth = heigth;
    this.weigth = weigth;
    this.hp = hp > 0 ? hp : 1;
    this.attack = attack > 0 ? attack : 1;
    this.defense = defense;
    this.spAttack = spAttack;
    this.spDefense = spDefense;
    this.speed = speed;
    this.type = type;
  }

  public void SetId(int id){
    this.id = id;
  }
  public void SetName(string name){
    this.name = name;
  }
  public void SetHeigth(double heigth){
    this.heigth = heigth > 0 ? heigth : 0.1;
  }
  public void SetWeigth(double weigth){
    this.weigth = weigth > 0 ? weigth : 0.1;
  }
  public void SetHp(int hp){
    this.hp = hp > 0 ? hp : 1;
  }
  public void SetAttack(int attack){
    this.attack = attack > 0 ? attack : 1;
  }
  public void SetDefense(int defense){
    this.defense = defense > 0 ? defense : 1;
  }
  public void SetSpAttack(int spAttack){
    this.spAttack = spAttack > 0 ? spAttack : 1;
  }
  public void SetSpDefense(int spDefense){
    this.spDefense = spDefense > 0 ? spDefense : 1;
  }
  public void SetSpeed(int speed){
    this.speed = speed > 0 ? speed : 1;
  }
  public void SetType(Type type){
    this.type = type;
  }

  public int GetId(){
    return id;
  }

  public string GetName(){
    return name;
  }
  public double GetHeigth(){
    return heigth;
  }
  public double GetWeigth(){
    return weigth;
  }
  public int GetHp(){
    return hp;
  }
  public int GetAttack(){
    return attack;
  }
  public int GetDefense(){
    return defense;
  }
  public int GetSpAttack(){
    return spAttack;
  }
  public int GetSpDefense(){
    return defense;
  }
  public int GetSpeed(){
    return speed;
  }
  public Type GetType(){
    return type;
  }

  public override string ToString(){
    if(type == null){
      return id + " - " + name + " | heigth = " + heigth + " m" + " | weigth = " + weigth + " kg" + " | hp = " + hp + " | attack = " + attack + " | defense = " + defense + " | spAttack = " + spAttack + " | spDefense = " + spDefense + " | speed = " + speed;
    }
    else
      return id + " - " + name + " | heigth = " + heigth + " m" + " | weigth = " + weigth + " kg" + " | hp = " + hp + " | attack = " + attack + " | defense = " + defense + " | spAttack = " + spAttack + " | spDefense = " + spDefense + " | speed = " + speed + " | Type = " + type.GetDescription();
  }
}