// using System;
// using System.Collections.Generic;
// using System.Dynamic;
// using System.Formats.Asn1;
// using System.Reflection.Metadata.Ecma335;
// using System.Security.Cryptography.X509Certificates;

// /*Hacer una clase llamada Persona que siga las siguientes condiciones:

// ● Sus atributos son: nombre, Edad, Dni, Sexo (H hombre, M mujer), peso y altura. No
// queremos que se accedan directamente a ellos. Pensa que modificador de acceso es el
// más adecuado, también su tipo. Si queres añadir algún atributo podes hacerlo.
// ● Por defecto, todos los atributos menos el Dni serán valores por defecto según su tipo (0
// números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una
// constante para ello.
// ● Se implantaran varios constructores:
// ○ Un constructor por defecto.
// ○ Un constructor con el nombre, Edad y Sexo, el resto por defecto.
// ○ Un constructor con todos los atributos como parámetro.
// ● Los métodos que se implementarán son:
// ○ CalcularIMC(): calculará si la persona está en su peso ideal (peso en
// kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la función
// devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que
// está por debajo de su peso ideal la función devuelve un 0 y si devuelve un valor
// mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te
// recomiendo que uses constantes para devolver estos valores.
// ■ EsMayorDeEdad(): indica si es mayor de Edad, devuelve un booleano.
// ■ ComprobarSexo(char Sexo): comprueba que el Sexo introducido es
// correcto. Si no es correcto, será H. No será visible al exterior.
// ■ GenerarDNI(): genera un número aleatorio de 8 cifras, genera a partir de
// este su número su letra correspondiente. Este método será invocado
// cuando se construya el objeto. Podes dividir el método para que te sea
// más fácil. No será visible al exterior ejemplo de Dni(12345678D).
// ■ Set de cada parámetro, excepto de Dni.

// Ahora, la clase MAIN debe hacer lo siguiente:

// ● Pedir por consola el nombre, la Edad, Sexo, peso y altura.
// ● Crear 3 objetos de la clase anterior el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
// ● Para cada objeto, deberá comprobar si está en su peso ideal, tiene sobrepeso o pordebajo de su peso ideal con un mensaje.
// ● Indicar para cada objeto si es mayor de Edad.
// ● Por último, mostrar la información de cada objeto.

// Podes usar métodos en la clase ejecutable, para que sea mas fácil.*/

// namespace Test{
//     class Ej12{
//         static void Main(string[] args){
            
//             try{
//                 Console.Write("Nombre: ");
//                 string nombre = Console.ReadLine();
//                 Console.Write("Edad: ");
//                 byte edad = byte.Parse(Console.ReadLine());
//                 Console.Write("Sexo: ");
//                 char sexo = char.Parse(Console.ReadLine());
//                 Console.Write("Peso: ");
//                 decimal peso = decimal.Parse(Console.ReadLine());
//                 Console.Write("Altura: ");
//                 decimal altura = decimal.Parse(Console.ReadLine());

//                 Persona usuario1 = new Persona(nombre,edad,sexo,peso,altura);
//                 Persona usuario2 = new Persona(nombre,edad,sexo);
//                 Persona usuario3 = new Persona("Agustin",18,'H',46648714,55.0m,170.0m);
                
