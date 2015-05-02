using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class ImABigBoyNow
{
    public static void Main()
    {
        Console.WriteLine("Press '1' or '2'");
        var scores = new Dictionary<char, int> {{'1', 0}, {'2', 0}};
        //TODO: display stuff if over console.height
        //foreach (var k in scores.Keys) Console.Write("{0}:", k);
        while (true)
        {
            scores[Console.ReadKey().KeyChar]++;
            Console.Clear();
            foreach (var k in scores)
            {
                Console.WriteLine("{0}: {1}", k.Key, k.Value);
                if (k.Value < 100) continue;
                Console.WriteLine("{0} wins", k.Key);
                Console.ReadKey();
                return;
            }
            var max = scores.Values.Max();
            var winning = (from k in scores where k.Value == max select k.Key).ToList();
            var length = winning.Count();
            //TODO: linqify
            if (winning.Count == 1) Console.WriteLine("{0} is in the lead", winning[0]);
            else
            {
                var status = new StringBuilder();
                for (var i = 0; i < length - 2; i++) status.Append(winning[i]).Append(", ");
                status.Append(winning[length - 2]).Append(" and ").Append(winning.Last()).Append(" are tied");
                Console.WriteLine(status);
            }
            //TODO: add more stuff like more numbers/letters? more modes? set score to end at?
        }
    }
}