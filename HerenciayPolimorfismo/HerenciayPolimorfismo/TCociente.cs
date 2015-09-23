using System;

public class TCociente : TNumeros{

	public TCociente() : base (){
		Console.WriteLine("Soy el hijo cociente ... ");
	}

	public override double Operacion(){
		return Num1 / Num2;
	}

	public override void Mostrar(){
		Console.Write (Num1 + " / " + Num2);
		base.Mostrar ();
	}
}


