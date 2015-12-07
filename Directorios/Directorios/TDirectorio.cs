using System;
using System.IO;

public delegate void DOnDirectorio(string Ruta);
public delegate void DOnArchivo(FileInfo FI);

public class TDirectorio{
	private string FNombre;
	private DOnDirectorio FOnDirectorio;
	private DOnArchivo FOnArchivo;

	public TDirectorio (){
		FNombre="";
		FOnDirectorio=null;
		FOnArchivo=null;
	}

	public string Nombre{
		set{
			FNombre=value.Trim();
		}
		get{
			return FNombre;
		}
	}

	public DOnDirectorio OnDirectorio{
		set{
			FOnDirectorio=value;
		}
		get{
			return FOnDirectorio;
		}
	}

	public DOnArchivo OnArchivo{
		set{
			FOnArchivo=value;
		}
		get{
			return FOnArchivo;
		}
	}

	protected void Procesar(string Dir){
		int i;
		FileInfo []VFI;
		DirectoryInfo []VDI;
		DirectoryInfo DI;
		DI= new DirectoryInfo(Dir);
		if(FOnArchivo!=null){
			FOnDirectorio(DI.Name);
		}
		VFI=DI.GetFiles();
		if(VFI!=null && FOnArchivo!=null){
			for (i=0; i<VFI.Length; i++) {
				FOnArchivo (VFI [i]);
			}
		}
		VDI=DI.GetDirectories();
		if(VDI!=null && FOnDirectorio!=null){
			for(i=0;i<VDI.Length;i++){
				Procesar(VDI[i].FullName);
			}
		}
	}

	public void Procesar(){
		Procesar(FNombre);
	}
}

