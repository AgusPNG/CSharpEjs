// //Solicita al usuario que ingrese su edad como texto. Intenta convertir ese texto a un número entero usando int.Parse(). Captura la excepción FormatException por si el usuario escribe letras en lugar de números.

// namespace test;

// class Program{
//     public static void Main(){
//         try{
//             Console.Write("Ingresa tu edad: ");
//             int edad = int.Parse(Console.ReadLine());
//         }
//         catch(System.FormatException e){
//             Console.WriteLine(e.Message);
//         }
//     }
// }