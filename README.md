# RestAssured for .NET Boiler Plate

This boiler plate provides a basis for setting up RestAssured tests for .NET using RestAssured.NET via C# from Bas Dijkstra. This is starting to be used widely and works of the back of the NUnit framework.

The suite provides a small sample of tests that originate from his own sample test repo and adopts the freely available API endpoint https://jsonplaceholder.typicode.com - tests/apiTests/exampleTests.cs

It is assumed that the .NET project consists of a 'tests' folder (standard). The apiTests folder differenciates API focussed tests from expected unit tests. 


## Getting Started
### Packages Used and Prerequisits 
- "Microsoft.NET.Test.Sdk" Version="17.8.0"
- "NUnit" Version="3.14.0"
- "NUnit.Analyzers" Version="3.9.0"
- "NUnit3TestAdapter" Version="4.5.0"
- "RestAssured.Net" Version="4.2.2"

RestAssured.Net 4.2.2 is the latest package version as of July 2024 and is availble on NuGet

Clone the repository locally and download the dependencies listed in the file restAssuredNet_boilerplate.csproj
```
git clone https://gitlab.mantelgroup.com.au/digio-test-automation/restAssuredNet_boilerplate.git
```
> **_NOTE:_** model/posts.cs allows for formatting post requests as JSON

## Running Tests

### Without adoption into an existing .Net project:

Perform a build from within the root directory restAssuredNet_boilerplate 
```
dotnet build
```

Run the tests from within the root directory restAssuredNet_boilerplate
```
dotnet test
```

### With adoption into an existing .Net project
For an existing project do the following:
- copy the folders "model" to the root of your project
- copy "apiTests" folder to the existing tests folder of your project
- within your existing *.csproj add the required package references if not already added (see restAssuredNet_boilerplate.csproj and above for expectations)
- Perform a build from within the root directory  
```
dotnet build
```

- Run the tests from within the root directory 
```
dotnet test
```

## Test Explorer
If using VSCode adding the following in the .vscode {} settings.json file will assist with running tests via Test Explorer (will require an install of a test runner extension):

```
{
    "dotnet.defaultSolution": "restAssuredNet_boilerplate.sln",
    "dotnetAcquisitionExtension.enableTelemetry": false,
    "nunitTestRunner.projectsPatterns": [
        "**/tests/*/*.test.cs"
    ],
    "dotnet-test-explorer.treeMode": "flat",
    "testExplorer.addToEditorContextMenu": true,
    "dotnet-test-explorer.testProjectPath": "**/tests/*/*.test.cs"
}
```


## Resources
The following resources will assist with expanding tests

https://github.com/basdijkstra/rest-assured-net-examples/tree/main/RestAssuredNetExamples

https://github.com/basdijkstra/rest-assured-net

https://code.visualstudio.com/docs/csharp/testing
