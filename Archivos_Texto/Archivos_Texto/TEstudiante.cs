using System;


	public class TEstudiante
	{
	private long FCedula;
	private string FApellidos;
	private string FNombres;
	private string FPrograma;
	private byte FSemestre;
	private float FPromedio;
		public TEstudiante ()
		{
		FCedula = 0;
		FApellidos = "";
		FNombres = "";
		FPrograma = "";
		FSemestre = 0;
		FPromedio = 0;
		}
	public long Cedula
	{
		set{
			FCedula = value;
		}
		get{
			return FCedula;
		}
	}
	public string Apellidos
	{
		set{
			FApellidos = value.Trim ();
		}
		get{
			return FApellidos;
		}
	}
	public string Nombres
	{
		set{
			FNombres = value.Trim ();
		}
		get{
			return FNombres;
		}
	}
	public string Programa
	{
	    set{ 
			FPrograma = value.Trim ();
		}
		get{
			return FPrograma;
		}

	}
	public byte Semestre
	{
		set{
			FSemestre = value;
		}
		get{ 
			return FSemestre;
		}

	}
	public float Promedio
	{
		set{
			FPromedio = value;
		}
		get{
			return FPromedio;
		}
	}

}



