using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Ellipse : Shape
    {
        #region Properties

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en ellips area.
        /// </summary>
        public override double Area
        {
            get { return Math.PI * (Length / 2 ) * (Width / 2); }
        }

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en ellips omkrets.
        /// </summary>
        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + (Width / 2) * (Width / 2)); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Publik konstruktor som genom anrop av basklassens konstruktor 
        /// ser till att det nya objektets längd och bredd sätts.
        /// </summary>
        /// <param name="length">Längden på ellipsen</param>
        /// <param name="width">Bredden på ellipsen</param>
        public Ellipse(double length, double width) : base(length, width)
        {
            Length = length;
            Width = width;
        }

        #endregion
    }
}
