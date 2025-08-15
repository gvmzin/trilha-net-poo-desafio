namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria, string imei) : base(numero, modelo, memoria, imei)
        {
        }

        // Sobrescrito o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");;
        }
    }
}