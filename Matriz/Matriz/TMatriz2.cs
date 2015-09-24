using System;

public class TMatriz2:TMatriz{

	public TMatriz2 (): base (){
	}

	public override float Operacion(){
		int i, j, cant=0;
		float Suma = 0;
		for (i=0; i<Filas; i++) {
			if(i%2==0){
				for(j=0;j<Columnas;j++){
					if(Matriz[i,j]%2!=0){
						cant++;
						Suma += Matriz [i, j];
					}
				}
			}
		}
		if(cant>0){
			return Suma/cant;
		}else{
			return 0;
		}
	}
}


