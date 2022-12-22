using System.Reflection;

namespace Lib;
public class LibClass
{
    private static readonly string s_libText = $"{AppContext.BaseDirectory}/Lib.txt";
    private static readonly string s_appText = $"{AppContext.BaseDirectory}/App.txt";
    private static readonly string s_otherLibTxt_OtherLibText = $"{AppContext.BaseDirectory}/OtherLibTxt/OtherLib.txt";

    public static void Infos()
    {
        Console.WriteLine($"Lib Infos");
              Console.WriteLine($"AppContext.BaseDirectory {AppContext.BaseDirectory}");
        Console.WriteLine($"Enty Assembly {Assembly.GetEntryAssembly()!.FullName}");
        Console.WriteLine($"Calling Assembly {Assembly.GetCallingAssembly()!.FullName}");
        Console.WriteLine($"Executing Assembly {Assembly.GetExecutingAssembly()!.FullName}");
        Console.WriteLine($"AppText exist {System.IO.File.Exists(s_appText)}");
        Console.WriteLine($"LibText exist {System.IO.File.Exists(s_libText)}");
        Console.WriteLine($"OtherLibTxt_OtherLibText exist {System.IO.File.Exists(s_otherLibTxt_OtherLibText)}");
        Console.WriteLine($"\r\n");
    }
}
