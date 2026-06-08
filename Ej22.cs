// public interface IEmpleado{
//     public string Nombre{get; set;}
//     public int Id{get; set;}
//     public double SalarioBase{get; set;}
    
//     public double CalcularSalario();
// }

// public class EmpleadoFullTime : IEmpleado{
//     private string nombre;
//     private int id;
//     public int Id{
//         get{return id;}
//         set{id = value;}
//     }
//     public string Nombre{
//         get{return nombre;}
//         set{nombre = value;}
//     }
//     public double Bono;
//     public EmpleadoFullTime(string nombre, int id, double salarioBase, double bono) : base(nombre, id, salarioBase){
//         Bono = bono;
//     }
//     public override double CalcularSalario(){
//         return SalarioBase + Bono;
//     }
// }
// public class EmpleadoPorHora : IEmpleado{
//     private string nombre;
//     private int id;
//     public int Id{
//         get{return id;}
//         set{id = value;}
//     }
//     public string Nombre{
//         get{return nombre;}
//         set{nombre = value;}
//     }
//     public int HorasTrabajadas;
//     public double ValorHora;
//     public EmpleadoPorHora(string nombre, int id, int horas, double valor) : base(nombre, id, 0){
//         HorasTrabajadas = horas;
//         ValorHora = valor;
//     }
//     public override double CalcularSalario(){
//         return HorasTrabajadas * ValorHora;
//     }
// }
// class Program{
//     static void Main()
//     {
//         List<Empleado> nomina = new List<Empleado>();
//         EmpleadoFullTime emp1 = new EmpleadoFullTime("Ana Lopez", 101, 30000, 5000);
//         nomina.Add(emp1);
//         nomina.Add(new EmpleadoPorHora("Juan Perez", 102, 40, 500));
//         Console.WriteLine("--- Recibos de Sueldo ---");
//         foreach (Empleado emp in nomina)
//         {
//             Console.WriteLine($"Empleado: {emp.Nombre} (ID: {emp.Id})");
//             Console.WriteLine($"Total a cobrar: ${emp.CalcularSalario()}");
//             Console.WriteLine("-------------------------");
//         }
//     }
// }