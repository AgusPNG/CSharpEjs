using System;
using System.Collections.Generic;

namespace Test{
    class Ej6{
        static void Main(string[] args) {
            //Ordenar de forma inversa la siguiente lista: int [] numbers = { 7, 6, 3, 3, 1, 5 }; → [7, 6, 5, 3, 3, 1]
            int [] numbers = { 7, 6, 3, 3, 1, 5 };
            int half = (numbers.Length-1)/2;
            int aux;
            for(int i=0; i<=half; i++) {
                aux = numbers[i];
                numbers[i] = numbers[numbers.Length-1-i];
                numbers[numbers.Length-1-i] = aux;
            }
            foreach(int num in numbers)
                Console.Write(num);
        }
    }
}