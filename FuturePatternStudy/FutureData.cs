using System;
namespace FuturePatternStudy
{
	public class FutureData
	{
		int askedTime = 0;
		int targetAskedTime = 10;
		public FutureData()
		{
		}
		public bool isReady()
		{
			this.askedTime++;
			Console.WriteLine("customer ask for fucking KONAMI : " + askedTime + " times");
			return askedTime < targetAskedTime ? false : true;
		}
	}
}

