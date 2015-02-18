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
			int End = 0;
			while(true)
			{

				int input = Console.ReadKey ().KeyChar;
				if (input == '1' && End == 0) {
					Numberone++;
				} else if (input == '2' && End == 0) {
					Numbertwo++;
				}
					
				Console.Clear ();
				Console.WriteLine (Numberone);
				Console.WriteLine (Numbertwo);


				if (Numberone>99 && Numbertwo<100){
					Console.WriteLine ("1 wins");
					End = 1;}
				if (Numbertwo>99 && Numberone<100){
					Console.WriteLine ("2 wins");
					End = 1;}

				if (Numberone>Numbertwo && Numberone<100){
					Console.WriteLine ("1 is in the lead");}
				if (Numbertwo>Numberone && Numbertwo<100){
					Console.WriteLine("2 is in the lead");}
				if (Numbertwo == Numberone){
					Console.WriteLine("1 and 2 are currently tied");}
			}
		}
	}
}
