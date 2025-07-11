using System;
using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(int codigoPais, int codigoArea, string numeroCelular, string modelo, string imei, int memoria, string unidadeDeMedida)
            : base(codigoPais, codigoArea, numeroCelular, modelo, imei, memoria, unidadeDeMedida)
        {
            modelo = "Nokia X30 5G";
        }

        public Nokia() : base(55, 22, "99945-2754", "Nokia X30 5G", "012345678912345", 64, "GB")
        {
            InstalarAplicativo("Nokia 1280 Launcher");

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> appsPermitidos = new(AppsComuns) { "Nokia 1280 Launcher" };

            if (appsPermitidos.Contains(nomeApp))
                Console.WriteLine($"Instalando {nomeApp} no Nokia.");
            else
                Console.WriteLine($"Instalação não realizada por incompatibilidade: {nomeApp}");

        }





    }
}