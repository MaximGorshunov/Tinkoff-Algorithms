namespace Task_5;

internal sealed class Child
{
    public Child(int manulCount)
    {
        ManulCount = manulCount;
        Friends = new List<Child>();
    }

    public List<Child> Friends { get; }
    public int ManulCount { get; private set; }

    public void SendStickers(int stickersCount)
    {
        foreach (var child in Friends)
        {
            child.ManulCount += stickersCount;
        }
    }
}

internal sealed class Program
{
    private static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var m = input[1];
        var q = input[2];

        var children = Console.ReadLine().Split(' ').Select(x => new Child(int.Parse(x))).ToList();

        for (var i = 0; i < m; i++)
        {
            var pairs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var v = pairs[0];
            var u = pairs[1];
            children[v - 1].Friends.Add(children[u - 1]);
            children[u - 1].Friends.Add(children[v - 1]);
        }

        for (var i = 0; i < q; i++)
        {
            var query = Console.ReadLine().Split(' ').ToArray();
            var op = query[0][0];
            var child = int.Parse(query[1]);

            switch (op)
            {
                case '+':
                    var stickersCount = int.Parse(query[2]);
                    children[child - 1].SendStickers(stickersCount);
                    break;
                case '?':
                    Console.WriteLine(children[child - 1].ManulCount);
                    break;
            }
        }
    }
}