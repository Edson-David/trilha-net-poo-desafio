namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        protected int Memoria;
        protected string IMEI;
        protected string Modelo;
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // DONE: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string aplicativo);
    }
}