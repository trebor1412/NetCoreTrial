# .Net Core 2.0 MVC Trial

## Notes

### Creating models for EntityFrameWork.Core Database-First 

To create models and dbcontext for existing database tables, you will need to run "dotnet ef" commands. To do that, it is necessary to add a DotNetCliTool reference to your target projects. As far as I know, currently it is not available to add this CLI reference via command. You have to hand-edit in your .csproj files like this:

```xml
  <ItemGroup>
  	<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
  </ItemGroup>
```

Then in your project root directory, run:

```
dotnet ef dbcontext scaffold "{Your MsSql ConnectionString}" Microsoft.EntityFrameworkCore.SqlServer -o {Output Directory}
```

### Creating individual EF Model class library

Currently, the "dotnet ef dbcontext scaffold command" will get error if you run it in classlib project that doesn't have an entry point. Which means you can only scaffold EF models in a "web" or "console" project. So, in my trial I solve this problem by doing these dumb steps:

1. Create a classlib project which you desire to be your EF Model library.
2. Create a empty web project which will be deleted after you finished scaffolding.
3. Scaffold your models in the web project and output to a specific directory.
4. Copy that directory to your classlib project.
5. Add "Microsoft.EntityFrameworkCore" and other necsssary packages to your classlib project.
6. Add your classlib project as reference where your wish to use it.
7. Delete that web project you created to scaffold in 2.



