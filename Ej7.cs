// using System;
// using System.Collections.Generic;
// using System.Globalization;
// using System.Security.Cryptography.X509Certificates;

// namespace Test{
//     class Ej7{
//         static void Main(string[] args) {
//             //Crear una funcion que emule la funcion .add de las listas, esta funcion debera poder agregar un item nuevo al final del array tip: int [] numeros2 = new int [5]; → permite crear listas vacias con un tamaño N
//             int [] numbers = {1,2,3};
//             numbers = addnumber(4,numbers);
            
//             foreach(int num in numbers){
//                 Console.Write(num);
//             }

//         }
//         static int[] addnumber(int newitem, int [] newarray){
//             int [] returnarray = new int [newarray.Length+1];
//             for(int i=0; i<=newarray.Length-1; i++)
//                 returnarray[i] = newarray[i];
//             returnarray[newarray.Length] = newitem;

//             return returnarray;
//         }
//     }
// }
