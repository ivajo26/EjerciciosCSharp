using System;
using Gtk;

public partial class MainWindow: Gtk.Window{	

	private ListStore Mod;
	private TListaNot Ln;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Ln=new TListaNot();
		CrearColumnas();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	private void CrearColumnas(){
		int i;
		string []Vec={"Asignatura","Nota1","Nota2","Nota3","Definitiva"};
		Mod = new ListStore (typeof(string), typeof(float), typeof(float), typeof(float), typeof(double));
		for (i=0; i<Vec.Length; i++) {
			Tw.AppendColumn (new TreeViewColumn (Vec [i], new CellRendererText (), "text", i));
			Tw.Columns [i].Resizable = true;
		}
		Tw.Model = Mod;
	}

	private void Agregar(TNotas Nt){

		Mod.AppendValues (Nt.Asignatura,Nt.Nota1,Nt.Nota2,Nt.Nota3,Nt.Definitiva());
	}

	private void Llenar(TNotas Nt){
		Nt.Asignatura = E1.Text;
		Nt.Nota1 = float.Parse (E2.Text);
		Nt.Nota2 = float.Parse (E3.Text);
		Nt.Nota3 = float.Parse (E4.Text);
	}

	private void Limpiar(){
		E1.Text = "";
		E2.Text = "";
		E3.Text = "";
		E4.Text = "";
	}

	protected void OnAgregar1Clicked (object sender, EventArgs e)
	{
		TNotas Nt = new TNotas ();
		Llenar (Nt);
		Agregar (Nt);
		Ln.Agregar (Nt);
		Limpiar ();
	}

	protected void OnLimpiar1Clicked (object sender, EventArgs e)
	{
		Ln.Limpliar ();
		Mod.Clear ();
		Limpiar ();
	}

	protected void OnEliminarClicked (object sender, EventArgs e)
	{
		int pos;
		TreeIter Fila;
		if (Tw.Selection.GetSelected (out Fila)) {
			pos = int.Parse (Mod.GetStringFromIter (Fila));
			Ln.Eliminar (pos);
			Mod.Remove (ref Fila);
		}
	}

	protected void OnAceptarClicked (object sender, EventArgs e)
	{
		string res = "";
		switch (Cb1.Active) {
		case 0:
			Ln.Ordenar ();
			Mod.Clear ();
			for (int i=0; i<Ln.Cantidad(); i++) {
				Agregar (Ln.getNotas (i));
			}
			break;
		case 1:
			res = Ln.Promedio () + "";
			break;
		case 2:
			res = Ln.Aprobadas () + "";
			break;
		case 3:
			res = Ln.Reprobadas () + "";
			break;
		case 4:
			res = Ln.PorcenAprobadas () + "";
			break;
		case 5:
			res = Ln.PorcenReprobadas () + "";
			break;
		}
		Er.Text = res;
	}
}
