using System;

namespace Parametros{
	class MainClass	{
		private static void PorValor(int a){
			a = a + 5;
		}
		private static void PorReferencia(ref int a){
			a = a + 2;
		}
		private static void DeSalida(int p, out int a){
			if (p > 0) {
				a = p + 10;
			} else {
				a = p - 3;
			}
		}
		private static long Suma(params int []nums){
			int i;
			long res = 0;
			for(i=0;i < nums.Length;i++){
				res = res + nums[i];
			}
			return res;
		}
		private static void Cambiar<t>(ref t a, ref t b){
			t aux;
			aux = a;
			a = b;
			b = aux;
		}
		public static void Main (string[] args)
		{
			int a, b;
			string x, y;
			a = 3;
			x = "hola";
			y = "mundo";
			Console.Clear();
			PorValor(a); //a entra con 3
			Console.WriteLine("a={0}",a); //muestra a = 3
			PorValor(10);// llamado con constate
			PorValor(a+3);//llamado con expresion
			PorReferencia(ref a); // a entra con 3
			Console.WriteLine("a={0}",a); // nuestra a = 5
			DeSalida(2,out b); // b no esta inicializado
			Console.WriteLine("b={0}", b);//muestra b = 12 
			DeSalida(10,out a); // a entra con 5
			Console.WriteLine("a={0}",a); // nuestra a = 10
			Console.WriteLine("Suma={0}",Suma());//Muestra 0
			Console.WriteLine("Suma={0}",Suma(3,4));//Muestra 7
			Console.WriteLine("Suma={0}",Suma(1,5,6,7));//Muestra 19
			Console.WriteLine("Suma={0}",Suma(a,b));//Muestra 22
			a = 7;
			b = 5;
			Cambiar(ref a, ref b);
			Console.WriteLine("a={0},b={1}", a, b);//muestra a = 5 y b = 7 
			Cambiar(ref x, ref y);
			Console.WriteLine("x={0},y={1}", x, y);//muestra x = mundo y y = hola
			Cambiar<int>(ref a, ref b);
			Console.ReadKey();
		} 	

	}
}