//                 usuario1.Mostrar();
//                 usuario2.Mostrar();
//                 usuario3.Mostrar();
//             }
//             catch(Exception e){
//                 Console.WriteLine($"Error: {e}");
//             }
//         }
//     }
// //nombre, Edad, Dni, Sexo (H hombre, M mujer), peso y altura
//     public class Persona{
//         private const char SEXO_DEFAULT = 'H';
//         private string Nombre;
//         private byte Edad;
//         private string Dni;
//         private char Sexo;
//         public decimal peso{
//             get{return Peso;}
//             set{
//                 if(Peso >= 0.0m)
//                     Peso = value;
//                 else
//                     Console.WriteLine("Error: valor de peso invalido");
//             }
//         }
//         public decimal altura{
//             get{return Altura;}
//             set{
//                 if(Altura >= 0.0m)
//                     Altura = value;
//                 else
//                     Console.WriteLine("Error: valor de altura invalido");
//             }
//         }
//         private decimal Peso;
//         private decimal Altura;
// //○ Un constructor por defecto.
//         public Persona(){
//             this.Sexo = SEXO_DEFAULT;
//             this.Dni = GenerarDNI();
//         }
// //○ Un constructor con el nombre, Edad y Sexo, el resto por defecto.
//         public Persona(string nombre, byte Edad, char Sexo){
//             this.Nombre = nombre;
//             this.Edad = Edad;
//             this.Sexo = Sexo;
//             this.Dni = GenerarDNI();
//         }
// //○ Un constructor con todos los atributos como parámetro.
//         public Persona(string nombre, byte edad, char sexo, int dni, decimal peso, decimal altura){
//             this.Nombre = nombre;
//             this.Edad = edad;
//             this.Sexo = sexo;
//             this.Dni = DniConLetra(dni);
//             this.Peso = peso;
//             this.Altura = altura;
//         }
//         public Persona(string nombre, byte edad, char sexo, decimal peso, decimal altura){
//             this.Nombre = nombre;
//             this.Edad = edad;
//             this.Sexo = sexo;
//             this.Dni = GenerarDNI();
//             this.Peso = peso;
//             this.altura = altura;
//         }
//         public void Mostrar(){
//             //string PesoIdeal(int pesoIdeal) => pesoIdeal == -1 ? $"{Nombre} esta en su peso ideal" : pesoIdeal == 0 ? $"{Nombre} esta por debajo de su peso ideal" : $"{Nombre} tiene sobrepeso";
//             string PesoIdeal = CalcularIMC() switch{
//                 -1 => $"\n{Nombre} esta en su peso ideal",
//                 0 => $"\n{Nombre} esta por debajo de su peso ideal",
//                 1 => $"\n{Nombre} tiene sobrepeso",
//                 2 => ""
//             };
//             string Genero(char genero) => genero == 'M' ? "Mujer" : "Hombre";

//             Console.WriteLine("\n------------------------------");
//             Console.WriteLine("Nombre: "+Nombre);
//             Console.WriteLine("Edad: "+Edad);
//             Console.WriteLine("Sexo: "+Genero(Sexo));
//             Console.WriteLine("Dni: "+Dni);
//             Console.WriteLine("Peso: "+Peso);
//             Console.Write("Altura: "+Altura);
//             Console.WriteLine($"{PesoIdeal}");
//             Console.WriteLine("------------------------------\n");
//         }
// /*CalcularIMC(): calculará si la persona está en su peso ideal (peso en
// kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la función
// devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que
// está por debajo de su peso ideal la función devuelve un 0 y si devuelve un valor
// mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te
// recomiendo que uses constantes para devolver estos valores.*/
//         public int CalcularIMC(){
//             int EsIdeal = 2;
//             if(peso > 0 && altura > 0){
//                 switch(peso / (altura*altura)){
//                     case < 20: EsIdeal = -1; break;
//                     case >= 20 and <= 25: EsIdeal = 0; break;
//                     default: EsIdeal = 1; break;
//                 }
//             }
//             return EsIdeal;
//         }
// //■ EsMayorDeEdad(): indica si es mayor de Edad, devuelve un booleano.
//         public bool EsMayorDeEdad(){
//             bool EsMayor(int edad) => edad >= 18 ? true : false;
//             return EsMayor(Edad);
//         }
// /*■ ComprobarSexo(char Sexo): comprueba que el Sexo introducido es
// correcto. Si no es correcto, será H. No será visible al exterior.*/
//         public void ComprobarSexo(){
//             if(!(Sexo == 'M' || Sexo == 'H'))
//                 Sexo = 'H';
//         }
// /*■ GenerarDNI(): genera un número aleatorio de 8 cifras, genera a partir de
// este su número su letra correspondiente. Este método será invocado
// cuando se construya el objeto. Podes dividir el método para que te sea
// más fácil. No será visible al exterior ejemplo de Dni(12345678D).*/
//         static public string GenerarDNI(){
//             int rnd_Dni = new Random().Next(10000000,99999999);
//             return $"{DniConLetra(rnd_Dni)}";
//         }
//         static public string DniConLetra(int Dni){
//             string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
//             char letra = letras[Dni%23];
//             return $"{Dni}{letra}";
//         }
//     }
// }