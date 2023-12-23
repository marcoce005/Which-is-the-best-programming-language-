using System;

namespace Loop
{
	class ForLoop
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i <= 1000; i++)
			{
				Console.WriteLine("{0}", i);
			}
		}
	}	
}

// compila mcs -out:csharp.out for.cs