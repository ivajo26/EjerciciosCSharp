using System;
using System.Collections.Generic;

public class TListaNot{

	private List<TNotas>LN;

	public TListaNot ()	{
		LN = new List<TNotas> ();
	}

	public int Cantidad(){
		return LN.Count;
	}

	public void Agregar(TNotas Nt){
		LN.Add (Nt);
	}

	public void Eliminar(int pos){
		LN.RemoveAt (pos);
	}

	public void Limpliar(){
		LN.Clear ();
	}

	public TNotas getNotas(int pos){
		return LN [pos];
	}

	public void cambiar(int p1, int p2){
		TNotas tem = LN [p1];
		LN[p1]=LN[p2];
		LN [p2] = tem;
	}

	public void Ordenar(){
		int i, j;
		for (i=1; i<LN.Count; i++) {
			j = i;
			while (j>0) {
				if (LN [j - 1].Definitiva () < LN [j].Definitiva ()) {
					cambiar (j, j - 1);
					j = j - 1;
				} else {
					break;
				}
			}
		}
	}

	public double Promedio(){
		int i;
		double sum = 0;
		for (i=0; i<LN.Count; i++) {
			sum += LN [i].Definitiva ();
		}
		if (LN.Count > 0) {
			return sum / LN.Count;
		} else {
			return 0;
		}

	}

	public int Aprobadas(){
		int i, cant = 0;
		for (i=0; i<LN.Count; i++) {
			if (LN [i].Definitiva () >= 0) {
				cant = cant + 1;
			}
		}
		return cant;
	}

	public int Reprobadas(){
		return LN.Count - Aprobadas();
	}

	public float PorcenAprobadas(){
		return Aprobadas () * 100f / LN.Count;
	}

	public float PorcenReprobadas(){
		return 100 - PorcenAprobadas ();
	}
}


