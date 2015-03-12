using System;

class Iamabigboynow
{
    public static void Main()
    {
        Console.WriteLine("Press '1' or '2'");
        var one = 0;
        var two = 0;
        while (true)
        {
            int input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    one++;
                    break;
                case '2':
                    two++;
                    break;
            }

            Console.Clear();
            Console.WriteLine("{0}\n{1}", one, two);

            if (one > 99 && two < 100)
            {
                Console.WriteLine("1 wins");
                Console.ReadKey();
                return;
            }
            if (two > 99 && one < 100)
            {
                Console.WriteLine("2 wins");
                Console.ReadKey();
                return;
            }
            if (one > two && one < 100) Console.WriteLine("1 is in the lead");
            if (two > one && two < 100) Console.WriteLine("2 is in the lead");

            if (two == one) Console.WriteLine("1 and 2 are currently tied");
        }
    }
}