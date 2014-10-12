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
            get { return 0; }
        }

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en rektangels omkrets.
        /// </summary>
        public override double Perimeter
        {
            get { return 0; }
        }

        #endregion

        #region Constructor


        public Rectangle(double length, double width) : base(length, width)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
