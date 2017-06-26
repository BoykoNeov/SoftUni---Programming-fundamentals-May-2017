using System.IO;
using System.Linq;

public class PunctuationFinder
{
    public static void Main()
    {
        var text = File.ReadAllText("sample_text.txt");
        var chars = text.Where(c => new char[] { '.', ',', '?', '!', ':' }.Any(i => i == c)).ToArray();

        File.WriteAllText("output.txt", string.Join(", ", chars));
    }
}