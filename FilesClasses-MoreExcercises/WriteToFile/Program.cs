using System.IO;
using System.Linq;

    public class WriteToFile
    {
        public static void Main()
        {
            var text = File.ReadAllText("sample_text.txt");
            var chars = text.Where(c => ".,?!:".IndexOf(c) == -1).ToArray();

            File.WriteAllText("output1.txt", string.Join("", chars));
        }
    }