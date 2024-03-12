namespace Ejercicio6VersionInvertida
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 120324 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 120324 - dom
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Ingrese una cadena:");
            string ej = Console.ReadLine();

            string reversedString = ReverseString(ej);
            Console.WriteLine("Versión invertida:");
            Console.WriteLine(reversedString);
        }

        static string ReverseString(string ej)
        {
            string invertido = "";
            for (int i = ej.Length - 1; i >= 0; i--)
            {
                invertido+= ej[i];
            }
            return invertido;
        }
    }
}
    