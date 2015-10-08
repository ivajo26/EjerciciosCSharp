using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	private void Llenar(TNotas Nt){
		Nt.Nota1 = float.Parse (E1.Text);
		Nt.Nota2 = float.Parse (E2.Text);
		Nt.Nota3 = float.Parse (E3.Text.Replace('.',','));
	}

	private TNotas Crear(){
		TNotas Nt = null;
		switch (CB1.Active) {
		case 0:
			Nt = new TNotas ();
			break;
		case 1:
			Nt = new TDef1 ();
			break;
		case 2:
			Nt = new TDef2 ();
			break;
		case 3:
			Nt = new TDef3 ();
			break;
		}
		return Nt;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		TNotas Nt = Crear ();
		Llenar (Nt);
		ER.Text = Math.Round (Nt.Definitiva (), 2) + "";
	}
}
