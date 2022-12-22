# NugetPlayground 

My learning stuff for Nugets with targets on dotnet
and Cake

To build and compile I uses [CakeBuild](https://cakebuild.net/)
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
    * deletes all bin and obj folders
    * deletes the nuget in the local nuget folder (root nuget)
    * deletes the nuget in the global nuget folder (?user?/.nuget/packages)     
* targets
    * Additional file
    * Additional files
    * Using
    * Using with Static







