// //Ejercicio 2: Aplicar herencia y constructores con base. Clase padre: Mensaje (Atributos: Destinatario, Textoo). Clases hijas: Email (agrega Asunto) y SMS (agrega NumeroTelefono).Implementar un método Enviar() que sea diferente para cada uno.

// public abstract class Mensaje{
//     public string Texto;
//     public string Destinatorio;
//     public Mensaje(string text, string destinatorio){
//         Texto = text;
//         Destinatorio = destinatorio;
//     }
//     public abstract void Enviar();
// }
// public class Email : Mensaje{
//     public string Asunto;
//     public Email(string text, string destinatorio, string asunto) : base(text,destinatorio){
//         Asunto = asunto;
//     }
//     public override void Enviar(){
//         Console.WriteLine($"Enviaste un Email. Asunto: {Asunto}, Mensaje: {Texto}");
//     }
// }
// public class SMS : Mensaje{
//     public int NumeroTelefono;
//     public SMS(string text, string destinatorio, int numeroTelefono) : base(text,destinatorio){
//         NumeroTelefono = numeroTelefono;
//     }
//     public override void Enviar(){
//         Console.WriteLine($"Enviaste un SMS. Mensaje: {Texto}");
//     }
// }
// class Program{
//     public static void Main(){
//         Email email = new Email("hola","nose@gmail.com","saludo");
//         email.Enviar();

//         SMS sms = new SMS("hola","nose@gmail.com",123456);
//         sms.Enviar();
//     }
// }