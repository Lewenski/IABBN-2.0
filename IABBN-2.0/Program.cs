using System;

namespace Imabigboynow
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Press '1' or '2'");
			int Numberone = 0;
			int Numbertwo = 0;
			bool End = false;
			while(true)
			{
				int input = Console.ReadKey ().KeyChar;
				if (!End)
				{
					if (input == '1') 
					{
						Numberone++;
					} 
					else if (input == '2') 
					{
						Numbertwo++;
					}
				}
					
				Console.Clear ();
				Console.WriteLine ("{0}\n{1}",Numberone,Numbertwo);

				if (Numberone>99 && Numbertwo<100)
				{
					Console.WriteLine ("1 wins");
					End = true;
				}
				else if (Numbertwo>99 && Numberone<100)
				{
					Console.WriteLine ("2 wins");
					End = true;
				}
				else if (Numberone>Numbertwo && Numberone<100)
				{
					Console.WriteLine ("1 is in the lead");
							}
				else if (Numbertwo>Numberone && Numbertwo<100)
				{
					Console.WriteLine("2 is in the lead");
				}
				
				if (Numbertwo == Numberone)
				{
					Console.WriteLine("1 and 2 are currently tied");
				}
			}
		}
	}
}
