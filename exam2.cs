using System.Text.RegularExpressions;

namespace test;

class Program{
    public abstract class Persona{
        private string nombre;
        private int dni;
        private int edad;
        public string Nombre{
            get{return nombre;}
            set{
                if(value == "") throw new StringVacioException("El nombre no puede estar vacio");
                char[] simbolos = {'!','"','#','%','&','/','(',')','='};
                if(value.IndexOfAny(simbolos) != -1) throw new SimbolosInvalidosException("Simbolos invalidos");
                nombre = value;
            }
        }
        public int DNI{
            get{return dni;}
            set{
                if(dni < 0 || dni > 99999999) throw new DniInvalidoException("DNI invalido"); 
                dni = value;
            }
        }
        public int Edad{
            get{return edad;}
            set{dni = value;}
        }
        public Persona(string nombre, int dni, int edad){
            Nombre = nombre;
            DNI = dni;
            Edad = edad;
        }
        public abstract void RealizarAccion();
    }
    public class Estudiante : Persona{
        private int legajo;
        public int Legajo{
            get{return legajo;}
            set{legajo = value;}
        }
        public Estudiante(string nombre, int dni, int edad, int legajo) : base(nombre,dni,edad){
            Legajo = legajo;
        }
        public override void RealizarAccion(){
            Console.WriteLine("El estudiante esta estudiando");
        }
    }
    public class Medico : Persona{
        private string especialidad;
        public string Especialidad{
            get{return especialidad;}
            set{
                if(value == "") throw new StringVacioException("La especialidad esta vacia");
                especialidad = value;
            }   
        }
        public Medico(string nombre, int dni, int edad, string especialidad) : base(nombre,dni,edad){
            Especialidad = especialidad;
        }
        public override void RealizarAccion(){
            Console.WriteLine("El medico esta atendiendo pacientes");
        }
    }
    public class ClienteBanco : Persona{
        public ClienteBanco(string nombre, int dni, int edad) : base(nombre,dni,edad){}
        public override void RealizarAccion(){
            Console.WriteLine("El cliente esta haciendo tramites");
        }
    }
    public abstract class Institucion{
        private string nombre;
        private string direccion;
        
    }
    class CuentaBancaria{
        private string titular;
        private decimal saldo;
        public string Titular{
            get{return titular;}
            set{
                if(value == "") throw new StringVacioException("Titular vacio");
                char[] simbolos = {'!','"','#','%','&','/','(',')','='};
                if(value.IndexOfAny(simbolos) != -1) throw new SimbolosInvalidosException("Simbolos invalidos");
                titular = value;
            }
        }
        public decimal Saldo{
            get{return saldo;}
            set{
                if(value < 0) throw new NumMenorALoPermitidoException("Saldo menor o igual a cero");
                saldo = value;
            }
        }
        public void Depositar(decimal monto){
            if(monto < 0) throw new NumMenorALoPermitidoException("Saldo menor o igual a cero");
            Saldo += monto;
        }
        public void Retirar(decimal monto){
            if(monto > saldo) throw new SaldoInsuficienteException("Saldo insuficiente");
            else if(monto < 0) throw new NumMenorALoPermitidoException("Saldo menor o igual a cero");
            Saldo -= monto;
        }
        public void TransferirA(CuentaBancaria cuenta,decimal monto){
            Retirar(monto);
            cuenta.Depositar(monto);
        }
    }

    public abstract class ExamenException : Exception{
        private int ErrorCode;
        public ExamenException(string mensaje, int errorcode) : base(mensaje){
            ErrorCode = errorcode;
        }
    }
    public class DniInvalidoException : ExamenException{
        public DniInvalidoException(string mensaje) : base(mensaje,104){}
    }
    public class StringVacioException : ExamenException{
        public StringVacioException(string mensaje) : base(mensaje,103){}
    }
    public class SaldoInsuficienteException : ExamenException{
        public SaldoInsuficienteException(string mensaje) : base(mensaje,102){}
    }
    public class NumMenorALoPermitidoException : ExamenException{
        public NumMenorALoPermitidoException(string mensaje) : base(mensaje,101){}
    }
    public class SimbolosInvalidosException : ExamenException{
        public SimbolosInvalidosException(string mensaje) : base(mensaje,100){}
    }
    public static void Main(){
    }
}