namespace ExamenEricJDPC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaSencilla listaSencilla= new ListaSencilla();
            Console.WriteLine("Elije una opcion");
            Console.WriteLine("1 para salir");
            Console.WriteLine("2 para insertar al principio");
            Console.WriteLine("3 Insertar al final");
            Console.WriteLine("4 para Imprimir Lista");
            Console.WriteLine("5 para buscar");
            Console.WriteLine("6 Imprimir Ascendente");

            int opcion =Convert.ToInt32(Console.ReadLine());

            while (opcion!=1) 
            {
                switch (opcion)
                {
                    case 2:
                        Console.WriteLine("Ingrese el nombre");
                        Persona persona = new Persona();
                        persona.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad");
                        persona.Edad=Convert.ToInt32(Console.ReadLine());
                        listaSencilla.InsertarPrincipio(persona);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre");
                        Persona persona2 = new Persona();
                        persona2.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad");
                        persona2.Edad = Convert.ToInt32(Console.ReadLine());
                        listaSencilla.InsertarFinal(persona2);
                        break;
                    case 4:
                        listaSencilla.Imprimir();
                        break;
                    case 5: 
                        Console.WriteLine("Ingrese la edad del Perrito(persona) a buscar");
                        int buscador = Convert.ToInt32(Console.ReadLine());
                        listaSencilla.Buscar(buscador); 
                        break;
                    case 6:
                        listaSencilla.ImprimirAscendente();
                        break;
                }
                Console.WriteLine("Elije una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}