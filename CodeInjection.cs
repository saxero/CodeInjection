using System;

namespace CodeInjection{
    class Program
    {
        static void Main(string[] args)
        {
            var estacion = new EstacionMeteorologica();
            Type type = System.Type.GetType("CodeInjection.Barometro");
            IMeteoReferencia dependency = (IMeteoReferencia)Activator.CreateInstance(type);
            estacion._referencia = dependency;
            
            Console.WriteLine(estacion.MostrarDatos());

        }
    }

    public class Barometro: IMeteoReferencia
    {
        public int Valor {
            get {return 400;}
            set {}
        }

        public String Mostrar(){
            return "Barometro valor: " + Valor.ToString();
        }
    }
    public class Anemometro: IMeteoReferencia
    {
        public int Valor {
            get {return 300;}
            set {}
        }

        public String Mostrar(){
            return "Anemometro valor: " + Valor.ToString();
        }
    }

    public class Termometro: IMeteoReferencia
    {
        public int Valor {
            get {return 37;}
            set {}
        }

        public String Mostrar(){
            return "Termometro valor: " + Valor.ToString();
        }
    }

    public class EstacionMeteorologica{
        public IMeteoReferencia _referencia;

        public String MostrarDatos(){
            return _referencia.Mostrar();
        }
    }
}