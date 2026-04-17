using System;
using System.Collections.Generic;

namespace Test;

class Exam{
    static void Main(string[] args){
        CuentaBancaria juan = new CuentaBancaria("Juan");
        juan.Saldo = 500.0m;
        
        CuentaBancaria maria = new CuentaBancaria("Maria");
        
        juan.TransferirA(maria,200.0m);

        juan.Mostrar();
        maria.Mostrar();
    }
}
class CuentaBancaria{
    public string titular;
    private decimal saldo;
    public decimal Saldo{
        get{return saldo;}
        set{
            if(value >= 0.0m){
                saldo = value;
            }
        }
    }
    public CuentaBancaria(string titular){
        this.titular = titular;
        this.saldo = 0.0m;
    }
    public void Depositar(decimal monto){
        if(saldo >= 0.0m){
            Saldo += monto;
        }
    }
    
    public bool Retirar(decimal monto){
        bool success = false;
        if(saldo >= monto && monto >= 0.0m){
            success = true;
            saldo -= monto;
        }
        return success;
    }
    public void TransferirA(CuentaBancaria tranferirUsuario, decimal monto){
        if(this.Retirar(monto)){
            tranferirUsuario.Depositar(monto);
            Console.WriteLine($"Se transfirio {monto} a {tranferirUsuario.titular} desde la cuenta de {this.titular}");
        }
        else{
            Console.WriteLine($"No se pudo resolver la transaccion, ingresar bien el monto");
        }

    }
    public void Mostrar(){
        Console.WriteLine("========================================");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine("========================================");
    }

}