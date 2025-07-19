# Report with xUnitV3

## Run Test With Microsoft Testing Platform(Mtp)

- Add **UseMicrosoftTestingPlatformRunner**

  ```xml
  <PropertyGroup>
    <UseMicrosoftTestingPlatformRunner>true</UseMicrosoftTestingPlatformRunner>
  </PropertyGroup>
  ```

- Run Test

  ```sh
  dotnet run
  ```

## Test Options and Reports

1. Generate Unit Test Report

   ```sh
   dotnet run --report-junit  --report-junit-filename junit.xml --results-directory report --report-ctrf --report-ctrf-filename ctrf.json
   ```

   ```sh
   dotnet run --report-junit  --report-junit-filename junit.xml --results-directory report --report-xunit-html --report-xunit-html-filename report.html
   ```

2. Generate Coverage Report

   2.1. Add **Microsoft.Testing.Extensions.CodeCoverage**

   ```sh
   dotnet add package Microsoft.Testing.Extensions.CodeCoverage
   ```

   2.2. Generate `html` report from `xml` report

   - Install `dotnet-reportgenerator-globaltool`

     ```sh
     dotnet tool install --global dotnet-reportgenerator-globaltool
     ```

   - Generate `html` report

     ```sh
     reportgenerator -reports:"Path/To/Credit.Tests/TestResults/<hash value>/coverage.cobertura.xml" -targetdir:"coveragereport"
     ```
