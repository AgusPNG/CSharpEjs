// using System;
// using System.Collections.Generic;
// using System.Formats.Asn1;
// using System.Security.Cryptography.X509Certificates;

// namespace Test{
//     class Test{
//         static void Main(string[] args){
//             int [] numbers = {1,2,3};
//             numbers = numbers.Addnumber(4);

//             foreach(int num in numbers)
//                 Console.Write(num);
//         }
//     }
//     static public class Extension{
//         static public int [] Addnumber(this int [] array,int num){
//             int [] newarray = new int[array.Length+1];
//             for(int i=0; i<=array.Length-1; i++)
//                 newarray[i] = array[i];
//             newarray[array.Length] = num;
//             return newarray;
//         }
//     }
// }