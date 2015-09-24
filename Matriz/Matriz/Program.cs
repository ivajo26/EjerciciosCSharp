using System;

class MainClass
{	
	private static void Mostrar(TMatriz Mat){
		int i, j;
		Console.Clear ();
		for(i=0;i<Mat.Columnas;i++){
			for (j=0; j<Mat.Filas; j++) {
				Console.Write ("{0} ", Mat.Matriz[i,j]);
			}
			Console.WriteLine(" ");
		}
		Console.WriteLine ("Presione Cualquier Tecla ...");
		Console.ReadKey ();
	}

	private  static void PonTamano(TMatriz Mat){
		Console.Clear ();
		Console.WriteLine("Digite Numero de Filas .. ");
		Mat.Filas = uint.Parse (Console.ReadLine ());
		Console.WriteLine("Digite Numero de Columnas .. ");
		Mat.Columnas = uint.Parse (Console.ReadLine ());
	}

	private static string NombreOperacion(TMatriz Mat){
		string Nom = "";
		if (Mat is TMatriz3) {
			Nom = "Promedio";
		} else if (Mat is TMatriz2) {
			Nom = "Promedio impares de filas pares";
		} else if (Mat is TMatriz1) {
			Nom = "Suma";
		}
		return Nom;
	}

	private static void VerOperacion(TMatriz Mat){
		Console.Clear ();
		Console.WriteLine ("{0}={1}",NombreOperacion(Mat),Mat.Operacion());
	}

	private static byte Menu(){
		byte opc;
		int i;
		string []vec={"Hija 1", "Hija 2", "Hija 3", "Tamaño", "Llenar", "Mostrar", "Operacion", "Salir"};
		do{
			for(i=0;i<vec.Length;i++){
				Console.WriteLine("{0}.{1}",i+1,vec[i]);
			}
			opc=byte.Parse(Console.ReadLine());
		}while(opc<1||opc>vec.Length);
		return opc;
	}
	
	public static void Main (string[] args)
	{
		byte opc;
		TMatriz Mat = null;
		do{
			opc=Menu();
			switch(opc){
			case 1: Mat=new TMatriz1();break;
			case 2: Mat=new TMatriz2();break;
			case 3: Mat=new TMatriz3();break;
			case 4: PonTamano(Mat);break;
			case 5: Mat.Llenar();break;
			case 6: Mostrar(Mat);break;
			case 7: VerOperacion(Mat);break;
			}
		}while(opc!=8);
	}
}
