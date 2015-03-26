using System;
using System.Linq;

class Iamabigboynow
{
    public static void Main()
    {
        Console.WriteLine("Press '1' or '2'");
        var score = new[] {0, 0};
        var chars = new[] {'1', '2'};
        while (true)
        {
            var input = Console.ReadKey().KeyChar;
            var index = Array.IndexOf(chars, input);
            //TODO: improve find char
            score[index]++;
            Console.Clear();
            //TODO: setposition
            for (var i = 0; i < score.Length; i++) Console.WriteLine("{0}: {1}", chars[i], score[i]);

            for (var i = 0; i < score.Length; i++)
            {
                if (!(score[i] > 99)) continue;
                Console.WriteLine("{0} wins", i + 1);
                Console.ReadKey();
                return;
            }
            var max = score.Max();
            var maxScores = score.Where(t => t == max).ToArray();
            var length = maxScores.Length;
            var maxIndexes = new int[length];
            var j = 0;
            for (var i = 0; i < maxScores.Length; i++)
            {
                if (maxScores[i] != max) continue;
                maxIndexes[j] = i;
                j++;
            }
            if (maxScores.Length == 1) Console.WriteLine(chars[maxIndexes[0]] + " is in the lead");
            else
            {
                var status = "";
                for (var i = 0; i < length - 2; i++)
                {
                    status += chars[maxIndexes[i]] + ", ";
                }
                status += chars[maxIndexes[length - 2]] + " and " + chars[maxIndexes[length - 1]] + " are tied";
                Console.WriteLine(status);
            }
            //TODO: add more stuff like more numbers/letters? more modes? set score to finish?
        }
    }
}