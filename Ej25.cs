//Crear una interface que tenga informacion de una cuenta bancaria, Numero de Cuenta, Saldo y sus metodos de retiro, deposito y transferencia, donde la transferencia es otro usuario, luego crear la Interface de Persona, que tenga su Nombre, Apellido, DNI, y Edad un metodo que permita Saludar y Otro que permita CumplirAños, que al ejecturalo suma 1 a la edad, al tener las 2 interfaces crear una clase UsuarioBanco heredando las 2 interfaces, y agregarle la propiedad Banco, que debe tener el nombre del banco.

namespace test;
public interface ICuentaBancaria{
    public int NumeroDeCuenta{get; set;}
    public int Saldo{get; set;}
    public bool Retirar();
    public bool Depositar();
    public bool Transferencia();
}
public interface IPersona{
    public string Nombre{get; set;}
    public string Apellido{get; set;}
    public int Dni{get; set;}
    public byte Edad{get; set;}
    public void Saludar();
    public void CumplirAños();
}
public class UsuarioBanco : ICuentaBancaria,IPersona{
    private int numeroDeCuenta;
    private int saldo;
    private string nombre;
    private string apellido;
    private int dni;
    private byte edad;
    public int NumeroDeCuenta{
        get{return numeroDeCuenta;}
        set{numeroDeCuenta = value;}
    }
    public int Saldo{
        get{return saldo;}
        set{saldo = value;}
    }
    public string Nombre{
        get{return nombre;}
        set{nombre = value;}
    }
    public string Apellido{
        get{return apellido;}
        set{apellido = value;}
    }
    public int Dni{
        get{return dni;}
        set{dni = value;}
    }
    public byte Edad{
        get{return edad;}
        set{edad = value;}
    }
    public void Saludar(){
        Console.WriteLine("Hola");
    }
    public void CumplirAños(){
        edad++;
    }
    public bool Retirar(int cantidad){
        if(cantidad > saldo) throw new SaldoInsuficienteException("ERROR_SALDO","Saldo")
    }
    public bool Depositar(){}
    public bool Transferencia(){}
}
public class SaldoInsuficienteException : Exception{
    public string ErrorCode;
    public SaldoInsuficienteException(string ErrorCode, string Message) : base(Message){
         this.ErrorCode = ErrorCode;
    }
}
class Program{
    public static void Main(){}
}