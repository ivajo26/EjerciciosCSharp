using System;

public abstract class TNumeros{

	private int FNum1;
	private int FNum2;

	public TNumeros (){
		FNum1 = 0;
		FNum2 = 0;
		Console.WriteLine("Soy el OBjeto Padre..");
	}

	public int Num1{
		set{
			FNum1 = value;
		}
		get{
			return FNum1;
		}
	}

	public int Num2{
		set{
			FNum2 = value;
		}
		get{
			return FNum2;
		}
	}

	public abstract double Operacion();

	public virtual void Mostrar(){
		Console.WriteLine ("=" + Operacion ());
	}
}


