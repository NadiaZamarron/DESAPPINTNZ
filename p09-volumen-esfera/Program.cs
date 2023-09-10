// Calcula el volumen de la esfera

 Console.Clear();
 Console.Write("Ingrese el radio: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    double volumen = calcular(radio);
    Console.WriteLine($"Volumen: {volumen:f2}");
        Console.ReadLine();

    static double calcular(double radio)
    {
        double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        return volumen;
    }