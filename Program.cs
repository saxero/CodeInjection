using System;

namespace ci
{
    class Program
    {
        static void Main2(string[] args)
        {
            var estacion = new EstacionMeteorologica(new Anemometro());
            Console.WriteLine(estacion.MostrarDatos());

            var estacion2 = new EstacionMeteorologica(new Termometro());
            Console.WriteLine(estacion2.MostrarDatos());
        }
    }

    
    public interface IMeteoReferencia
    {
        int Valor {get; set;}
        String Mostrar();
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
        private IMeteoReferencia _referencia;

        public EstacionMeteorologica(IMeteoReferencia referencia){
            _referencia = referencia;
        }

        public String MostrarDatos(){
            return _referencia.Mostrar();
        }
    }
}
