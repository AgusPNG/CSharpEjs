using System;
using System.Collections.Generic;

/*Hacer una clase llamada Persona que siga las siguientes condiciones:

● Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No
queremos que se accedan directamente a ellos. Pensa que modificador de acceso es el
más adecuado, también su tipo. Si queres añadir algún atributo podes hacerlo.
● Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0
números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una
constante para ello.
● Se implantaran varios constructores:
○ Un constructor por defecto.
○ Un constructor con el nombre, edad y sexo, el resto por defecto.
○ Un constructor con todos los atributos como parámetro.
● Los métodos que se implementarán son:
○ calcularIMC(): calculará si la persona está en su peso ideal (peso en
kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la función
devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que
está por debajo de su peso ideal la función devuelve un 0 y si devuelve un valor
mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te
recomiendo que uses constantes para devolver estos valores.
■ esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
■ comprobarSexo(char sexo): comprueba que el sexo introducido es
correcto. Si no es correcto, será H. No será visible al exterior.
■ generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de
este su número su letra correspondiente. Este método será invocado
cuando se construya el objeto. Podes dividir el método para que te sea
más fácil. No será visible al exterior ejemplo de DNI(12345678D).
■ Set de cada parámetro, excepto de DNI.

Ahora, la clase MAIN debe hacer lo siguiente:

● Pedir por consola el nombre, la edad, sexo, peso y altura.
● Crear 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables
pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la
altura y el último por defecto, para este último utiliza los métodos set para darle a los
atributos un valor.

● Para cada objeto, deberá comprobar si está en su peso ideal, tiene sobrepeso o por
debajo de su peso ideal con un mensaje.
● Indicar para cada objeto si es mayor de edad.
● Por último, mostrar la información de cada objeto.

Podes usar métodos en la clase ejecutable, para que sea mas fácil.*/

namespace Test{
    class Ej12{
        static void Main(string[] args){
            Persona pablo = new Persona();
            Persona adrian = new Persona("Adrian",17,'M');
            Persona paula = new Persona("Paula",16,'F',123456,50.0m,1.68m);

            pablo.Mostrar();
            adrian.Mostrar();
            paula.Mostrar();
        }
    }
    //nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura
    public class Persona{
        private string? nombre;
        private int edad;
        private int dni;
        private char sexo = 'M';
        public decimal peso{
            get{return Peso;}
            set{
                if(Peso >= 1)
                    Peso = value;
                else
                    Console.WriteLine("Error: valor de peso invalido");
            }
        }
        public decimal altura{
            get{return Altura;}
            set{
                if(Altura >= 100)
                    Altura = value;
                else
                    Console.WriteLine("Error: valor de altura invalido");
            }
        }

        private decimal Peso;
        private decimal Altura;
        //○ Un constructor por defecto.
        public Persona(){
            const char sexoDefault = 'M';
            this.sexo = sexoDefault;
        }
        //○ Un constructor con el nombre, edad y sexo, el resto por defecto.
        public Persona(string nombre, int edad, char sexo){
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        //○ Un constructor con todos los atributos como parámetro.
        public Persona(string nombre, int edad, char sexo, int dni, decimal peso, decimal altura){
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.dni = dni;
            this.Peso = peso;
            this.Altura = altura;
        }
        public void Mostrar(){
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Edad: "+edad);
            Console.WriteLine("Sexo: "+sexo);
            Console.WriteLine("DNI: "+dni);
            Console.WriteLine("Peso: "+Peso);
            Console.WriteLine("Altura: "+Altura);
            Console.WriteLine("------------------------------\n");
        }
        /*calcularIMC(): calculará si la persona está en su peso ideal (peso en
kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la función
devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que
está por debajo de su peso ideal la función devuelve un 0 y si devuelve un valor
mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te
recomiendo que uses constantes para devolver estos valores.*/
        public bool calcularIMC(){
            bool EsIdeal;
            if((peso /= (altura*altura)) < 20)
            return EsIdeal;
        }
        //■ esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.

        public void esMayorDeEdad(){}
        /*■ comprobarSexo(char sexo): comprueba que el sexo introducido es
correcto. Si no es correcto, será H. No será visible al exterior.*/
        public void comprobarSexo(){}
/*■ generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de
este su número su letra correspondiente. Este método será invocado
cuando se construya el objeto. Podes dividir el método para que te sea
más fácil. No será visible al exterior ejemplo de DNI(12345678D).*/
        public void generaDNI(){}

    }
}