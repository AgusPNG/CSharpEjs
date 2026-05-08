// //Crear una jerarquía simple para entender abstract y override. Crea una clase abstracta Vehiculo con un método abstracto Mover(). Crea dos clases derivadas: Auto y Avion. Implementa Mover() para que el auto imprima "El auto corre por la carretera" y el avión "El avión vuela por los aires".

// public abstract class Vehiculo{
//     public abstract void Mover();
// }
// public class Auto : Vehiculo{
//     public override void Mover(){
//         Console.WriteLine("El auto corre por la carretera");
//     }
// }
// public class Avion : Vehiculo{
//     public override void Mover(){
//         Console.WriteLine("El avion vuela por los aires");
//     }
// }
// class Program{
//     public static void Main(){
//         Auto vehiculo1 = new Auto();
//         Avion vehiculo2 = new Avion();
//         vehiculo1.Mover();
//         vehiculo2.Mover();
//     }
// }