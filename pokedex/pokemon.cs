using System;


public class Pokemon{
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
  private int typeId;

  private Type type;

  // Propriedades e construtor necessários para serialização
  public int Id {get => id; set => id = value;}
  public string Name {get => name; set => name = value;}
  public double Heigth {get => heigth; set => heigth = value;}
  public double Weigth {get => weigth; set => weigth = value;}
  public int Hp {get => hp; set => hp = value;}
  public int Attack {get => attack; set => attack = value;}
  public int Defense {get => defense; set => defense = value;}
  public int SpAttack {get => spAttack; set => spAttack = value;}
  public int SpDefense {get => spDefense; set => spDefense = value;}
  public int Speed {get => speed; set => speed = value;}
  public int TypeId {get => typeId; set => typeId = value;}

  public Pokemon(){}
  

  public Pokemon(int id, string name, double heigth, double weigth, int hp, int attack, int defense, int spAttack, int spDefense, int speed){
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
  }
  public Pokemon(int id, string name, double heigth, double weigth, int hp, int attack, int defense, int spAttack, int spDefense, int speed, Type type) : this(id, name, heigth, weigth, hp, attack, defense, spAttack, spDefense, speed){
    this.type = type;
    this.typeId = type.GetId();
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
    this.typeId = type.GetId();
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