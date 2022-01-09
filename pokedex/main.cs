using System;
using System.Collections;

class MainClass{
  public static void Main(){
    bool loop = true;
    Type grass = new Type(2,"Grass");
    ArrayList pokemons = new ArrayList();

    Pokemon poke = new Pokemon(1,"Bulbasaur", 0.7, 6.9, 45, 49, 49, 65, 65, 45, grass);
    pokemons.Add(poke);

    poke = new Pokemon(2,"Ivysaur", 1.0, 13.0, 60, 62, 63, 80, 80, 60, grass);
    pokemons.Add(poke);

    Console.Clear();
    while(loop) {
      Console.WriteLine("1 - Listar Pokemons");
      Console.WriteLine("2 - Cadastrar Tipo");
      Console.WriteLine("3 - Cadastrar Pokemon");
      Console.WriteLine("4 - Sair");

      int res = int.Parse(Console.ReadLine());
      switch(res) {
        case 1:
          Console.WriteLine("Pokemons Cadastrados:");
          foreach(Pokemon pokemon in pokemons) {
            Console.WriteLine(pokemon);
          }
          break;
        case 2: 
          Console.WriteLine("Tipo");
          break;
        case 3:
          Console.WriteLine("Pokemon");
          break;
        case 4:
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
