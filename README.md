# SampleCoreApp3 is multi-containers application using aspnetcore image and mssql-server-linux image
# Deploy on Kubernetes (Azure Container Service)

1. Build multi-containers application on local

  Docker Compose File: docker-compose.yml
  Exec:  docker-compose up

2. Translate a Docker Compose to Kubernetes resources 

  Exec: kompose convert
  Generate kubernetes services, deployments files

3. Deploy multi-containers on Kubernetes
  
  Exec: kubectl create -f db-deployment.yaml,web-deployment.yaml,db-service.yaml,web-service.yaml

4. Access Application 
  Exec: kubectl get service web  --watch
