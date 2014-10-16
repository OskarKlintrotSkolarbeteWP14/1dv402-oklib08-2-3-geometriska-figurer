using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Program
    {
        #region Methods

        /// <summary>
        /// Metoden Main ska anropa metoden RandomizeShape() för att slumpa 
        /// figurer. Figurerna ska därefter sorteras varefter metoden ViewShapes() 
        /// anropas för att presentera figurerna. 
        /// 
        /// Efter att figurerna presenterats ska användaren kunna välja att avsluta 
        /// applikationen genom att trycka på Escape-tangenten; annan tangent ska 
        /// slumpa och presentera nya figurer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConsoleKeyInfo escp;

            do
            {
                Shape[] ShapeArray = RandomizeShapes();

                Array.Sort(ShapeArray);

                ViewShapes(ShapeArray);

                Console.WriteLine("Tryck esc för att avsluta, annan tangent för att försöka igen.");
                escp = Console.ReadKey(); 
            } while (escp.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Den privata statiska metoden RandomizeShapes() ska slumpa mellan 
        /// 5 och 20 figurer vars längder och bredder slumpas till värden av typen 
        /// double i det halvöppna intervallet mellan 5,0 och 100,0 ([5, 100[).
        /// 
        /// Typ av figur ska också slumpas och då måste en ”switch”-sats användas 
        /// tillsammans med uppräkningsbara typen ShapeType, som ska användas för att 
        /// typomvandla heltalet 0 till ShapeType.Ellips och heltalet 1 till 
        /// ShapeType.Rectangle.
        /// 
        /// Referenserna till figurerna ska sparas i en array som metoden returnerar 
        /// en referens till.
        /// </summary>
        /// <returns></returns>
        private static Shape[] RandomizeShapes()
        {
            Random randomNumber = new Random();
            int numberOfShapes = randomNumber.Next(5, 20);
            Shape[] shapes = new Shape[numberOfShapes];

            for (int i = 0; i < numberOfShapes; i++)
            {
                double lenght = randomNumber.Next(5, 100);
                double width = randomNumber.Next(5, 100);
                int typeOfShape = randomNumber.Next(0, 2);

                switch ((ShapeType)typeOfShape)
                {
                    case ShapeType.Ellipse:
                        shapes[i] = new Ellipse(lenght, width);
                        break;
                    case ShapeType.Rectangle:
                        shapes[i] = new Rectangle(lenght, width);
                        break;
                }
            }
            return shapes;
        }

        /// <summary>
        /// Den privata statiska metoden ViewShapes() ska presentera figurerna som 
        /// skickas till metoden i en enkel tabell. Metoden måste se till en figurs 
        /// detaljer presenteras genom att använda textbeskrivningen för varje objekt, 
        /// d.v.s. ToString() måste användas då ett objekts detaljer ska presenteras.
        /// </summary>
        /// <param name="shapes"></param>
        static void ViewShapes(Shape[] shapes)
        {
            Console.Clear();
            Console.WriteLine("{0}{1, 10}{2, 10}{3, 10}{4, 10}", "Figur".PadRight(10), "Längd", "Bredd", "Omkrets", "Area");
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.ToString());
            }
        }


        #endregion
    }
}
