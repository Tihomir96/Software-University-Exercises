using System;
using System.Collections.Generic;
using _9.Traffic_Light.Enums;

namespace _9.Traffic_Light
{
    public class Program
    {
        public static void Main()
        {
            List<TrafficLight>alltrafiLights =new List<TrafficLight>();
            var input = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());
            foreach (var signal in input)
            {
                TrafficLights initialColorState = (TrafficLights)Enum.Parse(typeof(TrafficLights), signal);
                alltrafiLights.Add(new TrafficLight(initialColorState));
            }
            for (int i = 0; i < stateChangeCount; i++)
            {
                foreach (var trafficLight in alltrafiLights)
                {
                    trafficLight.ChangeState();
                }
                Console.WriteLine(string.Join(" ", alltrafiLights));
            }

        }
    }
}
