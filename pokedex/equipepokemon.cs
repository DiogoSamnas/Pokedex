using System;

public class EquipePokemon{
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
  private int pokemonId;

  //Propriedades do pokemon
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
  public int PokemonId {get => pokemonId; set => pokemonId = value;}
  public EquipePokemon(){}
  

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
    this.pokemonId = pokemon.GetId();
  }
  public void SetPokemon(Pokemon pokemon){
    this.pokemon = pokemon;
    this.pokemonId = pokemon.GetId();
  }

  public Pokemon GetPokemon(){
    return pokemon;
  }

  public override string ToString(){
    return id + " - " + name + " | heigth = " + heigth + " m" + " | weigth = " + weigth + " kg" + " | hp = " + hp + " | attack = " + attack + " | defense = " + defense + " | spAttack = " + spAttack + " | spDefense = " + spDefense + " | speed = " + speed;
  }
}