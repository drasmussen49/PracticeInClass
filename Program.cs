using System;

namespace PracticeInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = 4;
            int costPerPerson = 13;
            int totalBill = numberOfPeople * costPerPerson;
            Console.WriteLine(totalBill);
            if (totalBill >= 50)
            {
                double discount = totalBill * .1;
                Console.WriteLine(discount);
            }
        }
    }
}
