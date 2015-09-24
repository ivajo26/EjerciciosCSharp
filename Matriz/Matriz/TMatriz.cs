using System;

public abstract class TMatriz{
	private uint FFilas;
	private uint FColumnas;
	private int [,]FMatriz;

	public TMatriz (){
		FFilas = 0;
		FColumnas = 0;
		FMatriz = null;
	}

	protected void CrearMatriz(){
		if (FFilas > 0 && FColumnas > 0) {
			FMatriz = new int[FFilas, FColumnas];
		} else {
			FMatriz = null;
		}
	}

	public uint Filas{
		set{
			FFilas = value;
			CrearMatriz ();
		}
		get{
			return FFilas;
		}
	}

	public uint Columnas{
		set{
			FColumnas = value;
			CrearMatriz ();
		}
		get{
			return FColumnas;
		}
	}

	public int [,]Matriz{
		get{
			return FMatriz;
		}
	}

	public virtual void Llenar(){
		int i, j;
		Random R = new Random ();
		for (i=0; i<FFilas; i++) {
			for(j=0;j<FColumnas;j++){
				FMatriz [i, j] = R.Next (900) + 100;
			}
		}
	}

	public abstract float Operacion();
}

