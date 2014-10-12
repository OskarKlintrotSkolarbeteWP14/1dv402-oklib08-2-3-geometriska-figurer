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
        static Shape[] RandomizeShapes()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }


        #endregion
    }
}
