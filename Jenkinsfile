pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh '''cd WebApiCore;
		docker build -t us-ashburn-1.ocir.io/idtz46tpaghv/webapicore .;'''
        build 'teste'
      }
    }

    stage('Push') {
      steps {
        withDockerRegistry(credentialsId: 'OCIR', url: 'https://us-ashburn-1.ocir.io') {
          sh 'docker push us-ashburn-1.ocir.io/idtz46tpaghv/webapicore;'
        }

      }
    }

    stage('Deploy') {
      steps {
        sh '''cd WebApiCore;
		kubectl apply -f webapicore-lb.yml;'''
      }
    }

  }
}