
# TecnoPunto - Control de Inventario

## Descripción
Aplicación de consola desarrollada en C# para registrar
productos y calcular el valor total de su inventario.

## Tecnologías
- C#
- .NET 10
- Visual Studio Code

## Funcionalidades
- Registro de tres productos.
- Validación de nombres vacíos.
- Validación de precios mayores que cero.
- Validación de cantidades no negativas.
- Manejo de entradas numéricas incorrectas.
- Cálculo del valor total de cada producto.
- Cálculo del valor total del inventario.

## Estructura del proyecto
- Producto.cs: clase, propiedades, constructor y métodos.
- Program.cs: registro de productos y manejo de errores.

## Ejecución
Abrir una terminal en la carpeta del proyecto y ejecutar:

dotnet run

## Pruebas realizadas
1. Registro correcto de tres productos.
2. Rechazo de precio negativo.
3. Rechazo de nombre vacío.
4. Rechazo de cantidad negativa.
5. Manejo de entradas no numéricas.
