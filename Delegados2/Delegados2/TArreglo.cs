using System;

namespace Delegados2
{
	public delegate void DMostrar(int pos, int val);
	public class TArreglo
	{
		private uint FTam;
		private int []FVec;
		private DMostrar FOnMostrar;
		public uint Tam {
			set {
				FTam = value;
				if (FTam > 0) {
					FVec = new int[FTam];
				} else {
					FVec = null;
				}
			}
			get {
				return FTam;
			}
		}
		public TArreglo (){

		}
		public int []Vec{
			get{
				return FVec;
			}
		}
		public DMostrar OnMostrar{
			set{
				FOnMostrar=value;
			}
			get{
				return FOnMostrar;
			}
		}
		public void LlenarPos(){
			int i;
			Random R=new Random();
			for(i=0;i<FTam;i++){
				FVec[i]=R.Next(3000)+10;
			}
		}
		public void LlenarNeg(){
			int i;
			Random R=new Random();
			for(i=0;i<FTam;i++){
				FVec[i]=R.Next(5000)-R.Next(3000);
			}
		}
		public void Mostrar(){
			if(FOnMostrar!=null){
				for(int i=0;i<FTam;i++){
					FOnMostrar(i,FVec[i]);
				}
			}
		}
	}
}

