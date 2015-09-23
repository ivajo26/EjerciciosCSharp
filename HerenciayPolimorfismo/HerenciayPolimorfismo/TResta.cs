using System;

public class TResta : TNumeros{

	public TResta() : base (){
		Console.WriteLine("Soy el hijo resta ... ");
	}

	public override double Operacion(){
		return Num1 - Num2;
	}

	public override void Mostrar(){
		Console.Write (Num1 + " - " + Num2);
		base.Mostrar ();
	}
}


