using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Creating_Classes
{
    public class Person_Class
    {
        private int privatePersonID;
        private string privateFirstName;
        private string privateLastName;
        private string privateFavoriteColour;
        private int privateAge;
        private bool privateIsWorking;

        public int PersonID
        {
            get { return privatePersonID; }
            set { privatePersonID = value; }
        }

        public string FirstName
        {
            get { return privateFirstName; }
            set { privateFirstName = value; }
        }

        public string LastName
        {
            get { return privateLastName; }
            set { privateLastName = value; }
        }

        public string FavoriteColour
        {
            get { return privateFavoriteColour; }
            set { privateFavoriteColour = value; }
        }

        public int Age
        {
            get { return privateAge; }
            set { privateAge = value; }
        }

        public bool IsWorking
        {
            get { return privateIsWorking; }
            set { privateIsWorking = value; }
        }

        public Person_Class(int personID, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonID}:{FirstName} {LastName}'s favorite colour is {FavoriteColour}\n");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public void GetAgeInTenYears()
        {
            int NewAge = Age + 10;
            Console.WriteLine($"{FirstName} {LastName}'s Age in 10 years is: {NewAge}\n");
        }

        public override string ToString()
        {
            List<string> PersonList = new List<string>();

            PersonList.Add($"PersonId: {PersonID}");
            PersonList.Add($"FirstName: {FirstName}");
            PersonList.Add($"LastName: {LastName}");
            PersonList.Add($"FavoriteColour: {FavoriteColour}");
            PersonList.Add($"Age: {Age}");
            PersonList.Add($"isWorking: {IsWorking}\n");


            foreach (string Object in PersonList)
            {
                Console.WriteLine(Object);
            }

            return null;
        }
    }
}
