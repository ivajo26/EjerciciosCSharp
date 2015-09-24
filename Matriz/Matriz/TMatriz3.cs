using System;

public class TMatriz3:TMatriz1{

	public TMatriz3 (){
	}

	public override void Llenar(){
		int i, j;
		Random R = new Random ();
		for (i=0; i<Filas; i++) {
			for(j=0;j<Columnas;j++){
				Matriz [i, j] = R.Next (2000) - R.Next (1000);
			}
		}
	}

	public override float Operacion(){
		return base.Operacion() / (Filas * Columnas);
	}
}


