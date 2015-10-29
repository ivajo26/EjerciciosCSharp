using System;
using System.Diagnostics;
public class TProceso{

	private string FNombre;
	private string FParametros;

	public TProceso (){
		FNombre = "";
		FParametros = "";
	}

	public string Nombre{
		set{
			FNombre = value.Trim ();
		}
		get{
			return FNombre;
		}
	}

	public string Parametros{
		set{
			FParametros = value.Trim ();
		}
		get{
			return FParametros;
		}
	}

	public string Ejecutar(bool Redireccionar){
		string Res;
		Process Pro;
		Res = "";
		Pro = new Process ();
		Pro.StartInfo.FileName = FNombre;
		Pro.StartInfo.Arguments = FParametros;
		if (Redireccionar) {
			Pro.StartInfo.RedirectStandardInput = true;
			Pro.StartInfo.RedirectStandardOutput = true;
			Pro.StartInfo.UseShellExecute = false;
			Pro.StartInfo.CreateNoWindow = true;
		}
		Pro.Start ();
		if (Redireccionar) {
			Pro.WaitForExit ();
			Res = Pro.StandardOutput.ReadToEnd ();
		}
		Pro.Close ();
		Pro.Dispose ();
		return Res;
	}

}
