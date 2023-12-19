namespace Task_1;

internal sealed class Program 
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        
        for (var i = 0; i < n; i++) 
        {
            var input = Console.ReadLine();

            var chars = new List<char>(){'T', 'I', 'N', 'K', 'O', 'F', 'F'};

            var check = input.All(c => chars.Remove(c));

            Console.WriteLine(check && chars.Count == 0 ? "YES" : "NO");
        }
    }
}