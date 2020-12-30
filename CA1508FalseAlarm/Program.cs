namespace CA1508FalseAlarm
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static void Main()
        {
            HashSet<int> state = new HashSet<int>
            {
                0,
            };

            int hits = 0;
            for (int i = 0; i < 1; i++)
            {
                hits += state.Contains(i) ? 1 : 0;
            }

            if (hits != 0)
            {
                Console.WriteLine($"Analyzer thinks we will never have any hits, but we had {hits}...");
            }
        }
    }
}
