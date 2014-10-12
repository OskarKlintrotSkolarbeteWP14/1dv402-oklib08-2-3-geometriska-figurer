﻿using System;
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
            get { return 0; }
        }

        /// <summary>
        /// Publik egenskapen av typen double som ska ge en ellips omkrets.
        /// </summary>
        public override double Perimeter
        {
            get { return 0; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Publik konstruktor som genom anrop av basklassens konstruktor 
        /// ser till att det nya objektets längd och bredd sätts.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Ellipse(double length, double width) : base(length, width)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
