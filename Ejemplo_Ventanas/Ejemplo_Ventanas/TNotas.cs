using System;

public class TNotas{

	private float FNota1;
	private float FNota2;
	private float FNota3;

	public TNotas (){
		FNota1 = 0;
		FNota2 = 0;
		FNota3 = 0;
	}

	public bool ValidarNota(float Nt){
		if (Nt >= 0 && Nt <= 5) {
			return true;
		} else {
			return false;
		}
	}

	public float Nota1{
		set{
			if (ValidarNota (value)) {
				FNota1 = value;
			}
		}
		get{
			return FNota1;
		}
	}

	public float Nota2{
		set{
			if (ValidarNota (value)) {
				FNota2 = value;
			}
		}
		get{
			return FNota2;
		}
	}

	public float Nota3{
		set{
			if (ValidarNota (value)) {
				FNota3 = value;
			}
		}
		get{
			return FNota3;
		}
	}

	public virtual double Definitiva(){
		return (FNota1 + FNota2 + FNota3) / 3;
	}
}


