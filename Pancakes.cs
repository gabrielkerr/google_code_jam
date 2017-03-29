using System;

namespace Foo
{
    public class FooClass
    {
        public static void Main()
        {
            int linenumber = 0;
            string line;

            while(!String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                linenumber++;
                if(linenumber == 1)
                {
                    continue;
                }
                else
                {
                    int flips = FlipPancakes(line);
                    Console.WriteLine("Case #" + (linenumber - 1) + ": " + flips);
                }
            }
        }

        public static int FlipPancakes(string s)
        {
            char first = s[0];

            int i = 0;
            int flips = 0;

            while(i < s.Length)
            {
                if(s[i] == '-')
                {
                    while(i < s.Length && s[i] == '-')
                    {
                        i++;
                    }
                    flips += 2;
                }
                else
                {
                    i++;
                }
            }

            if(first == '-')
            {
                flips -= 1;
            }

            return flips;
        }
    }
}
