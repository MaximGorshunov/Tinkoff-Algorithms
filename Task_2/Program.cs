namespace Task_2;

internal sealed class Program
{
    private static void Main()
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine());
            
            var result = true;
            var dict = new Dictionary<int, int>();
            var programmers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            programmers.Sort();
            programmers.Reverse();
            
            for (var j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    dict[j] = programmers[j];
                    continue;
                }

                if (programmers[j] == 0 || dict.Count == 0)
                {
                    result = false;
                    break;
                }

                var key = 0;
                foreach (var d in dict)
                {
                    key = d.Key;
                    dict[key]--;
                    break;
                }

                if (programmers[j] - 1 != 0)
                {
                    dict[j] = --programmers[j];
                }

                if (dict[key] == 0)
                {
                    dict.Remove(key);
                }
            }

            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}