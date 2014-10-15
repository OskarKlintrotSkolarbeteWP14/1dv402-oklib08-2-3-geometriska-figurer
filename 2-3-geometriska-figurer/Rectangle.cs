using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Rectangle : Shape
    {
        #region Properties

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en rektangels area.
        /// </summary>
        public override double Area
        {
            get { return Length * Width; }
        }

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en rektangels omkrets.
        /// </summary>
        public override double Perimeter
        {
            get { return 2 * Length + 2 * Width; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Publik konstruktor som genom anrop av basklassens konstruktor ser till
        /// att det nya objektets längd och bredd sätts.
        /// </summary>
        /// <param name="length">Rektangelns längd</param>
        /// <param name="width">Rektangelns bredd</param>
        public Rectangle(double length, double width) : base(length, width)
        {
            Length = length;
            Width = width;
        }

        #endregion
    }
}
