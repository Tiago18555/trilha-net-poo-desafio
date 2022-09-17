namespace DesafioPOO.Models
{
	// TODO: Herdar da classe "Smartphone"
	public class Iphone : Smartphone
	{
        protected Iphone(string modelo, string numero, int memoria, string IMEI) : base(numero, modelo, IMEI, memoria)
		{

		}
		// TODO: Sobrescrever o método "InstalarAplicativo"
		public override void InstalarAplicativo(string nomeApp) =>		
			System.Console.WriteLine($"Iphone > Instalando aplicativo {nomeApp}");		
	}
}