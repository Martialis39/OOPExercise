using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        
           
            string fileName = @"..\..\TextFile1.txt";
            string[] file = File.ReadAllLines(fileName);
          



            foreach (string line in file)
            {
                
                
                string[] p = line.Split(',');
                Person newPerson = new Person(p[0], p[1], DateTime.Parse(p[2]));
            }



            foreach (var person in Person.listOfPeople)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }

    class Person
    {

        private string _FirstName;
        private string _LastName;
        private string _FullName;
        private int _Age;
        private DateTime _DateOfBirth;
        private int _Nr; public int Nr => _Nr;

        static Dictionary<int, Person> nimekiri = new Dictionary<int, Person>();

        public static List<Person> listOfPeople = new List<Person> ();

        public static int numberOfPeople = 1;

        

        public Person ( string firstName, string lastName, DateTime dateOfBirth) 
            // this is the constructor
            // we initialize the Person object and do some other stuff as well;
        {
            _FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth; // SET THE PROPERTY TO APPLY THE BUSINESS LOGIC!!
            _FullName = firstName + " " + lastName;
            _Age = DateTime.Now.Year - DateOfBirth.Year;
            _Nr = numberOfPeople++;
            
            listOfPeople.Add(this);
        }


        public string FirstName
        {

            get
            {
                return _FirstName;
            }
            set
            {
                
                _FirstName = value == "" ? value : value.Trim().Substring(0,1).ToUpper() + value.Trim().Substring(1).ToLower();
                
            }
        }

        

        public string LastName
        {

            get
            {
                return _LastName;
            }
            set
            {
                
                _LastName = value == "" ? value : value.Trim().Substring(0, 1).ToUpper() + value.Trim().Substring(1).ToLower();
                
            }
        }

        public string FullName { 
            get
            {

                return _FullName;

            }
        }
        public int Age {

            get
            {
                return _Age;
            }

            //set
            //{
                
            //    _Age = DateTime.Now.Year - DateOfBirth.Year;
               
            //}
        }
        public DateTime DateOfBirth { get => _DateOfBirth;
            set
            {

                //dateOfBirth = DateTime.Parse(value);
                // Miks see ei tööta?
                DateTime today = DateTime.Today;
                if(value > today || value < today.AddYears(-80))
                {
                    
                    _DateOfBirth = today;
                } else
                {
                    _DateOfBirth = value;
                }
                    
               
            }

        }

        public override string ToString()
        {
            return $"{Nr}. {FirstName}, {LastName}, {DateOfBirth}";
        }


    }

}
