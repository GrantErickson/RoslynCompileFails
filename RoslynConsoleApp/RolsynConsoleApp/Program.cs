using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using System.Linq;
using Microsoft.CodeAnalysis.Emit;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;

class Program
{

      static void Main(string[] args)
    {
        MSBuildWorkspace workspace = MSBuildWorkspace.Create();
        workspace.WorkspaceFailed += Workspace_WorkspaceFailed;

        // This line fails with a call to Workspace_WorkspaceFailed.
        var solution = workspace.OpenSolutionAsync(@"..\..\SimpleConsole\SimpleConsole.sln").Result;

        // Code that traverses trees removed


    }

    private static void Workspace_WorkspaceFailed(object sender, WorkspaceDiagnosticEventArgs e)
    {
        Console.WriteLine($"{ e.Diagnostic.Kind}: {e.Diagnostic.Message}");
        throw new Exception(e.Diagnostic.Message);
    }
}