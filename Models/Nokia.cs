using System.ComponentModel;

namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo}...");
        }
    }
}