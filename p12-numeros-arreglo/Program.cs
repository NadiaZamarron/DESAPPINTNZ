// Muestra los elementos de un arreglo, los suma, divide entre 2 cada elemento e invierte el arreglo


            int[] elementos = { 100, 123, 456, 222, 999, 895, 325, 234, 322, 988 };

            Console.Clear();
            Console.WriteLine("Elementos del arreglo:");
            MostrarArreglo(elementos);

            int sumaOriginal = SumaArreglo(elementos);
            Console.WriteLine($"Suma de los elementos: {sumaOriginal}");

            int[] elementosDivididos = DividirArreglo(elementos);
            int sumaDivididos = SumaArreglo(elementosDivididos);
            Console.WriteLine($"Suma de los elementos divididos entre 2: {sumaDivididos}");

            Array.Reverse(elementos);
            Console.WriteLine("Arreglo en orden inverso:");
            MostrarArreglo(elementos);

            Console.ReadLine();

        static void MostrarArreglo(int[] arr)
        {
            foreach (int elemento in arr)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }

        static int SumaArreglo(int[] arr)
        {
            int suma = 0;
            foreach (int elemento in arr)
            {
                suma += elemento;
            }
            return suma;
        }

        static int[] DividirArreglo(int[] arr)
        {
            int[] resultado = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                resultado[i] = arr[i] / 2;
            }
            return resultado;
        }