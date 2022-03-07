using System;

class EquipePokemon{
  // atributos do pokemon de EquipePokemon
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
  //Associação entre EquipePokemon e pokemon
  private Pokemon pokemon;

  public EquipePokemon(Pokemon pokemon){
    this.id = pokemon.GetId();
    this.name  = pokemon.GetName();
    this.heigth = pokemon.GetHeigth();
    this.weigth = pokemon.GetWeigth();
    this.hp = pokemon.GetHp();  
    this.attack = pokemon.GetAttack();
    this.defense = pokemon.GetDefense();
    this.spAttack = pokemon.GetSpAttack();
    this.spDefense = pokemon.GetSpDefense();
    this.speed = pokemon.GetSpeed();
    this.pokemon = pokemon;
  }
  public void SetPokemon(Pokemon pokemon){
    this.pokemon = pokemon;
  }

  public Pokemon GetPokemon(){
    return pokemon;
  }

  public override string ToString(){
    return id + " - " + name + " | heigth = " + heigth + " m" + " | weigth = " + weigth + " kg" + " | hp = " + hp + " | attack = " + attack + " | defense = " + defense + " | spAttack = " + spAttack + " | spDefense = " + spDefense + " | speed = " + speed;
  }
}