// using System;
// using System.Collections.Generic;

// namespace Test{
//     class Ej8{
//         static void Main(string[] args) {
//             //deberan emular el funcionamiento del .Count que nos permite saber el tamaño de una lista, pueden utilizar bucles para contar
//             List<int> numbers = new List<int>();
//             numbers.Add(1);
//             numbers.Add(2);
//             Console.Write(numbers.Cant());
//         }
//     }
//     static public class Extension{
//         static public int Cant(this List<int> newarray){
//             int i=0;
//             foreach(int j in newarray)
//                 i++;
//             return i;
//         }
//     }
// }
