// //Crea una función llamada ValidarEdad(int edad). Si la edad es menor de 18, debe lanzar una excepción del tipo ArgumentOutOfRangeException con el mensaje "Acceso denegado: Debes ser mayor de edad". En el método principal, llama a esta función dentro de un try-catch y muestra el mensaje de la excepción.

// namespace test;
// class Program{
//     public static void Main(){
//         try{
//             Console.Write("Edad: ");
//             int edad = int.Parse(Console.ReadLine());
//             ValidarEdad(edad);
//         }
//         catch(ArgumentOutOfRangeException e){
//             Console.WriteLine(e.Message);
//         }
//         catch(FormatException e){
//             Console.WriteLine(e.Message);
//         }
//     }
//     public static void ValidarEdad(int edad){
//         if(edad < 18) throw new ArgumentOutOfRangeException("Acceso denegado: debes ser mayor de edad");
//     }
// }