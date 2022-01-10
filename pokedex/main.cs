using System;

class MainClass{
  private static NType ntype = new NType();
  private static NPokemon npokemon = new NPokemon();
  public static void Main(){
    int op = 0;
    Console.WriteLine("............. PokeList ............. ");
    do{
      try{
        op = Menu();
        switch(op){
          case 1 : TypeListar(); break;
          case 2 : TypeInserir(); break;
          case 3 : TypeAtualizar(); break;
          case 4 : TypeExcluir(); break;
          case 5 : PokemonListar(); break;
          case 6 : PokemonInserir(); break;
          case 7 : PokemonAtualizar(); break;
          case 8 : PokemonExcluir(); break;
        }
      }
      catch(Exception erro){
        Console.WriteLine(erro.Message);
        op = 100;
      }

    } while(op != 0);
    Console.WriteLine("Goodbye...");
  }
  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("...........................................");
    Console.WriteLine("1 - Tipos - Listar");
    Console.WriteLine("2 - Tipos - Inserir");
    Console.WriteLine("3 - Tipos - Atualizar");
    Console.WriteLine("4 - Tipos - Excluir");
    Console.WriteLine("5 - Pokemon - Listar");
    Console.WriteLine("6 - Pokemon - Inserir");
    Console.WriteLine("7 - Pokemon - Atualizar");
    Console.WriteLine("8 - Pokemon - Excluir");
    Console.WriteLine("------------------------");
    Console.WriteLine("0 - Finalizar Aplicação");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static void TypeListar(){
    Console.WriteLine("............. Lista de tipos ............. ");
    Type[] ts = ntype.Listar();
    if(ts.Length == 0){
      Console.WriteLine("Nehum tipo cadastrado :(");
      return;
    }
    foreach(Type t in ts){
      Console.WriteLine(t);
    }
  }
  public static void TypeInserir(){
    Console.WriteLine("............. Adicionar tipo ............. ");
    Console.Write("Informe o código do tipo: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Infome o tipo: ");
    string description = Console.ReadLine();

    Type t = new Type(id, description);

    ntype.Inserir(t);
  }
  public static void TypeAtualizar(){
    Console.WriteLine("............. Atualizar tipo ............. ");
    TypeListar();
    Console.Write("Informe o código do tipo para atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Infome o novo tipo:");
    string description = Console.ReadLine();

    Type t = new Type(id, description);

    ntype.Atualizar(t);
  }
  public static void TypeExcluir(){
    Console.WriteLine("............. Excluir tipo ............. ");
    TypeListar();
    Console.Write("Informe o código do tipo para excluir: ");
    int id = int.Parse(Console.ReadLine());

    Type t = ntype.Listar(id);

    ntype.Excluir(t);
  }

  

  public static void PokemonListar(){
    Console.WriteLine("............. Lista de pokemons ............. ");
    Pokemon[] ps = npokemon.Listar();
    if(ps.Length == 0){
      Console.WriteLine("Nehum pokemon cadastrado :(");
      return;
    }
    foreach(Pokemon p in ps){
      Console.WriteLine(p);
    }
  }

  public static void PokemonInserir(){
    Console.WriteLine("............. Adicionar pokemon ............. ");
    Console.Write("Informe o código do pokemon: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Infome o nome do pokemon: ");
    string name = Console.ReadLine();
    Console.Write("Informe o tamanho do pokemon: ");
    double heigth = double.Parse(Console.ReadLine());
    Console.Write("Informe o peso do pokemon: ");
    double weigth = double.Parse(Console.ReadLine());
    Console.Write("Informe os pontos do vida do pokemon: ");
    int hp = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de ataque do pokemon: ");
    int attack = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de defesa do pokemon: ");
    int defense = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de ataque especial do pokemon: ");
    int spAttack = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de defesa especial do pokemon: ");
    int spDefense = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de velocidade do pokemon: ");
    int speed = int.Parse(Console.ReadLine());


    Console.WriteLine("Tipos de pokemon");
    TypeListar();
    Console.Write("Informe o código do tipo do pokemon: ");
    int idtype = int.Parse(Console.ReadLine());

    Type t = ntype.Listar(idtype);

    Pokemon p = new Pokemon(id, name, heigth, weigth, hp, attack, defense, spAttack, spDefense, speed, t);

    npokemon.Inserir(p);
  }
  public static void PokemonAtualizar(){
    Console.WriteLine("............. Atualizar pokemon ............. ");
    PokemonListar();

    Console.Write("Informe o código do pokemon: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Infome o nome do pokemon: ");
    string name = Console.ReadLine();
    Console.Write("Informe o tamanho do pokemon: ");
    double heigth = double.Parse(Console.ReadLine());
    Console.Write("Informe o peso do pokemon: ");
    double weigth = double.Parse(Console.ReadLine());
    Console.Write("Informe os pontos do vida do pokemon: ");
    int hp = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de ataque do pokemon: ");
    int attack = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de defesa do pokemon: ");
    int defense = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de ataque especial do pokemon: ");
    int spAttack = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de defesa especial do pokemon: ");
    int spDefense = int.Parse(Console.ReadLine());
    Console.Write("Informe os pontos de velocidade do pokemon: ");
    int speed = int.Parse(Console.ReadLine());

    Console.WriteLine("Tipos de pokemon");
    TypeListar();
    Console.Write("Informe o código do tipo do pokemon: ");
    int idtype = int.Parse(Console.ReadLine()); 

    Type t = ntype.Listar(idtype);

    Pokemon p = new Pokemon(id, name, heigth, weigth, hp, attack, defense, spAttack, spDefense, speed, t);

    npokemon.Atualizar(p);
  }
  public static void PokemonExcluir(){
    Console.WriteLine("............. Excluir Pokemon ............. ");
    PokemonListar();
    Console.Write("Informe o código do pokmeon a ser excluido: ");
    int id = int.Parse(Console.ReadLine());

    Pokemon p  = npokemon.Listar(id);

    npokemon.Excluir(p);
  }
}
