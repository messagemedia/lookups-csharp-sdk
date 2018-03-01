node {
    stage 'Checkout'
        checkout scm

    stage 'Prepare'
        bat 'nuget restore "MessageMediaLookups.sln"'
        bat 'nuget install NUnit.Runners -Version 3.2.1 -OutputDirectory testrunner'

    stage 'Build'
        bat "MSBuild.exe /p:Configuration=Release \"MessageMediaLookups.sln\""
        stage 'Test'
        bat "testrunner\\NUnit.ConsoleRunner.3.2.1\\tools\\nunit3-console.exe MessageMediaLookups.Tests\\bin\\Release\MessageMediaLookups.Tests.dll"            
     }