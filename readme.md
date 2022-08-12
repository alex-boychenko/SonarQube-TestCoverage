## SonarQube
The SonarQube dashboard will be listening at [localhost:9001](http://localhost:9001/).

In order to use it, make sure you have Java SDK o JRE installed and JAVA_HOME as systema variables.

1. Login with `admin` and `admin`, then you'll need to choose a new password;
2. Select "Manually" and create a new project *dotnet-coverage*;
3. Follow the "Locally" instructions for testing SonarQube using the *CLI Tool*;
4. Once done, the dashboard will automatically refresh and show the report.

### Test example
You'll find these instructions, with the correct token, in your local SonarQube Dashboard once you'll have configured the project.

As a prerequisite you need to have the sonarscanner tool installed globally using the following command:

`dotnet tool install --global dotnet-sonarscanner`
`dotnet tool install --global JetBrains.dotCover.GlobalTool`

Make sure dotnet tools folder is in your path. See dotnet global tools documentation for more information.

Running a SonarQube analysis is straighforward. You just need to execute the following commands at the root of your solution.

```
dotnet sonarscanner begin /k:"dotnet-coverage" /d:sonar.host.url="http://localhost:9001" /d:sonar.login="sqp_925d3e84a75b175da7edef4dfbc86234b60018d0" /d:sonar.cs.dotcover.reportsPaths=dotCover.Output.html

dotnet dotcover test --no-build "./Library.UnitTests/Library.UnitTests.csproj" --dcOutput="Library.dcvr" --dcFilters="-:Assembly=*UnitTests*"
dotnet dotcover test --no-build "./Web.UnitTests/Web.UnitTests.csproj" --dcOutput="Web.dcvr" --dcFilters="-:Assembly=*UnitTests*"
dotnet dotcover merge --source="Library.dcvr;Web.dcvr"
dotnet dotcover report --source="dotCover.Output.dcvr" --dcReportType=HTML --dcExcludeFileMasks="/**/Migrations/*"

dotnet sonarscanner end /d:sonar.login="sqp_925d3e84a75b175da7edef4dfbc86234b60018d0""
```

