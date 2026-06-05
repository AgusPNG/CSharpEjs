// //Crea un array de 3 elementos enteros. Pide al usuario que introduzca un índice (por ejemplo, 0, 1, 2) y un número para colocar en esa posición. Usa int.Parse() para el índice. Debes manejar FormatException (si no introduce un número) y IndexOutOfRangeException (si introduce un índice como 5 o -1). Además, añade un bloque finally que imprima siempre "Fin de la operación".

// namespace test;

// class Program{
//     public static void Main(){
//         int[] numbers = {1,2,3};
//         try{
//             Console.Write("Indice del array: ");
//             int index = int.Parse(Console.ReadLine());
//             Console.WriteLine("En el indice "+index+" hay un "+numbers[index]);
//         }
//         catch(FormatException e){
//             Console.WriteLine(e.Message);
//         }
//         catch(IndexOutOfRangeException e){
//             Console.WriteLine(e.Message);
//         }
//         finally{
//             Console.WriteLine("Fin de la operacion");
//         }
//     }
// }