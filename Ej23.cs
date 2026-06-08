// //Crear una clase Hotel con la capacidad de ver cuantas habitaciones hay disponibles y cuantas hay ocupadas, que sean 2 metodos distintos, tambien crear un metodo que muestre la informacion fiscal del Hotel, Nombre Legal, CUIT, Razon Social y Ganancias (Son todos datos que pueden inventar), todas estas propiedades deben ser privadas por ende deben usar Geters y Seters, deben crear la interface IHotel y heredarlo a la clase Hotel

// namespace test;
// public interface IHotel{
//     public string Nombre{get; set;}
//     public int Cuit{get; set;}
//     public string Razon_social{get; set;}
//     public int Ganancias{get; set;}
//     public int CantDisponibles();
//     public int CantOcupados();
// }

// public class Hotel : IHotel{
//     private List<Habitacion> habitaciones = new List<Habitacion>();
//     private string nombre;
//     private int cuit;
//     private string razon_social;
//     private int ganancias;
//     public string Nombre{
//         get{return nombre;}
//         set{nombre = value;}
//     }
//     public int Cuit{
//         get{return cuit;}
//         set{cuit = value;}
//     }
//     public string Razon_social{
//         get{return razon_social;}
//         set{razon_social = value;}
//     }
//     public int Ganancias{
//         get{return ganancias;}
//         set{ganancias = value;}
//     }
//     public int CantDisponibles(){
//         int i=0;
//         foreach(Habitacion habitacion in habitaciones)
//             if(!habitacion.Ocupado) i++;
//         return i;
//     }
//     public int CantOcupados(){
//         int i=0;
//         foreach(Habitacion habitacion in habitaciones)
//             if(habitacion.Ocupado) i++;
//         return i;
//     }
// }
// public class Habitacion{
//     public bool Ocupado = false;
// }
// class Program{
//     public static void Main(){
//     }
// }