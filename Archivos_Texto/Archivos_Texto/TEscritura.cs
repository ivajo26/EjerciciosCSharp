using System;
using System.IO;

public abstract class TEscritura
	{
	private string FNombre;
	protected StreamWriter Escritor;
		public TEscritura ()
		{
		FNombre = "";
		Escritor = null;
		}
	public string Nombre
	{
		set{ 
		
			FNombre = value.Trim ();
		}	
		get{ 
		
			return FNombre;
		}
	}
	public void Cerrar()
	{
		if (Escritor != null) {
		
			Escritor.Flush ();
			Escritor.Close ();
			Escritor.Dispose ();
			Escritor = null;
		}

	}
	public void Abrir(bool Agregar)
	{
		Cerrar ();
		if (Agregar) {
		
			Escritor = File.AppendText (FNombre);
		} else
			Escritor = File.CreateText (FNombre);
	}
	public void GuardarLinea(string Linea)
	{
		Escritor.WriteLine (Linea);
	}
	public abstract  bool GuardarObj (object Obj);
	}




