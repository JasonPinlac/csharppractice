using System;


namespace ReferenceAndValueTypes
{

    public class Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }


    class Program
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = array1;

            Console.WriteLine("array1[0] = {0}", array1[0]);
            array2[0] = 9;

            Console.WriteLine("array1[0] = {0}, array2[0] = {1}", array1[0], array2[0]);

            int someNumber = 90;
            Console.WriteLine(someNumber);

            Increment(someNumber);
            Console.WriteLine(someNumber);

            Person person = new Person()
            {
                Age = 20,
                Name = "Jason Pinlac",
                Weight = 145
            };
            
            Console.WriteLine(person.Age);
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
