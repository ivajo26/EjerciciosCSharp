using System;

namespace Delegados2
{
	class MainClass
	{
		private static void VerTodo(int pos, int val){
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine ("Vec[{0}]={1}", pos, val);
		}
		private static void VerPares(int pos, int val){
			if (val % 2 == 0) {
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Vec[{0}]={1}",pos,val);
			}
		}
		private static void VerNegativos(int pos, int val){
			if(val<0){
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine("Vec[{0}]={1}",pos,val);
			}
		}
		private static void VerImpares(int pos, int val){
			if (pos % 2 == 0 && val % 2 != 0) {
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Vec[{0}]={1}",pos,val);
			}
		}
		private static byte Menu(){
			int i;
			byte opc;
			string[] vec = {
				"Tamaño",
				"Llenar Positivos",
				"Llenar Negativos",
				"Ver Todo",
				"Ver Pares",
				"Ver Negativos",
				"Ver Impares",
				"Salir"
			};
			do{
				Console.ForegroundColor=ConsoleColor.White;
				Console.Clear();
				for(i=0;i<vec.Length;i++){
					Console.WriteLine("{0}) {1}",i+1,vec[i]);
				}
				opc=byte.Parse(Console.ReadLine());
			}while(opc<1 || opc>vec.Length);
			return opc;
		}
		private static void Mostrar(TArreglo V, DMostrar M){
			Console.Clear(); 
			V.OnMostrar = M;
			V.Mostrar ();
			Console.ReadKey();
		}
		public static void Main (string[] args)
		{
			byte opc;
			TArreglo A = new TArreglo ();
			do {
				opc = Menu ();
				switch (opc) {
				case 1:
					Console.Clear ();
					Console.WriteLine ("Tamaño: ");
					A.Tam = uint.Parse (Console.ReadLine ());
					break;
				case 2:
					A.LlenarPos ();
					break;
				case 3:
					A.LlenarNeg ();
					break;
				case 4:
					Mostrar (A, VerTodo);
					break;
				case 5:
					Mostrar (A, VerPares);
					break;
				case 6:
					Mostrar (A, VerNegativos);
					break;
				case 7:
					Mostrar (A, VerImpares);
					break;
				}
			} while(opc!=8);
		}
	}
}
