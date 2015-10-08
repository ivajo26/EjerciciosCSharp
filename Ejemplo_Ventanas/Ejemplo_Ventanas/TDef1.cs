using System;

public class TDef1:TNotas{

	public TDef1 ():base(){
	}

	public override double Definitiva(){
		return (0.3 * Nota1) + (0.3 * Nota2) + (0.4 * Nota1);
	}
}


