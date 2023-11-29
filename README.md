# console-app-dotnet
Console App Dotnet to Test

## Create project solution

```
mkdir console
cd console
dotnet new sln -n console
```

## Create Console App project

```
dotnet new console -n App -f net6.0
dotnet sln add App/App.csproj
```

## Create Class Calc project

```
dotnet new classlib -n Calc -f net6.0
dotnet add App/App.csproj reference Calc/Calc.csproj
dotnet sln add Calc/Calc.csproj
```

## Create NUnit Calc Test project

```
dotnet new nunit -n CalcTests -f net6.0
dotnet add CalcTests package Faker.Net
dotnet add CalcTests/CalcTests.csproj reference Calc/Calc.csproj
dotnet sln add CalcTests/CalcTests.csproj
```

## Add packages

```
dotnet add App package SecurityCodeScan.VS2019
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


