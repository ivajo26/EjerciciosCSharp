using System;

public class TMatriz1: TMatriz{

	public TMatriz1() : base(){
	}

	public override void Llenar(){
		int i, j;
		base.Llenar ();
		for (i=0; i<Filas; i++) {
			for(j=0;j<Columnas;j++){
				Matriz [i, j] = -Matriz [i, j];
			}
		}
	}

	public override float Operacion(){
		int i, j;
		float Suma = 0;
		for (i=0; i<Filas; i++) {
			for(j=0;j<Columnas;j++){
				Suma += Matriz [i, j];
			}
		}
		return Suma;
	}
}
