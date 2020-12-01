using System;
using System.Collections.Generic;

namespace Ö._7
{

    class Fastigheter
    {
        private string name;
        private string housingType;
        private string formOfHousing;
        private int rooms;
        private int sqm;
        private int floors;

        public Fastigheter(string name, string housingType, string formOfHousing, int rooms, int sqm, int floors)
        {
            this.name = name;
            this.housingType = housingType;
            this.formOfHousing = formOfHousing;
            this.rooms = rooms;
            this.sqm = sqm;
            this.floors = floors;

        }

        public void FullDescribeConsole()
        {

            Console.WriteLine("Bostadstyp: {0}, Bostadsform: {1}, Rum: {2}, kvm: {3}, våningar: {4}", housingType, formOfHousing, rooms, sqm, floors);

        }

        public void NameDescribeConsole()
        {
            Console.WriteLine("Namn: {0}", name);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            Fastigheter radhus = new Fastigheter("Supersonic", "Radhus", "Bostadsrätt", 4, 70, 0);
            Fastigheter villa = new Fastigheter("Time of the Season", "Villa", "Bostadsrätt", 8, 170, 3);
            Fastigheter lägenhetskomplex = new Fastigheter("60 years", "Fastighetskomplex", "Hyresrätt", 24, 400, 5);

            List<Fastigheter> aList = new List<Fastigheter>() { radhus, villa, lägenhetskomplex };

            Console.WriteLine("Hej, du har {0} fastigheter i din ägo ", aList.Count);

            Console.WriteLine("Vilken vill du få fullständig information om?" + "\n");

            foreach (Fastigheter f in aList)
            {
                f.NameDescribeConsole();
            }

            while (keepGoing)
            {

                Console.Write("\n" + "Skriv lägenhetens namn: ");

                string text;
                text = Console.ReadLine();
                bool wrongName = true;

                for (int i = 0; i < aList.Count; i++)
                {
                    Fastigheter temp;
                    temp = aList[i];

                    if (text.Equals(temp.Name))
                    {
                        temp.FullDescribeConsole();
                        wrongName = false;
                    }

                }

                if (wrongName)
                {
                    Console.WriteLine("Kunde inte hitta lägenheten, vänligen kontrollera om du skrev rätt namn. ");
                  
                }

            }












        }
    }
}


