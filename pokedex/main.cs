using System;

class MainClass{
  public static void Main(){
    bool loop = true;
    Type grass = new Type(2,"Grass");

    Pokemon poke1 = new Pokemon(1,"Bulbasaur", 0.7, 6.9, 45, 49, 49, 65, 65, 45, grass);
    Pokemon poke2 = new Pokemon(2,"Ivysaur", 1.0, 13.0, 60, 62, 63, 80, 80, 60, grass);

    grass.PokemonInserir(poke1);
    grass.PokemonInserir(poke2);

    Pokemon[] v = grass.PokemonListar();
    Console.WriteLine("Pokemons tipo: " + grass.GetDescricao());
    foreach(Pokemon p in v) Console.WriteLine(p);
    Console.WriteLine();


    while(loop) {
      Console.WriteLine("1 - Cadastrar Tipo");
      Console.WriteLine("2 - Cadastrar Pokemon");
      Console.WriteLine("3 - Sair");

      int res = int.Parse(Console.ReadLine());
      switch(res) {
        case 1: 
          Console.WriteLine("Tipo");
          break;
        case 2:
          Console.WriteLine("Pokemon");
          break;
        case 3:
          loop = false;
          Console.Clear();
          Console.WriteLine("Você saiu!");
          break;
        default:
          Console.WriteLine("Opção inválida");
          break;
      }
    }
  }
}
