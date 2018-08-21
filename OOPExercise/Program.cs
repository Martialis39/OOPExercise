using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{

//    Exercise

//Create a class 

//Should have a

//Prop Name
//Lastname
//Full name readonly prop
//DateOfBirt datetime prop
//age int readonly prop

//rules
//Names capitalized
//dateofbirth cant be older than 80 y from tdate and no later than today
//faulty DOB becomes today

//local values lowercase
//_underscored properties
//other LikeThis


//Order: 

//static fields
//private public
//instance fields
//private public

//constructors

//props

//other methods
//static instance

    class Program
    {
        static void Main(string[] args)
        {

            Person jaan = new Person();
            jaan.FirstName = "Jaan";
            jaan.LastName = "Jaanson";
            Console.WriteLine(jaan.FullName);
            jaan.DateOfBirth = DateTime.Parse("12/09/1990");
            Console.WriteLine(jaan.DateOfBirth);
            Console.WriteLine(jaan.Age);
            Console.WriteLine(jaan.FirstName);
        }
    }

    class Person
    {

        private string firstName;
        private string lastName;
        private string fullName;
        private int age;
        private DateTime dateOfBirth;


        public string FirstName
        {

            get
            {
                return firstName;
            }
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToUpper())
                {
                    firstName = value;
                }
            }
        }


        public string LastName
        {

            get
            {
                return lastName;
            }
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToUpper())
                {
                    lastName = value;
                }
            }
        }

        public string FullName { 
            get {
                if(firstName != null && lastName != null)
                {
                    return firstName + " " + lastName;
                } else
                {
                    return null;
                }

            }
        }
        public int Age {

            get
            {
                
                return DateTime.Now.Year - DateOfBirth.Year;
               
            }
        }
        public DateTime DateOfBirth { get => dateOfBirth;
            set
            {

                //dateOfBirth = DateTime.Parse(value);
                // Miks see ei tööta?
                DateTime today = DateTime.Today;
                if(value > today || value < today.AddYears(-80))
                {
                    Console.WriteLine((value - today));
                    dateOfBirth = today;
                } else
                {
                    dateOfBirth = value;
                }
                    
               
            }

        }

        
    }

}
