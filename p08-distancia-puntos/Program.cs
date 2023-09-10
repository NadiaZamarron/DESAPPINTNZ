// Calcula la distancia entre dos puntos

Console.WriteLine("Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B\n");
Console.Clear();

            Console.WriteLine("Coordenadas del punto A:");
            Console.Write("X: ");
            double ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coordenadas del punto B:");
            Console.Write("X: ");
            double bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double by = Convert.ToDouble(Console.ReadLine());

            double distancia = CalcularDistancia(ax, ay, bx, by);

            Console.WriteLine($"La distancia es igual a: {distancia:f2}");

        static double CalcularDistancia(double ax, double ay, double bx, double by)
        {
            double diferenciaX = ax - bx;
            double diferenciaY = ay - by;
            double distancia = Math.Sqrt(Math.Pow(diferenciaX, 2) + Math.Pow(diferenciaY, 2));
            return distancia;
        }
    
