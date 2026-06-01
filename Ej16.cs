// //Pide al usuario dos números enteros. Realiza la división del primero entre el segundo. Usa un bloque try-catch para capturar específicamente la excepción que ocurre cuando el segundo número es cero (DivideByZeroException) y muestra un mensaje amigable.

// namespace test;
// class Program{
//     public static void Main(){
//         Console.Write("Numero 1: ");
//         int num1 = int.Parse(Console.ReadLine());
//         Console.Write("Numero 2: ");
//         int num2 = int.Parse(Console.ReadLine());

//         try{
//             num1 /= num2;
//             Console.WriteLine($"El resultado de la division es: {num1}");
//         }
//         catch(System.DivideByZeroException e){
//             Console.WriteLine(e.Message);
//         }
//     }
// }