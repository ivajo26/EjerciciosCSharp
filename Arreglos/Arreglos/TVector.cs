using System;

public class TVector{
	
	private int []FVec;
	private uint FTam;

	public TVector(){
		FTam = 0;
		FVec = null;
	}

	public uint Tam{
		set{
			FTam = value;
			if (FTam > 0) {
				FVec = new int[FTam];
			} else {
				FVec = null;
			}
		}
		get{
			return FTam;
		}
	}

	public int []Vec{
		get{
			return FVec;
		}
	}

	public void Llenar(){
		int i;
		Random R = new Random ();
		for (i = 0; i < FTam; i++){
			FVec [i] = R.Next (90) + 10;
		}
	}

	public int Mayor(){
		int i, max = FVec[0];
		for (i = 1; i < FTam; i++){
			if (FVec[i] > max) {
				max = FVec[i];
			}
		}
		return max;
	}

	public int Menor(){
		int i, min = FVec[0];
		for (i = 1; i < FTam; i++){
			if (FVec[i] < min) {
				min = FVec[i];
			}
		}
		return min;
	}

	public long Suma(){
		int i;
		long res;
		res = 0;
		for (i = 0; i < FTam; i++){
			res += FVec[i];
		}
		return res;
	}

	public float Promedio(){
		return (float)Suma() / FTam;
	}
}