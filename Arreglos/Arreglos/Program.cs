using System;

class MainClass
{
	private static void Mostrar(int []V){
		int i;
		Console.Clear();
		for(i=0;i<V.Length;i++){
			Console.WriteLine("V[{0}]={1}",i,V[i]);
		}
		Console.ReadKey();
	}

	private static void Mostrar(string MS, float val){
		Console.Clear();
		Console.WriteLine("{0}:{1}", MS, val);
		Console.WriteLine("Pulse una Tecla...");
		Console.ReadKey ();
	}

	private static byte Menu(){
		int i;
		byte res;
		string[] opciones = { "Tamaño", "Llenar", "Mostar", "Mayor", "Menor", "Suma", "Promedio","Salir" };
		do {
			Console.Clear();
			for(i=0;i<opciones.Length;i++){
				Console.WriteLine("{0}.{1}",i+1,opciones[i]);
			}
			res=byte.Parse(Console.ReadLine());
		} while(res < 1 || res > opciones.Length);
		return res;
	}
	public static void Main (string[] args)
	{
		byte opc;
		TVector Vec = new TVector ();
		do {
			opc = Menu ();
			switch (opc) {
			case 1:
				Console.Clear ();
				Console.WriteLine ("Digite Tamaño: ");
				Vec.Tam = uint.Parse (Console.ReadLine ());
				break;
			case 2:
				Vec.Llenar ();
				break;
			case 3:
				Mostrar (Vec.Vec);
				break;				
			case 4:
				Mostrar ("Mayor", Vec.Mayor());
				break;
			case 5:
				Mostrar ("Menor", Vec.Menor());
				break;
			case 6:
				Mostrar ("Suma", Vec.Suma());
				break;
			case 7:
				Mostrar ("Promedio", Vec.Promedio());
				break;
			}
		} while(opc != 8);
	}
}

