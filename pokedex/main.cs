using System;

class MainClass{
  private static NType ntype = new NType();
  public static void Main(){
    int op = 0;
    Console.WriteLine("............. PokeList ............. ");
    do{
      try{
        op = Menu();
        switch(op){
          case 1 : TypeListar(); break;
          case 2 : TypeInserir(); break;
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
    Console.Write("Infome o nome do tipo: ");
    string description = Console.ReadLine();

    Type t = new Type(id, description);

    ntype.Inserir(t);
  }
}
