using System;
using DesafioPOO.Models;

namespace DesafioPOO.Models
{

    
  
    public class Iphone : Smartphone
    {
        public Iphone(int codigoPais, int codigoArea, string numeroCelular, string modelo, string imei, int memoria, string unidadeDeMedida)
           : base(codigoPais, codigoArea, numeroCelular, modelo, imei, memoria, unidadeDeMedida)
        {
            modelo = "IPhone 16 Pro Max";
        }

        public Iphone() : base(55, 28, "99945-2754", "IPhone 16 Pro Max", "987654321098765", 64, "GB")
        {
            Console.WriteLine("📱 iPhone padrão instanciado.");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> appsPermitidos = new(AppsComuns) { "Facetime" };

            if (appsPermitidos.Contains(nomeApp))
                Console.WriteLine($"Instalando {nomeApp} no iPhone.");
            else
                Console.WriteLine($"Instalação não realizada por incompatibilidade: {nomeApp}");

        }
    }
}