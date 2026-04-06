// using System;
// using System.Collections.Generic;

// namespace Test{
//     class Ej6{
//         static void Main(string[] args){
//             //Ordenar de forma inversa la siguiente lista: int [] numbers = { 7, 6, 3, 3, 1, 5 }; → [7, 6, 5, 3, 3, 1]
//             int [] numbers = { 7, 6, 3, 3, 1, 5 };
//             int aux;

//             for(int i=0; i<=numbers.Length-1; i++){
//                 for(int j=0; j<=numbers.Length-1; j++){
//                     if(numbers[i] > numbers[j]){
//                         aux = numbers[i];
//                         numbers[i] = numbers[j];
//                         numbers[j] = aux;
//                     }
//                 }
//             }
//             foreach(int num in numbers)
//                 Console.Write(num);
//         }
//     }
// }