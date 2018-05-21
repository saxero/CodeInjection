using System;

namespace CodeInjection{
    /// <summary>
    /// Main class - starting point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var estacion = new EstacionMeteorologica();
            
            Type type = System.Type.GetType("CodeInjection.Barometro");
            IMeteoReferencia dependency = Activator.CreateInstance(type);
            estacion.referencia = dependency;
            
            Console.WriteLine(estacion.MostrarDatos());

        }
    }

    /// <summary>
    /// Barometro class. Implements IMetroReferencia <see langword="interface"/>
    /// </summary>
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


    /// <summary>
    /// Anemometro class. Implements IMetroReferencia <see langword="interface"/>
    /// </summary>
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

    /// <summary>
    /// Termometro class. Implements IMetroReferencia <see langword="interface"/>
    /// </summary>
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

    /// <summary>
    /// Class EstacionMeteorologica allows dependency injection of IMeteoReferencia dependency by setter.
    /// </summary>
    public class EstacionMeteorologica{
        public IMeteoReferencia referencia;

        public String MostrarDatos(){
            return referencia.Mostrar();
        }
    }
}