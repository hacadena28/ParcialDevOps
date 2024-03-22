# ParcialDevOps
> [!NOTE]
> Hola Mundo


## 1. Descargar el repositorio
```
https://github.com/hacadena28/ParcialDevOps.git
```
## 2. Navegue hasta el directorio del proyecto
```
cd ParcialDevOps
```
## 3. Genere la imagen del proyecto usando el archivo Dockerfile
```
docker build -t holamundo . 
```
## 4. Genere el contenedor de la api usando la imagen
```
docker run -d -p 8080:8080 --name holamundo-container holamundo
```
## 5. Realizar peticion
```
localhost:8080/saludo
```
