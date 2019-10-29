using System;

namespace HighJump
{
    class HighJump
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = 0;
            int counter = 0;

            for (int i = n - 30; i <= n; i += 5)
            {
                l = int.Parse(Console.ReadLine());
                counter++;
                if (i == n && l > n)
                {
                    Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", i, counter);
                    break;
                }

                if (l > i)
                {
                    continue;
                }

                if (l <= i)
                {
                    l = int.Parse(Console.ReadLine());
                    counter++;
                    if (i == n && l > n)
                    {
                        Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", i, counter);
                        break;
                    }
                    if (l <= i)
                    {
                        l = int.Parse(Console.ReadLine());
                        counter++;
                        if (i == n && l > n)
                        {
                            Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", i, counter);
                            break;
                        }
                        if (l <= i)
                        {
                            Console.WriteLine("Tihomir failed at {0}cm after {1} jumps.", i, counter);
                            break;
                        }
                    }
                }
            }
        }
    }
}
