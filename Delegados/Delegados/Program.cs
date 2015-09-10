using System;

public delegate void DOperacion(float x, float y);
class MainClass
{
	private static void Suma(float x, float y){
		Console.WriteLine("Suma={0}",x+y);
	}
	private static void Resta(float a, float b){
		Console.WriteLine("Resta={0}",a-b);
	}
	private static void Producto(float p, float q){
		Console.WriteLine("Producto={0}",p*q);
	}
	public static void Cociente(float x, float y){
		Console.WriteLine("Cociente={0}",x/y);
	}
	public static void Main (string[] args)
	{
		float a,b;
		DOperacion opr=null;
		Console.Clear();
		Console.WriteLine("Digite el valor de a: ");
		a=float.Parse(Console.ReadLine());
		Console.WriteLine("Digite el valor de b: ");
		b=float.Parse(Console.ReadLine());
		Console.Clear ();
		Suma(a,b);
		opr=Suma;
		opr(a,b);
		Console.WriteLine("Aritmetica de Punteros");
		opr+=Resta;
		opr+=Producto;
		opr+=Cociente;
		opr(a,b);
		Console.WriteLine("Ejecutamos sin resta");
		opr-=Resta;
		opr(a,b);
		opr=Producto;
		Console.WriteLine("Producto");
		opr(a,b+5);
	}
}

