//Herencia Multiple de INTERFACES , crear 2 interfaces una que simule unos parlantes, con el volumen y si esta encendido o no, y otra como monitor que tenga la propiedad brillo y la propiedad si esta encendido, una vez tenemos las interfaces, debemos crear la clase computadora que herede de esas interfaces sus propiedades y tenga sus propias propiedades, la PC debe tener un metodo encender, que debera detectar si el sistema operativo Windows 11 fallo o no fallo, en caso de que falle tirar un error con una excepcion personalizada (Pueden usar el Random Next para simular si existe un error o no, dentro del metodo encender de la PC)

namespace test;
class Program{
    public interface IParlante1{
        public bool Encendido{get; set;}
        public byte Volumen{get; set;}
        public void Encender();
    }
    public interface IParlante2{
        public bool Encendido{get; set;}
        public byte Brillo{get; set;}
    }
    public class Computadora : IParlante1,IParlante2{
        public bool Encendido = false;
        public void Encender(){
            bool random = new Random().Next(2) == 1;
            if(random) Console.WriteLine("Iniciado correctamente");
            else throw new SistemaOperativoException("ERROR_WINDOWS","No se pudo cargar el sistema operativo");
        }
    }
    public class SistemaOperativoException : Exception{
        public string ErrorCode;
        public SistemaOperativoException(string ErrorCode, string Message) : base(Message){
            this.ErrorCode = ErrorCode;
        }
        
    }
    public static void Main(){
        Computadora pc = new Computadora();
        pc.Encender();
    }
}