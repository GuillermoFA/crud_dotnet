# README: Ejecución de Proyecto .NET 7 en una Máquina Limpia

Este README proporciona instrucciones paso a paso para ejecutar un proyecto desarrollado en .NET 7 en una máquina limpia. Asegúrate de seguir estos pasos para garantizar una configuración adecuada y una ejecución exitosa del proyecto.

## Requisitos Previos
Antes de comenzar, asegúrate de tener instalados los siguientes requisitos en tu máquina:

- [SDK de .NET 7](https://dotnet.microsoft.com/download/dotnet/7.0)

## Pasos para la Ejecución

### 1. Clonar el Repositorio
```bash
git clone <[URL_DEL_REPOSITORIO](https://github.com/GuillermoFA/crud_dotnet)>
cd <NOMBRE_DEL_PROYECTO>
```

### 2. Restaurar Dependencias
Ejecuta el siguiente comando para restaurar las dependencias del proyecto:
```bash
dotnet restore
```

### 3. Compilar el Proyecto
Compila el proyecto utilizando el siguiente comando:
```bash
dotnet build
```

### 4. Ejecutar el Proyecto
Para ejecutar la aplicación, utiliza el siguiente comando:
```bash
dotnet run
```

Este comando iniciará la aplicación y estará disponible en `http://localhost:5000`. Abre tu navegador web y accede a esta URL para interactuar con la aplicación.

### 5. (Opcional) Crear un Paquete para Despliegue
Si deseas crear un paquete para el despliegue, puedes utilizar el siguiente comando:
```bash
dotnet publish -c Release -o <RUTA_DESPLIEGUE>
```
Esto generará los archivos necesarios en la carpeta especificada como `<RUTA_DESPLIEGUE>`.

## Contribuciones
Si encuentras algún problema o tienes sugerencias para mejorar el proyecto, no dudes en abrir un problema o enviar una solicitud de extracción.

¡Disfruta trabajando con el proyecto en .NET 7!
