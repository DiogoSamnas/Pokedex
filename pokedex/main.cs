using System;

class MainClass{
  public static void Main(){
    
    Type grass = new Type(2,"Grass");
    Pokemon poke1 = new Pokemon(1,"Bulbasaur", 0.7, 6.9, 45, 49, 49, 65, 65, 45, grass);
    Pokemon poke2 = new Pokemon(2,"Ivysaur", 1.0, 13.0, 60, 62, 63, 80, 80, 60, grass);

    Console.WriteLine(poke1);
    Console.WriteLine(poke2);

  }
}
