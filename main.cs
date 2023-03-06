
using System;
class conta bancaria 

    
    public string nome;
    public string extrato;
    double saldo;
    double credito;
    
    public nome(string User)
    
    {
        nome = User
    }
     
     static void Main(string[] args)
    {
        conta bancaria User = new conta bancaria();
        User.nome = "José Siqueira Peixoto";
        User.extrato = "798";
        User.saldo = "123,76";
        User.credito = "675,43";
        
        Console.WriteLine(user.nome);
    }
}
  