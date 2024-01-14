namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string novoNumero, string novoModelo, string novoImei, int NovaMemoria)
        : base(novoNumero, novoModelo, novoImei, NovaMemoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o APP {nomeApp} no meu nokia...");
        }
    }
}