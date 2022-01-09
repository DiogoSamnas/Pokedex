using System;

class NType{
  private Type[] types = new Type[10];
  private int nt;


  public Type[] Listar(){
    Type[] t = new Type[nt];
    Array.Copy(types, t, nt);
    return t;
  }

  public Type Listar(int id){
    for(int i = 0; i < nt; i++){
      if(types[i].GetId() == id) return types[i];
    }
    return null;
  }

  public void Inserir(Type t){
    if(nt == types.Length){
      Array.Resize(ref types, 2 * types.Length);
    }
    types[nt] = t;
    nt++;
  }
}
