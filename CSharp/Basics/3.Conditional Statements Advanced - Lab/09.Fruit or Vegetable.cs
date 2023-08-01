using System;

namespace P042_CSA_Lab_09._FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string text = string.Empty;

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    text = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    text = "vegetable";
                    break;                    
                default:
                    text = "unknown";
                    break;
            }
            Console.WriteLine(text);
        }
    }
}
