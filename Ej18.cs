//Pide al usuario un número. Intenta guardarlo en una variable de tipo byte (que solo acepta valores de 0 a 255). Utiliza el bloque checked junto con try-catch para capturar un OverflowException si el usuario introduce un número fuera de ese rango.
namespace test;

class Program{
    public static void Main(){
        try{
            checked{
                Console.Write("Numero byte: ");
                byte num = byte.Parse(Console.ReadLine());
            }
        }
        catch(System.OverflowException e){
            Console.WriteLine(e.Message);
        }
    }
}