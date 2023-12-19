namespace Task_3;

internal sealed class Program
{
    private static void Main()
    {
        var nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = nm[0];
        var m = nm[1];

        var gifts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var currentMax = m;
        for (var i = 0; i < n; i++)
        {
            if (currentMax < gifts[i]) continue;
            var leftMax = gifts[i] - 1;
            var rightMax = currentMax - gifts[i];
            currentMax = Math.Max(leftMax, rightMax);
        }

        Console.WriteLine(currentMax);
    }
}