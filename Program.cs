using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        switch (args.Length){

        
        case 2:
            foreach (String item in productos){
                string[] product = item.Split(",");
                Console.WriteLine($"Nombre :{(product[0])}");
                Console.WriteLine($"Precio :{Convert.ToInt32(product[2])}");                
                Console.WriteLine($"Cantidad :{Convert.ToInt32(product[2])}");
                Console.ReadKey();
            break;
            }
        
            
        case 3:
            Console.Clear();
            Console.WriteLine("Nombre Producto     Cantidad     Precio Unitario");
            foreach (String item in productos){
                string[] product = item.Split(",");
                Console.WriteLine("{0.-30} {2,6} {8,10}". product[0], product[2], Convert.ToDecimal(product[1]));
            }
            
            Console.ReadKey();
            break;
        case 4:
            isAddProduct = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opción no válida en el menú");
            break;
        }

    }
}