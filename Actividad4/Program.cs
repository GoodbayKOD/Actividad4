namespace Actividad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa :)\n");

            // Entero temporal para verificaciones
            int temp;

            Nombre_Input_Label:
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            // Verificar nombre
            if (nombre == "" || int.TryParse(nombre, out temp))
            {
                // Print y volvemos al ingreso de dato
                Console.WriteLine("Nombre erroneo");
                goto Nombre_Input_Label;
            }

            AñoActual_Input_Label:
            Console.WriteLine("\nIngrese el año actual:");
            string inputTemp = Console.ReadLine();
            int añoActual = 0;

            // Verificar año
            if (inputTemp == "" || !int.TryParse(inputTemp, out añoActual))
            {
                Console.WriteLine("Año actual erroneo");
                goto AñoActual_Input_Label;
            }

            AñoNacimiento_Input_Label:
            Console.WriteLine("\nIngrese el año de su nacimiento:");
            inputTemp = Console.ReadLine();
            int añoNacimiento = 0;

            if (inputTemp == "" || !int.TryParse(inputTemp, out añoNacimiento))
            {
                Console.WriteLine("Año de nacimiento erroneo");
                goto AñoNacimiento_Input_Label;
            }

            // Calculo de edad
            int edad = (añoActual - añoNacimiento);

            // Printeo
            Console.WriteLine("\nTu nombre es " + nombre + " y tu edad es " + edad);

            if (edad >= 18)
                Console.WriteLine("Sos mayor de edad");
            else
                Console.WriteLine("No sos mayor de edad");
        }
    }
}
