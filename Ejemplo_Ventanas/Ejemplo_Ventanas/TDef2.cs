using System;

public class TDef2:TNotas{

	public TDef2 ():base(){
	}

	public override double Definitiva(){
		return (0.35 * Nota1) + (0.35 * Nota2) + (0.3 * Nota1);
	}
}


