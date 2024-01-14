namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria {get; set;}

        public Smartphone(string novoNumero, string novoModelo, string novoImei, int NovaMemoria)
        {
            Numero = novoNumero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = novoModelo;
            IMEI = novoImei;
            Memoria = NovaMemoria;
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