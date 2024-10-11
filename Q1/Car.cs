using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Car
    {

        //Definded attributes
        private string _make;
        private string _model;
        private double _currentSpeed;
        private double _engineSize;


        //Getters and Setters
        public string Make
        {

            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {

            get { return _model; }
            set { _model = value; }
        }

        public double CurrentSpeed
        {

            get { return _currentSpeed; }
            set { _currentSpeed = value; }
        }

        public double EngineSize
        {

            get { return _engineSize; }
            set { _engineSize = value; }
        }

        //Contructors

        public Car(string make , string model , double engineSize , double currentSpeed)
        {
            Make = make;
            Model = model;  
            EngineSize = engineSize;
            CurrentSpeed = currentSpeed;
        }




        //To string method
        public override string ToString()
        {
            return $"The {Make} {Model}, engine size {EngineSize}l is currently travelling at {CurrentSpeed} km/h ";
        }



    }
}
