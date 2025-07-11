using System.Reflection.PortableExecutable;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Dados de instalação por celular
        Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.DarkCyan;
        CenteredWrite($"Data: {DateTime.Now:dd/MM/yyyy} - Hora: {DateTime.Now:HH:mm:ss}");
        Console.ResetColor();
        Dictionary<string, List<string>> modeloApps = new()
        {
            { "Nokia", new() { "WhatsApp", "Telegram", "Nokia 1280 Launcher", "Facetime" } },
            { "iPhone", new() { "WhatsApp", "Telegram", "Facetime", "Nokia 1280 Launcher" } }
        };

        Dictionary<string, List<string>> modeloPermitidos = new()
        {
            { "Nokia", new() { "WhatsApp", "Telegram", "Nokia 1280 Launcher" } },
            { "iPhone", new() { "WhatsApp", "Telegram", "Facetime" } }
        };

        // Instalação por modelo
        foreach (var modelo in modeloApps.Keys)
        {
            List<string> instalados = new();
            List<string> rejeitados = new();

            Console.WriteLine($"\nIniciando instalação de aplicativos no {modelo}...\n");

            foreach (string app in modeloApps[modelo])
            {
                Console.Write($"- Instalando {app}...");
                Thread.Sleep(1500); // 
                Console.WriteLine(" concluído.");

                if (modeloPermitidos[modelo].Contains(app))
                    instalados.Add(app);
                else
                    rejeitados.Add(app);
            }

            Console.WriteLine("\nFinalizando...\n");
            Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Instalação realizada {modelo}: {string.Join(", ", instalados)}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Incompatibilidade encontrada. Não instalado: {modelo}: {string.Join(", ", rejeitados)}");

            Console.ResetColor();
        }

        static void TelaFinal()
        {
            Console.Clear();

            // Exibe data e hora centralizada
            string dataHora = $"{DateTime.Now:dd/MM/yyyy} - {DateTime.Now:HH:mm:ss}";
            CenteredWrite(dataHora);

            Console.WriteLine();

            // iPhone
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenteredWrite("IPHONE 16 PRO MAX");
            Console.ResetColor();

            Console.WriteLine("Whatsapp e Telegram instalados.");
            Console.WriteLine("App Nokia 1280 Launcher rejeitado.");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ResetColor();

            // Nokia
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenteredWrite("NOKIA G400 5G");
            Console.ResetColor();

            Console.WriteLine("Whatsapp e Telegram instalados.");
            Console.WriteLine("App Facetime rejeitado.");

            // Respiro e assinatura
            Console.WriteLine("\n\n");
            string assinatura = "Desenvolvido por Sol Morcillo 💛";

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char letra in assinatura)
            {
                Console.Write(letra);
                Thread.Sleep(100);
            }
            Console.ResetColor();

            Console.WriteLine("\n\n");
        }

        static void CenteredWrite(string text)
        {
            int espaço = (Console.WindowWidth - text.Length) / 2;
            Console.WriteLine(new string(' ', espaço) + text);
        }

        // Após o loop de instalação por modelo
        Console.ResetColor();
        TelaFinal();



       
    }


}
