using System;
using System.Threading;
namespace FuturePatternStudy
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			FutureData fuckKONAMI = new FutureData();
			ProgressChecker BuyAppleProgressChecker = new ProgressChecker(fuckKONAMI, () =>
			{
				Console.WriteLine("KONAMI is ready!");
				int i = 10;
				for (i = 10; i > 0; i--)
				{
					Console.WriteLine("Fuck you KONAMI!!!!");
				}		
			}
				);
			Thread FutureDataThread = new Thread(BuyAppleProgressChecker.isReady);
			FutureDataThread.Start();
			Console.WriteLine("Hello World!");
			Console.WriteLine("The ProgressCheck would check it by it self, lets do some stupid looping:");
			int stupidLoopTimes = 20;

			for (stupidLoopTimes = 20; stupidLoopTimes > 0; stupidLoopTimes--)
			{
				Console.WriteLine("do other things");
				Thread.Sleep(1500);
			}
				
			//while (!FutureDataThread.IsAlive){};
		}

		private class ProgressChecker
		{
			Action callBackWhenReady;
			FutureData FD;
			public ProgressChecker(FutureData FD,Action callBackWhenReady){
				this.FD = FD;
				this.callBackWhenReady = callBackWhenReady;
			}
			public void isReady()
			{
				while (!FD.isReady())
				{
					Console.WriteLine("KONAMI is not ready");
					Thread.Sleep(1000);
				}

				callBackWhenReady();
			}
		}
	}
}
