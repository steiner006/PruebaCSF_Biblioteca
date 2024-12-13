# API REST de Biblioteca - Prueba CSF

Este es un sistema básico de gestión de biblioteca con una API REST que permite gestionar autores, libros y préstamos.

## Endpoints

- **GET** `/api/autores` - Listar todos los autores.
- **POST** `/api/autores` - Crear un nuevo autor.
- **GET** `/api/autores/{id}` - Obtener un autor por ID.
- **PUT** `/api/autores/{id}` - Actualizar un autor existente.
- **DELETE** `/api/autores/{id}` - Eliminar un autor.

## Configuración

- Asegúrate de tener una base de datos SQL Server configurada.
- La cadena de conexión se encuentra en `appsettings.json`.
