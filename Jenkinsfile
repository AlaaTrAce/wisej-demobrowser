pipeline {
  agent any
  stages {
    stage('Cleanup') {
      agent {
        node {
          label 'test1'
        }

      }
      steps {
        dotnetClean(nologo: true, project: 'Wisej.DemoBrowser.sln')
      }
    }

    stage('Building Stage') {
      steps {
        dotnetRestore(project: 'Wisej.DemoBrowser.sln')
        dotnetBuild(project: 'Wisej.DemoBrowser.sln', force: true, continueOnError: true)
      }
    }

  }
}