
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


## Ejemplo de ejecución

El programa solicita los datos de tres productos.

### Datos de ejemplo

| Código | Nombre | Precio | Cantidad |
|--------|--------|--------|----------|
| P001 | Laptop | 25000 | 3 |
| P002 | Mouse | 500 | 10 |
| P003 | Teclado | 1500 | 3 |

### Resultados

- Laptop: RD$ 75,000.00
- Mouse: RD$ 5,000.00
- Teclado: RD$ 4,500.00

**Valor total del inventario: RD$ 84,500.00**

## Validaciones implementadas

El sistema rechaza:
- Nombres vacíos.
- Precios iguales o menores que cero.
- Cantidades negativas.
- Entradas no numéricas en precio o cantidad.

Cuando ocurre un error, el programa muestra
un mensaje y permite intentar nuevamente.


## Evidencias de ejecución

### 1. Datos válidos
![Datos válidos](capturas/datos-validos.png)

### 2. Precio negativo
![Precio negativo](capturas/precio-negativo.png)

### 3. Nombre vacío
![Nombre vacío](capturas/nombre-vacio.png)

### 4. Cantidad cero
![Cantidad cero](capturas/cantidad-cero.png)
