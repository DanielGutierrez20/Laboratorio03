using System;				
public class Program
{
    static void EjecutarEtapa1()
    {
        Console.WriteLine("--- ETAPA 1: ARREGLOS UNIDIMENSIONALES ---\n");
        int[] numeros = { 12, 45, 7, 23, 89, 34, 56, 90, 11, 67 };

        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Índice [{i}]: {numeros[i]}");
        }

        Console.Write("\nIngrese un nuevo valor para el tercer elemento (índice 2): ");
        if (int.TryParse(Console.ReadLine(), out int nuevoValor))
        {
            numeros[2] = nuevoValor;
            Console.WriteLine($"Valor actualizado en índice 2: {numeros[2]}");

            Console.WriteLine("\n--- Arreglo Actualizado ---");
             for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Índice [{i}]: {numeros[i]}");
            }
        }

        Console.Write("\nIngrese un número a buscar: ");
        if (int.TryParse(Console.ReadLine(), out int busqueda))
        {
            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == busqueda)
                {
                    Console.WriteLine($"¡Número {busqueda} encontrado en el índice [{i}]!");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"El número {busqueda} no existe en el arreglo.");
            }
        }
    }

    static void EjecutarEtapa2()
    {
        Console.WriteLine("--- ETAPA 2: MATRIZ 3x3 ---\n");
        int[,] matriz = new int[3, 3];
        int sumaTotal = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Ingrese valor para la posición [{i},{j}]: ");
                int.TryParse(Console.ReadLine(), out matriz[i, j]);
            }
        }

        Console.WriteLine("\nMatriz ingresada:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matriz[i, j]}\t");
                sumaTotal += matriz[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nLa suma total de los elementos es: {sumaTotal}");
    }

    static void EjecutarEtapa3()
    {
        List<int> lista = new List<int>();
        int subOpcion;

        do
        {
            Console.WriteLine("\n--- ETAPA 3: OPERACIONES SOBRE LISTA ---");
            Console.WriteLine("1. Insertar elemento");
            Console.WriteLine("2. Eliminar elemento por posición");
            Console.WriteLine("3. Buscar valor y mostrar posición");
            Console.WriteLine("4. Mostrar lista actualizada");
            Console.WriteLine("5. Regresar al menú principal");
            Console.Write("Seleccione una opción: ");
            int.TryParse(Console.ReadLine(), out subOpcion);

            switch (subOpcion)
            {
                case 1:
                    Console.Write("Ingrese valor a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valAdd))
                    {
                        lista.Add(valAdd);
                        Console.WriteLine("Elemento agregado.");
                    }
                    break;
                case 2:
                    Console.Write("Ingrese posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 0 && pos < lista.Count)
                    {
                        lista.RemoveAt(pos);
                        Console.WriteLine("Elemento eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("Posición no válida.");
                    }
                    break;
                case 3:
                    Console.Write("Ingrese valor a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int valBus))
                    {
                        int idx = lista.IndexOf(valBus);
                        if (idx != -1)
                            Console.WriteLine($"El valor está en la posición [{idx}].");
                        else
                        Console.WriteLine("Valor no encontrado.");
                    }
                    break;
                case 4:
                    Console.WriteLine("\nLista actual:");
                    if (lista.Count == 0) Console.WriteLine("[Vacía]");
                    else
                        for (int i = 0; i < lista.Count; i++)
                        Console.WriteLine($"[{i}]: {lista[i]}");
                    break;
            }
        } while (subOpcion != 5);
    }

	public static void Main()
	{
        int opcion;
        do
        {
        Console.Clear();
		Console.WriteLine("==========================================================================");
        Console.WriteLine("    LABORATORIO 03: ARREGLOS Y PROCESAMIENTO DE DATOS LINEALES EN C#     ");
        Console.WriteLine("==========================================================================");
        Console.WriteLine("==============================================");
        Console.WriteLine("1. Etapa 1: Exploración de Arreglos");
        Console.WriteLine("2. Etapa 2: Arreglos Bidimensionales (Matriz)");
        Console.WriteLine("3. Etapa 3: Operaciones con Listas Dinámicas");
        Console.WriteLine("4. Etapa 4: Algoritmos de Ordenamiento");
        Console.WriteLine("5. Salir");
        Console.WriteLine("==============================================");
        Console.Write("Seleccione una etapa a ejecutar: ");
		if (int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        EjecutarEtapa1();
                        break;
                    case 2:
                        EjecutarEtapa2();
                        break;
                    case 3:
                        EjecutarEtapa3();
                        break;
                    case 4:
                        //EjecutarEtapa4();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
                Console.ReadKey();
            }
        } while (opcion != 5);
	}
}