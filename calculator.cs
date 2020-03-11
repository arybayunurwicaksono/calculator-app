class Calculator
{
	static void Main(String[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.readKey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a+b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}