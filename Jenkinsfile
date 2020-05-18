pipeline {
  agent {
    docker.withRegistry('https://us-ashburn-1.ocir.io', 'OCIR') {
      image 'us-ashburn-1.ocir.io/idtz46tpaghv/webapicore'
    }

  }
  stages {
    stage('Build') {
      steps {
        sh '''cd WebApiCore;
			docker build -t us-ashburn-1.ocir.io/idtz46tpaghv/webapicore .;'''
      }
    }

  }
}