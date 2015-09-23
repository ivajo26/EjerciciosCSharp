using System;

public class TSuma : TNumeros{

	public TSuma() : base (){
		Console.WriteLine("Soy el hijo suma ... ");
	}

	public override double Operacion(){
		return Num1 + Num2;
	}

	public override void Mostrar(){
		Console.Write (Num1 + " + " + Num2);
		base.Mostrar ();
	}
}


