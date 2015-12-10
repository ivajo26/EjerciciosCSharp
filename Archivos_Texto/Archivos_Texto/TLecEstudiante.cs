using System;


public class TLecEstudiante:TLectura
	{
	public TLecEstudiante():base()
	{
		
	}
	public override bool LeerObj(object Obj)
	{
		string lin;
		string[] Vec;
		TEstudiante Est;
		bool res = false;
		if (Obj is TEstudiante) {
		
			lin = LeerLinea ();
			if (lin != null) {
			
				Vec = lin.Split ('\t');
				if (Vec.Length == 6) {
				
					Est = (TEstudiante)Obj;
					Est.Cedula = long.Parse (Vec [0]);
					Est.Apellidos = Vec [1];
					Est.Nombres = Vec [2];
					Est.Programa = Vec [3];
					Est.Semestre = byte.Parse (Vec [4]);
					Est.Promedio = float.Parse (Vec [5]);
					res = true;
				}
			}
		}
		return res;
	}

}


