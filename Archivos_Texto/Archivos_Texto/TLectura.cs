using System;
using System.IO;

public abstract class TLectura
	{
	private string FNombre;
	private  StreamReader Lector;
		public TLectura ()
		{
		FNombre = "";
		Lector = null;
		}
	public string Nombre
	{
		set{ 
		
			FNombre = value;
		}
		get{ 
		
			return FNombre;
		}
	}
	public void Cerrar()
	{
		if (Lector != null) {
		
			Lector.Close ();
			Lector.Dispose ();
			Lector = null;
		}
	
	}
	public void Abrir()
	{
		Cerrar ();
		Lector = File.OpenText (FNombre);
	}
	public bool EsFinal()
	{
		return Lector.EndOfStream;
	}
	public string LeerLinea()
	{
		return Lector.ReadLine ();
	}
	public abstract bool LeerObj (object Obj);
	}


