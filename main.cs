using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("What is your longest side?");
		string cmaxstring = Console.ReadLine();
		int cmax;
		List<string> termsList = new List<string>();
			if (!int.TryParse(cmaxstring, out cmax))
				{
				Console.WriteLine(cmaxstring);
				throw new System.ArgumentException("Parameter must be an interger", "original");
				}
		int bmin = (cmax/2);
		if (cmax % 2 == 1)
		bmin++;
		int count = 0;
		while (bmin < cmax) {
			int a = 0;
			while (a < bmin) {
			if (!(cmax >= a+bmin))
			{
				string temp = string.Join(", ", cmax, bmin, a);
				termsList.Add(temp);
				count++;
			}
			a++;
			}
		bmin++;
		}
		Console.WriteLine("Total number of triangles:  {0}", count);
		if (count > 250)
			Console.WriteLine("You will probably get an error due to the limitations of the software I'm using to write this");
		foreach (string term in termsList)
		{
		Console.WriteLine(term);
		}
		
	}
}