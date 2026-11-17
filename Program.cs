
Console.WriteLine("=== INVENTARIO TECNOPUNTO ===");

Producto producto1 = RegistrarProducto(1);
Producto producto2 = RegistrarProducto(2);
Producto producto3 = RegistrarProducto(3);

Console.WriteLine("\n=== INVENTARIO REGISTRADO ===");

producto1.MostrarInfo();
Console.WriteLine();

producto2.MostrarInfo();
Console.WriteLine();

producto3.MostrarInfo();

decimal totalInventario =
    producto1.ValorTotal +
    producto2.ValorTotal +
    producto3.ValorTotal;

Console.WriteLine($"\nValor total del inventario: RD$ {totalInventario:N2}");

static Producto RegistrarProducto(int numero)
{
    while (true)
    {
        try
        {
            Console.WriteLine($"\n--- PRODUCTO {numero} ---");

            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine() ?? "");

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine() ?? "");

            Producto producto = new Producto(
                codigo, nombre, precio, cantidad);

            Console.WriteLine("¡Producto registrado correctamente!");

            return producto;
        }
        catch (FormatException)
        {
            Console.WriteLine("ERROR: Introduce un número válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR: Número fuera del rango permitido.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
    }
}
