// using System;
// using System.Collections.Generic;

// namespace Test{
//     class Ej10{
//         static void Main(string[] args){
//             // 2) Crear una clase Auto, que cuente con modelo, marca, propiedad y encendido, debe contar con 3 metodos, el de encender que modifica la propiedad encendido de a true, el de apagar que debe pasar encendido a false, y el de ESTADO que nos debe mostrar el estado actual del auto de la siguiente forma: "El auto FIAT CRONOS esta encendido
//             Auto fiat = new Auto();
//             fiat.Modelo = "CRONOS";
//             fiat.Año = "2000";
//             fiat.Marca = "FIAT";
//             fiat.Encedido = true;

//             fiat.Estado();
//         }
//     }
//     public class Auto{
//         public string? Modelo;
//         public string? Año;
//         public string? Marca;
//         public string? Public;
//         public bool Encedido;
//         public void Encender(){
//             this.Encedido = true;
//         }
//         public void Apagar(){
//             this.Encedido = false;
//         }
//         public void Estado(){
//             string EstaEncendido(bool encendido) => encendido ? "encendido" : "apagado";
//             Console.WriteLine("El auto "+this.Marca+" "+this.Modelo+" esta "+ EstaEncendido(this.Encedido));
//         }
//     }
// }