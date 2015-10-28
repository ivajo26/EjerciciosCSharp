using System;

public class TNotas{

	private float FNota1;
	private float FNota2;
	private float FNota3;
	private string FAsignatura;

	public TNotas (){
		FNota1 = 0;
		FNota3 = 0;
		FNota3 = 0;
		FAsignatura = "";
	}

	protected bool valida(float Nt){
		return Nt >= 0 && Nt <= 5;
	}

	public float Nota1{
		set{
			if (valida (value)) {
				FNota1 = value;
			}
		}
		get{
			return FNota1;
		}
	}

	public float Nota2{
		set{
			if (valida (value)) {
				FNota2 = value;
			}
		}
		get{
			return FNota2;
		}
	}

	public float Nota3{
		set{
			if (valida (value)) {
				FNota3 = value;
			}
		}
		get{
			return FNota3;
		}
	}
	public string Asignatura{
		set{
			FAsignatura = value;
		}
		get{
			return FAsignatura;
		}
	}

	public double Definitiva(){
		return (FNota1 + FNota2 + FNota3) / 3;
	}
}


