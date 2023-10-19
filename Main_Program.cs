using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_1_Creating_Classes
{
    internal class Main_Program
    {
        static void Main(string[] args)
        {
            Person_Class Ian = new Person_Class(1, "Ian", "Brooks", "Red", 30, true);
            Person_Class Gina = new Person_Class(2, "Gina", "James", "Green", 18, true);
            Person_Class Mike = new Person_Class(3, "Mike", "Briscoe", "Blue", 45, true);
            Person_Class Mary = new Person_Class(4, "Mary", "Beals", "Yellow", 28, true);

            Gina.DisplayPersonInfo();
            Mike.ToString();
            Ian.ChangeFavoriteColour();
            Ian.DisplayPersonInfo();
            Mary.GetAgeInTenYears();

            Relation_Class FirstRelationShip = new Relation_Class("Sisterhood");
            FirstRelationShip.ShowRelationShip(Gina, Mary);

            Relation_Class SecondRelationShip = new Relation_Class("Brotherhood");
            SecondRelationShip.ShowRelationShip(Ian, Mike);

            List<Person_Class> NewPersonObjectList = new List<Person_Class>();

            NewPersonObjectList.Add(Ian);
            NewPersonObjectList.Add(Gina);
            NewPersonObjectList.Add(Mike);
            NewPersonObjectList.Add(Mary);

            int TotalAge = 0;

            foreach (Person_Class i in NewPersonObjectList)
            {
                TotalAge += i.Age;
            }
            
            double averageAge = (double)TotalAge / NewPersonObjectList.Count;

            Console.WriteLine($"Average Age is: {averageAge}\n");

            int LowestAge = int.MaxValue;
            int HighestAge = int.MinValue;
            string FirstNameWithHighestAge = null;
            string FirstNameWithLowestAge = null;


            foreach (Person_Class i in NewPersonObjectList)
            {
                if (i.Age < LowestAge)
                {
                    LowestAge = i.Age;
                    FirstNameWithLowestAge = i.FirstName;
                }

                if (i.Age > HighestAge)
                {
                    HighestAge = i.Age;
                    FirstNameWithHighestAge = i.FirstName;
                }
            }

            if (FirstNameWithLowestAge != null)
            {
                Console.WriteLine($"The youngest person is: {FirstNameWithLowestAge} \n");
            }

            if (FirstNameWithHighestAge != null)
            {
                Console.WriteLine($"The oldest person is: {FirstNameWithHighestAge} \n");
            }

            foreach (Person_Class i in NewPersonObjectList)
            {
                if (i.FirstName.StartsWith("M"))
                {
                    i.ToString();
                }
            }

            foreach (Person_Class i in NewPersonObjectList)
            {
                if (i.FavoriteColour.Equals("Blue"))
                {
                    i.ToString();
                }
            }
            Console.ReadKey();
        }
    }
}
