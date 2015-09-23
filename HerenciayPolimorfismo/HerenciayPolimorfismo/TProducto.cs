using System;

public class TProducto : TNumeros{

	public TProducto() : base (){
		Console.WriteLine("Soy el hijo producto ... ");
	}

	public override double Operacion(){
		return Num1 * Num2;
	}

	public override void Mostrar(){
		Console.Write (Num1 + " * " + Num2);
		base.Mostrar ();
	}
}


