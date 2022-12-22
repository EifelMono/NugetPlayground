using System.Reflection;

namespace Lib;
public class LibClass
{
	public static string LibText = $"{AppContext.BaseDirectory}/Lib.Txt";
	public static string AppText = $"{AppContext.BaseDirectory}/App.Txt";
	public static string LibInFolder_LibInFolderText = $"{AppContext.BaseDirectory}/LibInFolder/LibInFolder.Txt";

	public void Infos()
	{
		Console.WriteLine($"Lib Infos"); ;
		Console.WriteLine($"Enty Assembly {Assembly.GetEntryAssembly().FullName}"); ;
		Console.WriteLine($"Calling Assembly {Assembly.GetCallingAssembly().FullName}"); ;
		Console.WriteLine($"Executing Assembly {Assembly.GetExecutingAssembly().FullName}"); ;
		Console.WriteLine($"AppText exist {System.IO.File.Exists(AppText)}"); ;
		Console.WriteLine($"LibText exist {System.IO.File.Exists(LibText)}"); ;
		Console.WriteLine($"LibInFolder_LibInFolderText exist {System.IO.File.Exists(LibInFolder_LibInFolderText)}"); ;
        Console.WriteLine($"\r\n");
    }
}
