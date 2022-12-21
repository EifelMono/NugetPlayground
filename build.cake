var target = Argument("target", "Default");
var configuration = Argument("configuration", "Debug");

var localNuGet= "nuget";
var userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
var globalNuGet= $"{userDirectory}/.nuget/packages";

Task("Clean")
.Does(() => {
   foreach(var bin in GetDirectories("src/**/bin"))
   {
      Information($"Clean bin {bin}");
      CleanDirectory(bin);
   }
   foreach(var obj in GetDirectories("src/**/obj"))
   {
      Information($"Clean obj {obj}");
      CleanDirectory(obj);
   }
   if (DirectoryExists(localNuGet))
   {
      Information($"Clean local {localNuGet}");
      CleanDirectory(localNuGet);
   }

   foreach(var nuget in GetDirectories($"{globalNuGet}/Lib"))
   {
      Information($"Clean global {nuget}");
      CleanDirectory(nuget);
   }
});

Task("Pack")
.Does(() => {
   DotNetPack("src/Lib/Lib.csproj", new DotNetPackSettings {
      OutputDirectory = localNuGet,
      Configuration= configuration
   });
});

Task("Restore")
.Does(() => {
   DotNetRestore("NugetPlayground.sln");
});


Task("Run")
.Does(() => {
   DotNetRun("src/AppWithLib/AppWithLib.csproj");
   DotNetRun("src/AppWithLibAsNuGet/AppWithLibAsNuGet.csproj");
});

Task("Default")
.IsDependentOn("Clean")
.IsDependentOn("Pack")
.IsDependentOn("Restore")
.IsDependentOn("Run")
.Does(() => {
   Information("Hello NuGet!");
});

RunTarget(target);