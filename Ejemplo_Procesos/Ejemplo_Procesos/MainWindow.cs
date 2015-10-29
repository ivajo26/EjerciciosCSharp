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

	protected void OnEjecutarClicked (object sender, EventArgs e)
	{
		TProceso Pro;
		Pro = new TProceso();
		Pro.Nombre = E1.Text;
		Pro.Parametros = E2.Text;

		Txt.Buffer.Text = Pro.Ejecutar (Ch1.Active);
	}
}
