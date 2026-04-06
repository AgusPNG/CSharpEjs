using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Test{
    class Ej8{
        static void Main(string[] args) {
            //deberan emular el funcionamiento del .Count que nos permite saber el tamaño de una lista, pueden utilizar bucles para contar
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);

            Console.Write(count(numbers));
        }
        static int count(List<int> newarray){
            int i=0;
            foreach(int j in newarray)
                i++;
            return i;
        }
    }
}
