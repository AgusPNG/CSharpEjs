// using System;
// using System.Collections.Generic;

// namespace Test{
//     class Ej2{
//         static void Main(string[] args){
//             //Ordenar la siguiente lista: int [] numbers = { 7, 6, 3, 3, 1, 5 }; → [1, 3, 3, 5, 6, 7]
//             int [] numbers = { 7, 6, 3, 3, 1, 5 };
//             int aux;

//             for(int i=0; i<=numbers.Length-1; i++){
//                 for(int j=0; j<=numbers.Length-1; j++){
//                     if(numbers[i] < numbers[j]){
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