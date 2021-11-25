using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {

            Triangle test = new Triangle(1, 1);

            Triangle tri = new Triangle(
                InteractiveInput.InputFloat("辺Aの長さ："),
                InteractiveInput.InputFloat("辺Aの長さ："),
                InteractiveInput.InputFloat("辺Aの長さ："));

            Console.WriteLine($"面積は{tri.GetSurface()}");
            
            
        }
    }
}
