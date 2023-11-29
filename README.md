# console-app-dotnet
Console App Dotnet to Test


## Add packages

```
cd App
```

```
dotnet add package SecurityCodeScan.VS2019 --version 5.6.7
```

## Install global applications

```
dotnet tool install --global security-scan
dotnet tool install --global dotnet-coverage
dotnet tool install --global dotnet-reportgenerator-globaltool
```

```
$HOME/.dotnet/tools/security-scan console.sln
```


## Create Test project

```
dotnet new nunit -n AppTests
dotnet add AppTests/AppTests.csproj reference App/App.csproj
dotnet sln add AppTests/AppTests.csproj        
```

```
dotnet add AppTests package Faker.Net
```