using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Creating_Classes
{
    public class Relation_Class
    {
        private string RelationShip;

        public Relation_Class(string relationShip)
        {
            RelationShip = relationShip;
        }

        public void ShowRelationShip(Person_Class person1, Person_Class person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationShip}\n");
        }
    }
}


