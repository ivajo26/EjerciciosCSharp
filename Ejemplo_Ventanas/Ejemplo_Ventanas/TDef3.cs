using System;

public class TDef3:TNotas{

	public TDef3 ():base(){
	}

	public override double Definitiva(){
		return (0.25 * Nota1) + (0.35 * Nota2) + (0.45 * Nota1);
	}
}


