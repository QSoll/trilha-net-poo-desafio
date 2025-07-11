using System;
using System.Reflection.PortableExecutable;
using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public int CodigoPais { get; set; }
        public int CodigoArea { get; set; }
        public string NumeroCelular { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; private set; }

        public int Memoria { get; set; }
        public string UnidadeDeMedida { get; set; }

        public Smartphone(int codigoPais, int codigoArea, string numeroCelular, string modelo, string imei, int memoria, string unidadeDeMedida)
        {
            CodigoPais = codigoPais;
            CodigoArea = codigoArea;
            NumeroCelular = numeroCelular;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            UnidadeDeMedida = unidadeDeMedida;

            // Parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public string ObterNumeroFormatado()
        {
            return $"+{CodigoPais} ({CodigoArea}) {NumeroCelular}";
        }

        protected List<string> AppsComuns => new() { "WhatsApp", "Telegram" };



    }
}