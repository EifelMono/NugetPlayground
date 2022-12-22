using System.Reflection;

namespace Lib;
public class LibClass
{
    private static readonly string s_libText = $"{AppContext.BaseDirectory}/Lib.Txt";
    private static readonly string s_appText = $"{AppContext.BaseDirectory}/App.Txt";
    private static readonly string s_libInFolder_LibInFolderText = $"{AppContext.BaseDirectory}/LibInFolder/LibInFolder.Txt";

    public static void Infos()
    {
        Console.WriteLine($"Lib Infos");
        ;
        Console.WriteLine($"Enty Assembly {Assembly.GetEntryAssembly()!.FullName}");
        ;
        Console.WriteLine($"Calling Assembly {Assembly.GetCallingAssembly()!.FullName}");
        ;
        Console.WriteLine($"Executing Assembly {Assembly.GetExecutingAssembly()!.FullName}");
        ;
        Console.WriteLine($"AppText exist {System.IO.File.Exists(s_appText)}");
        ;
        Console.WriteLine($"LibText exist {System.IO.File.Exists(s_libText)}");
        ;
        Console.WriteLine($"LibInFolder_LibInFolderText exist {System.IO.File.Exists(s_libInFolder_LibInFolderText)}");
        ;
        Console.WriteLine($"\r\n");
    }
}
