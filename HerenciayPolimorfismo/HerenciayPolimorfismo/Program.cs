using System;

class MainClass
{
	public static void Ejecutar(TNumeros N){
		Console.WriteLine ("Digite el primer numero");
		N.Num1 = int.Parse (Console.ReadLine());
		Console.WriteLine ("Digite el segundo numero");
		N.Num2 = int.Parse (Console.ReadLine());
		N.Mostrar ();
	}
	public static void Main (string[] args)
	{
		Ejecutar (new TSuma());
		Ejecutar (new TResta());
		Ejecutar (new TProducto());
		Ejecutar (new TCociente());
	}
}

