// using System;
// using System.Collections.Generic;

// namespace Test{
//     class Ej11{
//         static void Main(string[] args){
//             //1 - Crear una clase cuenta bancaria que nos permita depositar y retirar dinero, cada objeto va a ser un usuario con su cuenta, debera tener, nombre, apellido, numero de cuenta, MONTO y los metodos correspondientes para depositar y retirar dinero, utilizar encapsulamiento y realizar las validaciones correspondientes
//             CuentaBancaria usuario = new CuentaBancaria();
//             CuentaBancaria usuario2 = new CuentaBancaria();
            
//             usuario.Edad = 20;
//             usuario.Nombre = "Adrian";
//             usuario.Apellido = "Quispe";
//             usuario.Monto = 1000;
//             usuario.Cuenta = 1234567;
//             usuario.depositar(1500);
//             usuario.retirar(100);
//             usuario.mostrar();

//             usuario.Edad = 30;
//             usuario.Nombre = "Paula";
//             usuario.Apellido = "Piana";
//             usuario.Monto = 5000;
//             usuario.Cuenta = 7654321;
//             usuario.depositar(100);
//             usuario.retirar(6000);
//             usuario.mostrar();
//         }
//     }
//     class CuentaBancaria{
//         private int edad;
//         public int Edad{
//             get {return edad;}
//             set{
//                 if(value >= 18)
//                     edad = value;
//                 else
//                     Console.WriteLine("Error: edad incorrecta");
//             }
//         }
//         private string? nombre;
//         public string? Nombre{
//             get{return nombre;}
//             set{
//                 if(!string.IsNullOrEmpty(value))
//                     nombre = value;
//                 else
//                     Console.WriteLine("Error: nombre incorrecto");
//             }
//         }
//         private string? apellido;
//         public string? Apellido{
//             get{return apellido;}
//             set{
//                 if(!string.IsNullOrEmpty(value))
//                     apellido = value;
//                 else
//                     Console.WriteLine("Error: apellido incorrecto");
//             }
//         }
//         private int cuenta;
//         public int Cuenta{
//             get{return cuenta;}
//             set{
//                 if(value >= 1000000)
//                     cuenta = value;
//                 else
//                     Console.WriteLine("Error: numero de cuenta mal puesto");
//             }
//         }
//         private decimal monto;
//         public decimal Monto{
//             get {return monto;}
//             set{
//                 if(value >= 1)
//                     monto = value;
//                 else
//                     Console.WriteLine("Error: ingresa un valor mayor a 1");
//             }
//         }
//         public void depositar(int deposito){
//             if(deposito >= 1)
//                 this.monto += deposito;
//             else
//                 Console.WriteLine("Error: Depositar una cantidad mayor o igual a uno");
//         }
//         public void retirar(int retiro){
//             if(retiro <= this.monto)
//                 this.monto -= retiro;
//             else
//                 Console.WriteLine("Error: No tienes esa cantidad para retirar");
//         }
//         public void mostrar(){
//             Console.WriteLine("\n------------------------------");
//             Console.WriteLine("Nombre: "+this.nombre);
//             Console.WriteLine("Apellido: "+this.apellido);
//             Console.WriteLine("Edad: "+this.edad);
//             Console.WriteLine("Nro de Cuenta: "+this.cuenta);
//             Console.WriteLine("Monto actual: "+this.monto);
//             Console.WriteLine("------------------------------\n");
//         }
//     }
// }