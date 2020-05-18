pipeline {
  agent any
  stages {
    stage('Build') {
      steps {	    
        sh '''cd WebApiCore;
		docker build -t us-ashburn-1.ocir.io/idtz46tpaghv/webapicore .;'''		
      }
    }
    stage('Push') {
      steps {
        withDockerRegistry(credentialsId: 'OCIR', url: 'us-ashburn-1.ocir.io') {
			
		}
      }
    }
  }
}