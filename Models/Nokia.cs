namespace DesafioPOO.Models
{
	public class Nokia : Smartphone
	{

        protected Nokia(string modelo, string numero, int memoria, string IMEI) : base(numero, modelo, IMEI, memoria)
		{

		}

		public override void InstalarAplicativo(string nomeApp) =>
			System.Console.WriteLine($"Nokia > Instalando aplicativo {nomeApp}");
	}
}