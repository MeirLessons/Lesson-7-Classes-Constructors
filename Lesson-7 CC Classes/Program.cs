using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_CC_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create New Instance From Program Class
            Program p2 = new Program();

            //Create New Int Array
            int[] myArr = new int[3];
            myArr[0] = 1;
            myArr[1] = 10;
            myArr[2] = 100;
            Console.WriteLine(myArr);
            // First Instance (Object Initialize);
            Car myCar = new Car("Mazda")
            {
                _year = 2021,//Setter
                _isActive = true//Setter
            };

            int myYear = myCar._year;//Getter
            //Methods Area
            myCar.Drive(153);
            myCar.GetKm();

            //Second Instance
            Car myFoo = new Car("Suzuki");
            myFoo._year = 2018;
            myFoo._isActive = true;
            myFoo.GetKm();

            Car empCar = new Car();
            
            Car myFoo2 = myFoo;//Same Reference

            Car c3 = new Car("Chevrolet", "Red");
            
            Car c4 = new Car();//Empty Ctor


            Car c5 = new Car(1999, "Honda", "Black", true);//Full Constractor
            bool isRefEqls = Car.ReferenceEquals(myCar, myFoo);//By Type
            Console.WriteLine(myFoo2.Equals(myFoo));//By Instance



            string carToString = "Lesson_7_CC_Classes.Car";// = myCar.ToString();
            Console.WriteLine(myFoo);//Invoke ToString Of Car Class (Lesson_7_CC_Classes.Car)
            Console.WriteLine(carToString);//Invoke ToString Of string Class
            Console.WriteLine(myCar._km);//Invoke ToString Of int Class

        }

    }

    public class Car
    {
        #region Fields

        public int _year;
        public string _brand;
        public string _color;
        public bool _isActive;
        public bool _isDrive;
        public int _km;

        #endregion

        #region Constructors

        public Car()
        {

        }

        public Car(string brand)
        {
            _brand = brand;
        }

        public Car(string brand, string color) : this(brand)
        {
            _color = color;
        }

        public Car(int year, string brand, string color) : this(brand,color)
        {
            _year = year;
        }

        //Ctrl + .
        //Alt + Enter
        public Car(int year, string brand, string color, bool isActive) : this(year, brand, color)
        {
            _isActive = isActive;
        }








        #endregion

        #region Methods

        public void Drive(int km)
        {
            if (_isActive)
            {
                _isDrive = true;
                _km = km;
            }
            else
            {
                Console.WriteLine("You Can't Drive!");
            }
        }

        public int GetKm()
        {
            if(_isDrive)
            {
                return _km;
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }

}
