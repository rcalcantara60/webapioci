pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh '''cd WebApiCore;
docker build -t us-ashburn-1.ocir.io/idtz46tpaghv/webapicore .;'''
      }
    }

  }
}