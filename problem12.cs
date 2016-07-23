void Main()
{
	
	long wynik =0;
	long wynik2 = 0;
	long posrednia = 1;
	long wynik3 = 0;
	
	for(int i = 1; i<=1000000; i++)
	{
	
		for(long j = 0; j <= i; j++)
		{
			wynik = wynik + j;	
		}
		
		if(i%1000 == 0)
			Console.WriteLine("Postêp: " + i);
		
		posrednia = divider(wynik);
		
		if(posrednia > 500)
			{
				Console.WriteLine("WYNIK  = " + wynik);
				break;
			};
			
		posrednia = wynik;	
		wynik = 0;
	}
	

}

int divider(long wy)
{
	int counter = 0;
	
	
	
	for(long i = 1; i<=wy; i++)
	{
		if(wy%i == 0)
		{
			counter = counter + 1;			
		}
	
	}
	return counter;
}