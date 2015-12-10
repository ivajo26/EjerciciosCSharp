using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	private ListStore Mod;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		CrearColumnas ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	private void CrearColumnas()
	{
		int i;
		string[] Vec = { "Cedula", "Apellidos", "Nombres", "Programa", "Semestre", "Promedio" };
		Mod = new ListStore (typeof(long), typeof(string), typeof(string), typeof(string), typeof(byte),typeof(float));
		for (i = 0; i < Vec.Length; i++) {
		
			Trv.AppendColumn (new TreeViewColumn (Vec [i], new CellRendererText (), "text", i));
			Trv.Columns [i].Resizable = true;
		}
		Trv.Model = Mod;
	}
	private void Llenar(TEstudiante Est)
	{
		Est.Cedula = long.Parse (E1.Text);
		Est.Apellidos = E2.Text;
		Est.Nombres = E3.Text;
		Est.Programa = E4.Text;
		Est.Semestre = byte.Parse (E5.Text);
		Est.Promedio = float.Parse (E6.Text);
	}
	private void Agregar (TEstudiante Est)
	{
		Mod.AppendValues (Est.Cedula, Est.Apellidos, Est.Nombres, Est.Programa, Est.Semestre, Est.Promedio);
	}
	private void Llenar(int i, TEstudiante Est)
	{
		TreeIter Fila;
		Mod.IterNthChild (out Fila, i);
		Est.Cedula = long.Parse (Mod.GetValue (Fila, 0) + "");
		Est.Apellidos = Mod.GetValue (Fila, 1) + "";
		Est.Nombres = Mod.GetValue (Fila, 2) + "";
		Est.Programa =Mod.GetValue (Fila, 3) + "";
		Est.Semestre = byte.Parse (Mod.GetValue (Fila, 4) + "");
		Est.Promedio = float.Parse (Mod.GetValue (Fila, 5) + "");

	}
	private void Guardar(string Archivo)
	{
		int i;
		TEstudiante Est = new TEstudiante ();
		TEscEstudiante EE = new TEscEstudiante ();
		EE.Nombre = Archivo;
		EE.Abrir (false);
		for (i = 0; i < Mod.IterNChildren (); i++) {
		
			Llenar (i, Est);
		}
		EE.Cerrar ();
	}
	public void Cargar(string Archivo)
	{
		TEstudiante Est = new TEstudiante ();
		TLecEstudiante LE = new TLecEstudiante ();
		Mod.Clear ();
		LE.Abrir ();
		while (!LE.EsFinal ()) {
		
			if (LE.LeerObj (Est)) {
			
				Agregar (Est);
			} else
				break;
		}
		LE.Cerrar ();
	}

	protected void OnAgregarClicked (object sender, EventArgs e)
	{
		TEstudiante Est = new TEstudiante ();
		Llenar (Est);
		Agregar (Est);
		E1.Text = E2.Text = E3.Text = "";
		E4.Text = E5.Text = E6.Text = "";
	}

	protected void OnEliminarClicked (object sender, EventArgs e)
	{
		TreeIter Fila;
		if (Trv.Selection.GetSelected (out Fila)) {
		
			Mod.Remove (ref Fila);
		}
	}

	protected void OnGuardarClicked (object sender, EventArgs e)
	{
		Guardar("estudiante.txt");
	}

	protected void OnCargarClicked (object sender, EventArgs e)
	{
		Cargar ("estudiantes.txt");
	}
}
