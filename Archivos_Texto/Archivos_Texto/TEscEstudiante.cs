using System;


public class TEscEstudiante:TEscritura
	{
	public TEscEstudiante():base()
	{

	}
	public override bool GuardarObj(object Obj)
	{
		TEstudiante est;
		string lin;
		if (Obj is TEstudiante) {
		
			est = (Obj as TEstudiante);
			lin = est.Cedula + "\t" + est.Apellidos + "\t" + est.Nombres + "\t" + est.Programa + "\t" + est.Semestre + "\t" + est.Promedio;
			GuardarLinea (lin);
			return true;
		} else
			return false;
	}
}
	

