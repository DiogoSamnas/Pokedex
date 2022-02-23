using System;
using System.Collections.Generic;

class MainClass{
  private static NType ntype = new NType();
  private static NPokemon npokemon = new NPokemon();
  private static NUser nuser = new NUser();
  private static User userLogin = null;
  public static void Main(){
    int op = 0;
    int perfil = 0;
    Console.WriteLine("............. PokeList ............. ");
    do{
      try{
        if(perfil == 0){
          //perfil do convidado
          op = 0;
          perfil = MenuConvidado();
        }
        if(perfil == 1){
          //pefil do admin
          op = MenuAdmin();
          switch(op){
            case 1 : TypeListar(); break;
            case 2 : TypeInserir(); break;
            case 3 : TypeAtualizar(); break;
            case 4 : TypeExcluir(); break;
            case 5 : PokemonListar(); break;
            case 6 : PokemonInserir(); break;
            case 7 : PokemonAtualizar(); break;
            case 8 : PokemonExcluir(); break;
            case 9 : UserListar(); break;
            case 10 : UserInserir(); break;
            case 11 : UserAtualizar(); break;
            case 12 : UserExcluir(); break;
            case 99 : perfil = 0; break;
          }
        }
        if(perfil == 2 && userLogin == null){
          // usuário não logado
          op = MenuUserLogin();
          switch(op){
            case 1 : UserLogin(); break;
            case 99 : perfil = 0; break;
          }
        }
        if(perfil == 2 && userLogin != null){
          // usuário logado
          op = MenuUserLogout();
          switch(op){
            case 1 : UserEquipeListar(); break;
            case 2 : UserPokemonListar(); break;
            case 3 : UserPokemonInserir(); break;
            case 4 : UserEquipeLimpar(); break;
            case 99 : UserLogout(); break;
          }
        }
      }
      catch(Exception erro){
        Console.WriteLine(erro.Message);
        op = 100;
      }

    } while(op != 0);
    Console.WriteLine("Goodbye...");
  }
  public static int MenuConvidado(){
    Console.WriteLine("...........................................");
    Console.WriteLine("1 - Entrar como administrador");
    Console.WriteLine("2 - Entrar como usuário");
    Console.WriteLine("------------------------");
    Console.WriteLine("0 - Finalizar Aplicação");
    Console.WriteLine("------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static int MenuUserLogin(){
    Console.WriteLine("...........................................");
    Console.WriteLine("1 - Login");
    Console.WriteLine("------------------------");
    Console.WriteLine("99 - Voltar");
    Console.WriteLine("0 - Finalizar Aplicação");
    Console.WriteLine("------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static int MenuUserLogout(){
    Console.WriteLine("...........................................");
    Console.WriteLine("Bem vindo(a), " + userLogin.Nome);
    Console.WriteLine("...........................................");
    Console.WriteLine("1 - Ver minha equipe");
    Console.WriteLine("2 - Listar Pokemons");
    Console.WriteLine("3 - Adicionar Pokemons a equipe");
    Console.WriteLine("4 - Limpar equipe");
    Console.WriteLine("------------------------");
    Console.WriteLine("99 - Logout");
    Console.WriteLine("0 - Finalizar Aplicação");
    Console.WriteLine("------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static int MenuAdmin(){
    Console.WriteLine();
    Console.WriteLine("...........................................");
    Console.WriteLine("01 - Tipos - Listar");
    Console.WriteLine("02 - Tipos - Inserir");
    Console.WriteLine("03 - Tipos - Atualizar");
    Console.WriteLine("04 - Tipos - Excluir");
    Console.WriteLine("05 - Pokemon - Listar");
    Console.WriteLine("06 - Pokemon - Inserir");
    Console.WriteLine("07 - Pokemon - Atualizar");
    Console.WriteLine("08 - Pokemon - Excluir");
    Console.WriteLine("09 - Usuário - Listar");
    Console.WriteLine("10 - Usuário - Inserir");
    Console.WriteLine("11 - Usuário - Atualizar");
    Console.WriteLine("12 - Usuário - Excluir");
    Console.WriteLine("------------------------");
    Console.WriteLine("99 - Voltar");
    Console.WriteLine("0 - Finalizar Aplicação");
    Console.WriteLine("------------------------");
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

public static void UserListar(){
    Console.WriteLine("............. Lista de usuários ............. ");
    // Lista os usuários
    List<User> us = nuser.Listar();
    if(us.Count == 0){
      Console.WriteLine("Nehum usuário cadastrado :(");
      return;
    }
    foreach(User u in us){
      Console.WriteLine(u);
    }
    Console.WriteLine();
  }
  public static void UserInserir(){
    Console.WriteLine("............. Adicionar usuário ............. ");
    Console.Write("Infome o nome do usuário: ");
    string nome = Console.ReadLine();
    // Instancia a classe de usuário
    User u = new User{Nome = nome};
    // Insere o usuário
    nuser.Inserir(u);
  }
  public static void UserAtualizar(){
    Console.WriteLine("............. Atualizar usuário ............. ");
    UserListar();
    Console.Write("Informe o código do usuário para atualizar:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Infome o novo nome de usuário:");
    string nome = Console.ReadLine();
    // Instancia a classe de usuário
    User u = new User{Id = id,  Nome = nome};
    // Atualiza o usuário
    nuser.Atualizar(u);
  }
  public static void UserExcluir(){
    Console.WriteLine("............. Excluir usuário ............. ");
    UserListar();
    Console.Write("Informe o código do usuário a ser excluído: ");
    int id = int.Parse(Console.ReadLine());
    // Procura o usuário com o id informado
    User u  = nuser.Listar(id);
    // Exclui o usuário 
    nuser.Excluir(u);
  }
  public static void UserLogin(){
    Console.WriteLine("----- Login -----");
    UserListar();
    Console.Write("Informe o código do usuário para logar:");
    int id = int.Parse(Console.ReadLine());
    userLogin = nuser.Listar(id);
  }
  public static void UserLogout(){
    Console.WriteLine("----- Logout -----");   
    userLogin = null;   
  }
  public static void UserEquipeListar(){
    Console.WriteLine("----- Visualizar equipe -----");              
  }
  public static void UserPokemonListar(){
    Console.WriteLine("----- Visualizar Pokemons -----"); 
  }
  public static void UserPokemonInserir(){
    Console.WriteLine("----- Adicionar Pokemons a equipe -----"); 
  }
  public static void UserEquipeLimpar(){
    Console.WriteLine("----- Limpar equipe -----"); 
  }
}
