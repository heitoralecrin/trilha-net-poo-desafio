namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo '{nomeApp}' está sendo instalado no Iphone.");
        }
    }
}