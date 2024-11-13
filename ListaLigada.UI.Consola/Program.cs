using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada Simple\n");

        var singleList = new SingleList<string>();
  
        int opcion = 0;
        // cw + tab
        do
        {
            opcion = Menu();
            switch (opcion) 
            {
                case 1: AgregarElemento();   break;
                case 2: MostrarLista();  break;
                case 3: EliminarElemento(); break;
                    //default: Console.WriteLine("La Opcion no existe");  break;
            }

        } while (opcion != 0);

        void AgregarElemento()
        {
            Console.Write("-- Agregar elementos a la lista--\n");
            Console.Write("Escriba el nombre del nodo: ");
            var nombre = Console.ReadLine();
            singleList.Add(nombre);
            Console.WriteLine("");
        }

        void MostrarLista()
        {
            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista esta vacia\n");
            }
            else 
            {
                Console.WriteLine(singleList);
            }
            
        }

        void EliminarElemento() 
        {
            
        }

        Console.ReadKey();
    }// Fin del Main

    

    private static int Menu()
    {
        Console.WriteLine("Menu:\n");
        Console.WriteLine("1. Agregar Elemento\n");
        Console.WriteLine("2. Mostrar Lista\n");
        Console.WriteLine("3. Eliminar Elemento\n");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;

        int opcion = 0;

        do 
        { 
            Console.Write("Seleccione una opcion del Menu: ");
            var opcionCapturada = Console.ReadLine();
            Console.WriteLine("");

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("Ingrese una opcion valida\n");
                esValido = false;
            }
            else 
            {
                esValido = true;
            }

        } while (esValido==false);

        return opcion;
    }// Fin del Menu



}