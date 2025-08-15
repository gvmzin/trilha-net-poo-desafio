namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado as propriedades faltantes de acordo com o diagrama
        private string IMEI { get; set; }
        private string Modelo { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, int memoria, string imei)
        {
            Numero = numero;
            // Passado os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Memoria = memoria;
            IMEI = imei;
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
    }
}