using System.Drawing;
using System.Text;
using Pastel;

class Program
{
    public static string Generator(int length)
    {
        const string chars = "@!;-:-._::0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rnd.Next(chars.Length);
            sb.Append(chars[index]);
        }

        return sb.ToString();
    }
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($@"{@"

   __  _______                   ._____________                        __   
  / /  \      \   ___________  __| _/\______   \_____    ______ ______ \ \  
 / /   /   |   \ /  _ \_  __ \/ __ |  |     ___/\__  \  /  ___//  ___/  \ \ 
 \ \  /    |    (  <_> )  | \/ /_/ |  |    |     / __ \_\___ \ \___ \   / / 
  \_\ \____|__  /\____/|__|  \____ |  |____|    (____  /____  >____  > /_/  
              \/                  \/                 \/     \/     \/       
".Pastel(Color.FromArgb(123, 0, 218))}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Write the lenght of the password: ");
        int length = Convert.ToInt32(Console.ReadLine());

        string password = Generator(length);
        Console.WriteLine("");
        Console.WriteLine("Generated password: " + password);

    }
}