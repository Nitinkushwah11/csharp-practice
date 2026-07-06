using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        //member variable 
        //private hides the variable from other classes 
        //Backing feild of the model property
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        //without using the field  Backing field
        //public string Model {  get; set; }

      
        //public int MyProperty { get; set; }
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine("A car of " + Brand + " model " + Model + " has been created");
           IsLuxury = isLuxury;
        }

        //public int MyProperty { get; set; }
        //Property
        //With Lambda Expression
        public bool IsLuxury1 { get => IsLuxury; set => IsLuxury = value; }


        public string Model
        {
            get => Model;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }

            }
        }
          //it is part of encapsulation      
        public string Brand
        {
            get
            {
                if(IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }else
                {
                    return _brand;
                }
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                }else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }
       
    }
}
