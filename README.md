# RoslynCompileFails
Example of Roslyn 2.0.0-rc3 failing to compile a solution.

All examples are using VS 2017 RC (15.0.0-RC.3+26127.0) and .NET Core SDK 1.0 RC3 build 004530

This includes two solutions. 
SimpleConsole is just a .NetCore net46 console app. 
RoslynConsoleApp is the app that attempts to compile SimpleConsole.

When run, workspace.OpenSolutionAsync produces the following diagnostic:
"Msbuild failed when processing the file 'C:\\git\\RoslynCompileFails\\SimpleConsole\\SimpleConsole\\SimpleConsole.csproj' with message: The default XML namespace of the project must be the MSBuild XML namespace. If the project is authored in the MSBuild 2003 format, please add xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\" to the <Project> element. If the project has been authored in the old 1.0 or 1.2 format, please convert it to MSBuild 2003 format."
