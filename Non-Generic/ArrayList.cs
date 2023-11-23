using System;
//Non generic Class
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Non_Generic
{
    //Properties
    //1)Elements can be added and removed from the Array List Collection at any point in time.
    //2)Capacity of an ArrayList is the number of elements the ArrayList can hold.  
    public class ArrayListDemo
    {
        public void getNonGeneric()
        {
            ArrayList valueOne = new ArrayList();
            ArrayList valueTwo = new ArrayList();
            //Adding Values to decalred ArrayList
            valueOne.Add(1);
            valueOne.Add(2);
            valueOne.Add(3);
            valueOne.Add(4);
            valueOne.Add(5);
            valueOne.Add(6);
            valueOne.Add(7);
            valueOne.Add(8);
            valueOne.Add(9);

            valueTwo.Add("Joy");
            valueTwo.Add("Julia");
            valueTwo.Add("Jane");

            //Insert a collection inside another collections
            valueOne.InsertRange(valueOne.Count, valueTwo);
            //CHeck capacity
            Console.WriteLine(valueOne.Capacity);
            //access arrayList
            Console.WriteLine(valueOne[4]);
            //iterating over an ArrayList using foreach method
   
            //Insert in a specific index
            valueOne.Insert(3, 100);
            //check length of ArrayList
            /*         Console.WriteLine($"The ArrayList Length is {valueOne.Count}");
                     valueOne.Insert(valueOne.Count, 1000);
                     Console.WriteLine(valueOne);*/

            /*   Remove from ArrayList*/
            valueOne.Remove("Jane");
            /*   Remove at specific place from ArrayList*/
            Console.WriteLine(valueTwo.Contains("sam"));
            Console.WriteLine(valueTwo.Contains(2));
            valueOne.RemoveAt(0);

            foreach (var item in valueOne)
            {
                Console.WriteLine(item);
            }

        }
    }
}
