using System.Reflection;

namespace Lib;
public class LibClass
{
	public static string LibText = $"{AppContext.BaseDirectory}/Lib.Txt";
	public static string AppText = $"{AppContext.BaseDirectory}/App.Txt";
	public static string x86_Libx86Text = $"{AppContext.BaseDirectory}/x86/Libx86.Txt";

	public void Infos()
	{
		Console.WriteLine($"Lib Infos"); ;
		Console.WriteLine($"Enty Assembly {Assembly.GetEntryAssembly().FullName}"); ;
		Console.WriteLine($"Calling Assembly {Assembly.GetCallingAssembly().FullName}"); ;
		Console.WriteLine($"Executing Assembly {Assembly.GetExecutingAssembly().FullName}"); ;
		Console.WriteLine($"AppText exist {System.IO.File.Exists(AppText)}"); ;
		Console.WriteLine($"LibText exist {System.IO.File.Exists(LibText)}"); ;
		Console.WriteLine($"x86_Libx86Text exist {System.IO.File.Exists(x86_Libx86Text)}"); ;
        Console.WriteLine($"\r\n");
    }
}
