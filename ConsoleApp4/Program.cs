for (double x = 5; x >= -5; x--)
{
    for (double y = -10; y <= -6; y++)
    {
        for (double z = 6; z <= 15; z++)
        {
            double a = (((2 * z - 3 * y * 5 * x) / (3 * x / (8 * y) + 3 * z)) / (4 * y * 6 * x - 8 * z) + (3 * x / (8 * y) / (5 * z))) / (3 * y + 6 * z - 8 * x) + 2.5;
            if (x != 0 && y != 0 && z != 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }
        }
    }
}