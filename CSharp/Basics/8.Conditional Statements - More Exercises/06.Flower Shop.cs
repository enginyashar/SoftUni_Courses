using System;
class FlowerShop
{
    static void Main()
    {
        int magnolias = int.Parse(Console.ReadLine());
        int hyacinths = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int cacti = int.Parse(Console.ReadLine());
        double giftPrice = double.Parse(Console.ReadLine());

        double totalGain = (magnolias * 3.25 + hyacinths * 4 + roses * 3.5 + cacti * 8) * 0.95;

        if (totalGain >= giftPrice)
        {
            Console.WriteLine($"She is left with {Math.Floor(totalGain - giftPrice)} leva.");
        }
        else
        {
            Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalGain)} leva.");
        }
    }
}
