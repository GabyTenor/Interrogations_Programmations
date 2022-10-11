using System;

namespace I1P622_Tarnus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            trafficsLights[] lights = new trafficsLights[2]
            {
                new trafficsLights("Orange", 0001, "On"),
                new trafficsLights("Green", 0002, "On")
            };

            string statusInfo;

            Console.WriteLine("TRAFFIC LIGHT 1 :");
            for(int compteur1 = 0; compteur1 < 6; compteur1++)
            {
                for (int i = 0; i < 3; i++)
                { 
                    statusInfo = lights[0].LightsStatus();
                    Console.WriteLine(statusInfo);
                    lights[0].ChangeColors(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TRAFFIC LIGHT 2 :");
            for (int compteur2 = 0; compteur2 < 6; compteur2++)
            {
                for (int j = 0; j < 2; j++)
                {
                    lights[1].LightBlink(j);
                    statusInfo = lights[1].LightsStatus();
                    Console.WriteLine(statusInfo);
                }
            }
                      
            Console.ReadLine();
        }
    }
}
