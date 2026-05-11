//En base al enunciado de la creacion del banco, vamos a crear una nueva clase, Institucion, la cual va a tener como metodo abstracto PresentarInstitucion, la propia clase sera abstracta, deberan heredar toda la informacion de la clase abstracta a la Clase Banco del examen, y a su ves deberan crear una clase Escuela y una Clase Hospital, las cuales en los siguientes ejercicios agregaremos cosas
namespace Ej15;
class Program{
    static void Main(){
        Escuela etn26 = new Escuela("Confederacion Suiza","Av.Jujuy");
        etn26.AñadirALaInstitucion("Alexis",35478128,23);
        
        Hospital guemes = new Hospital("Guemes","Av.Cordoba");
        guemes.AñadirALaInstitucion("Pedro",29482345,22);
        
        Banco santander = new Banco("Santander","Pueyrredon");
        santander.AñadirALaInstitucion("Juan",12345678,20);
        santander.AñadirALaInstitucion("Maria",87654321,25);

        etn26.Estudiantes[0].RealizarAccion();
        guemes.Medicos[0].RealizarAccion();
        santander.CuentasBancarias[0].RealizarAccion();
        
        // pedro.RealizarAccion();
        // juan.RealizarAccion();
        // alexis.RealizarAccion();

        // juan.Saldo = 500.0m;
        // juan.TransferirA(maria,200.0m);
        // juan.Mostrar();
        // maria.Mostrar();
    }
}
public abstract class Persona{
    protected string Nombre;
    protected int DNI;
    protected int Edad;
    protected string titular;
    public string Titular{
        get{return titular;}
        set{
            if(value != ""){
                titular = value;
                Nombre = value;
            }
            else
                Console.WriteLine("Ingresar bien el titular");
        }
    }
    public Persona(string nombre, int dni, int edad){
        Nombre = nombre;
        DNI = dni;
        Edad = edad;
    }
    public abstract void RealizarAccion();
}
public class Estudiante : Persona{
    protected int Legajo;
    public Estudiante(string nombre, int dni, int edad, int legajo) : base(nombre, dni, edad){
        Legajo = legajo;
    }
    public override void RealizarAccion(){
        Console.WriteLine("El estudiante esta estudiando");
    }
}
public class Medico : Persona{
    protected string Especialidad;
    public Medico(string nombre, int dni, int edad, string especialidad) : base(nombre, dni, edad){
        Especialidad = especialidad;
    }
    public override void RealizarAccion(){
        Console.WriteLine("El medico esta atendiendo pacientes");
    }
}
public abstract class Institucion{
    protected string Nombre;
    protected string Direccion;
    public Institucion(string nombre, string direccion){
        Nombre = nombre;
        Direccion = direccion;
    }
    public abstract void PresentarInstitucion();
    public abstract void AñadirALaInstitucion(string nombre,int dni,int legajo);
}

public class Escuela : Institucion{
    public List<Estudiante> Estudiantes;
    public Escuela(string nombre, string direccion) : base(nombre,direccion){}
    public override void PresentarInstitucion(){}
    public override void AñadirALaInstitucion(string nombre, int dni, int edad){
        Estudiante NuevaCuenta = new Estudiante(nombre,dni,edad,1);
        Estudiantes.Add(NuevaCuenta);
    }
    //public override void AñadirALaInstitucion(){}
}

public class Hospital : Institucion{
    public List<Medico> Medicos;
    public Hospital(string nombre, string direccion) : base(nombre,direccion){}

    public override void PresentarInstitucion(){}
    public override void AñadirALaInstitucion(string nombre, int dni, int edad){
        Medico NuevaCuenta = new Medico(nombre,dni,edad,"Medico");
        Medicos.Add(NuevaCuenta);
    }
}
public class Banco : Institucion{
    public List<CuentaBancaria> CuentasBancarias;
    public Banco(string nombre, string direccion) : base(nombre,direccion){}

    public override void PresentarInstitucion(){}
    public override void AñadirALaInstitucion(string nombre, int dni, int edad){
        CuentaBancaria NuevaCuenta = new CuentaBancaria(nombre,dni,edad,0);
        CuentasBancarias.Add(NuevaCuenta);
    }
}

public class CuentaBancaria : Persona{
    private decimal saldo;
    public decimal Saldo{
        get{return saldo;}
        set{
            if(value >= 0.0m)
                saldo = value;
            else
                Console.WriteLine("El saldo debe ser positivo");
        }
    }
    public CuentaBancaria(string nombre, int dni, int edad) : base(nombre,dni,edad){
        Titular = nombre;
        saldo = 0.0m;
    }
    public CuentaBancaria(string nombre, int dni, int edad, decimal saldo) : base(nombre,dni,edad){
        Titular = nombre;
        this.saldo = saldo;
    }
    public void Depositar(decimal monto){
        if(saldo >= 0.0m)
            Saldo += monto;
    }
    public bool Retirar(decimal monto){
        bool success = false;
        if(saldo >= monto && monto >= 0.0m){
            success = true;
            saldo -= monto;
        }
        return success;
    }
    public void TransferirA(CuentaBancaria tranferirUsuario, decimal monto){
        if(Retirar(monto)){
            tranferirUsuario.Depositar(monto);
            Console.WriteLine($"Se transfirio {monto} a {tranferirUsuario.titular} desde la cuenta de {titular}");
        }
        else
            Console.WriteLine($"No se pudo resolver la transaccion, ingresar bien el monto");
    }
    public override void RealizarAccion(){
        Console.WriteLine("La cuenta esta operativa para realizar transacciones");
    }
    public void Mostrar(){
        Console.WriteLine("========================================");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine("========================================");
    }
}