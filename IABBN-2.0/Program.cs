using System;
using System.Linq;

class ImABigBoyNow
{
    public static void Main()
    {
        Console.WriteLine("Press '1' or '2'");
        var chars = new[] {'1', '2'};
        var score = new[] { 0, 0 };
        while (true)
        {
            var input = Console.ReadKey().KeyChar;
            var index = Array.IndexOf(chars, input);
            score[index]++;
            Console.Clear();
            for (var i = 0; i < score.Length; i++) Console.WriteLine("{0}: {1}", chars[i], score[i]);

            for (var i = 0; i < score.Length; i++)
            {
                if (!(score[i] > 99)) continue;
                Console.WriteLine("{0} wins", chars[i]);
                Console.ReadKey();
                return;
            }
            var max = score.Max();
            var maxScores = score.Where(t => t == max).ToArray();
            Array.IndexOf(score, max);
            var length = maxScores.Length;
            var maxIndexes = new int[length];
            var j = 0;
            for (var i = 0; i < maxScores.Length; i++)
            {
                var k = Array.IndexOf(score, max, j);
                maxIndexes[i] = k;
                j = k + 1;
            }
            if (maxScores.Length == 1) Console.WriteLine("{0} is in the lead", chars[maxIndexes[0]]);
            else
            {
                var status = "";
                for (var i = 0; i < length - 2; i++) status += String.Format("{0}, ", chars[maxIndexes[i]]);
                status += String.Format("{0} and {1} are tied", chars[maxIndexes[length - 2]], chars[maxIndexes[length - 1]]);
                Console.WriteLine(status);
            }
            //TODO: add more stuff like more numbers/letters? more modes? set score to end at?
        }
    }
}