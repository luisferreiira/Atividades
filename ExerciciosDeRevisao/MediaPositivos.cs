using System;

class MediaPositivos
{
    static void Main()
    {
        double num, media = 0;
        int quantPositivos = 0;
        for(int i=1; i <=6; i++)
        {
            num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                media = media + num;
                quantPositivos++;
            }
        }

        media /= quantPositivos;
        Console.WriteLine($"{quantPositivos} valores positivos");
        Console.WriteLine($"{media:F1}");
    }
}