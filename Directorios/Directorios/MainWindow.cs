using System;
using Gtk;
using System.IO;

public partial class MainWindow: Gtk.Window{	

	private TreeStore Mod;
	private TreeIter Ultimo;
	public MainWindow (): base (Gtk.WindowType.Toplevel){
		Build ();
		CrearColumnas ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}

	private void CrearColumnas(){
		int i;
		string []Vec={"Directorio","Archivo","Tamaño","Creacion","Modificacion"};
		Mod = new TreeStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
		for (i=0; i<Vec.Length; i++) {
			TrV.AppendColumn (new TreeViewColumn(Vec[i],new CellRendererText(),"text",i));
			TrV.Columns [i].Resizable = true;
		}
		TrV.Model = Mod;
	}

	private void AgregarDir(string Dir){
		Ultimo = Mod.AppendValues (Dir,"","","","");
	}

	private string Tamano(long tam){
		float kb = 1024 * 1024;
		if (tam < kb) {
			return tam + " bytes";
		} else {
			return Math.Round(tam/kb,1)+" kb";
		}
	}

	private bool AceptarTam(long tam){
		return tam >= long.Parse (E2.Text);
	}

	private bool AceptarFec(DateTime Fe){
		DateTime Dt;
		Dt = DateTime.Parse (E3.Text);
		return Dt.Year == Fe.Year && Dt.Month == Fe.Month && Dt.Day == Fe.Day;
	}

	private bool AceptarExt(string Ext){
		return Ext.ToUpper () == E4.Text.ToUpper ();
	}

	private void AgregarArch(FileInfo FI){
		bool tem = false;
		switch (CB1.Active) {
		case 0:
			tem = true;
			break;
		case 1:
			tem = AceptarTam (FI.Length);
			break;
		case 2:
			tem = AceptarFec (FI.CreationTime);
			break;
		case 3:
			tem = AceptarExt (FI.Extension);
			break;
		case 4:
			if (AceptarTam (FI.Length)) {
				tem = AceptarFec (FI.CreationTime);
			}
			break;
		case 5:
			if (AceptarTam (FI.Length)) {
				tem = AceptarExt (FI.Extension);
			}
			break;
		case 6:
			if (AceptarFec (FI.CreationTime)) {
				tem = AceptarExt (FI.Extension);
			}
			break;
		case 7:
			if (AceptarTam (FI.Length)) {
				tem = AceptarFec (FI.CreationTime);
			}
			break;
		}
		if (tem) {
			Mod.AppendValues (Ultimo, "", FI.Name, Tamano (FI.Length), FI.CreationTime.ToShortDateString (), FI.LastWriteTime.ToShortDateString ());
		}
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		FileChooserDialog Dlg;
		Dlg = new FileChooserDialog ("Directorio Inicial", null, FileChooserAction.SelectFolder, Stock.Open, ResponseType.Ok, Stock.Cancel, ResponseType.Cancel);
		Dlg.ShowAll ();
		if (Dlg.Run () == (int)ResponseType.Ok) {
			E1.Text = Dlg.Filename;
		}
		Dlg.HideAll ();
		Dlg.Destroy ();
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		TDirectorio Dir;
		Dir=new TDirectorio();
		Dir.Nombre = E1.Text;
		Dir.OnDirectorio = AgregarDir;
		Dir.OnArchivo = AgregarArch;
		Mod.Clear();
		Dir.Procesar ();
	}
}
