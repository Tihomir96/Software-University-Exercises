using System;
using _9.Traffic_Light.Enums;

namespace _9.Traffic_Light
{
    public class TrafficLight
    {
        private TrafficLights color;

        public TrafficLight(TrafficLights color)
        {
            this.color = color;
        }

        public void ChangeState()
        {
            this.color = (TrafficLights)((int)(this.color + 1)% Enum.GetNames(typeof(TrafficLights)).Length);
        }

        public override string ToString()
        {
            return this.color.ToString();
        }
    }
}
