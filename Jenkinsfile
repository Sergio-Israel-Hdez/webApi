pipeline {
    agent any

    stages {
        stage('Dotnet Build') {
            steps {
                // Coloca aquí los comandos o scripts para el Paso A
                // Por ejemplo: sh 'mi_comando'
                dir('WebApi') {
                            //sh 'pwd'  // Opcional: mostrar el directorio actual después del cambio
                            sh 'ls -R'
                            sh 'dotnet build'
                        }
              
            }
        }

        stage('Docker compose') {
            when {
                expression {
                    currentBuild.resultIsBetterOrEqualTo('SUCCESS')
                }
            }
            steps {
                script {
                    if (currentBuild.resultIsBetterOrEqualTo('SUCCESS')) {
                        // Ejecuta el comando 'dotnet build' en el Paso B
                        //echo "aqui tendra que ir el docker compose?"
                        //sh 'pwd'
                        //sh 'ls -R'
                        dir('WebApi') {
                            //sh 'pwd'  // Opcional: mostrar el directorio actual después del cambio
                            sh 'ls -R'
                            sh 'docker-compose up -d'
                        }
                    } else {
                        currentBuild.result = 'FAILURE'
                        error('Paso Dotnet Build falló, por lo que Paso Docker Compose se omite.')
                    }
                }
            }
        }
    }
}