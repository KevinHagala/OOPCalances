using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odometer;
            int fueltank;

            public Car(string _mark, string _model, string _regNumber, string _color, int _odometer, int _fueltank)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odometer = 0;
                fueltank = 60;
            }

            public void Driving()
            {
                odometer += 100;
                fueltank -= 5;
            }

        }
        static void Main(string[] args)
        {

            while (fueltank != 0)
            {
                Driving.Barks();
            }
        }
    }
}
