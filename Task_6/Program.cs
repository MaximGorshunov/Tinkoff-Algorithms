namespace Task_6;

internal sealed class Program 
{
    private static void Main()
    {
        var nq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var q = nq[1];

        var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (var i = 0; i < q; i++) 
        {
            var query = Console.ReadLine().Split(' ').ToArray();
            var op = query[0][0];
            var l = int.Parse(query[1]);
            var r = int.Parse(query[2]);

            switch (op)
            {
                case '+':
                    var x = int.Parse(query[3]);
                    for (var j = l - 1; j < r; j++)
                    {
                        a[j] += x;
                    }
                    break;
                case '?':
                    var k = int.Parse(query[3]);
                    var b = int.Parse(query[4]);
                    var max = 0;
                    for (var j = l - 1; j < r; j++)
                    {
                        var min = a[j];
                        var temp = k * (j + 1) + b;
                        if (temp < min) min = temp;
                        if (j == l - 1) max = min;
                        else if (min > max) max = min;
                    }
                    Console.WriteLine(max);
                    break;
            }
        }  
    }
}