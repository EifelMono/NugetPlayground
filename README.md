# NugetPlayground 

Learning stuff for nugets with targets on dotnet
and CakeBuild

To build and compile works with [CakeBuild](https://cakebuild.net/)
To compile this project you need to restore this tool

```
dotnet tool restore
```

Than you can run the build with

```
dotnet cake 
```


## My learnings

* nuget.config in the root directory for additional nuget sources
  * nuget directory in the root
* usage of nuget without changing of the version
  * cake script
    * deletes all bin and obj directories
    * deletes the nuget in the local nuget directory (root nuget)
    * deletes the nuget in the global nuget directory (?user?/.nuget/packages)     
* targets
    * Additional file
    * Additional files
    * Using
    * Using with Static







