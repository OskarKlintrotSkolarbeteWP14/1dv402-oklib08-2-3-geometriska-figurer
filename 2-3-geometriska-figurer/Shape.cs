using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    abstract class Shape
    {
        #region Fields

        /// <summary>
        /// Privat fält av typen double representerande en figurs längd.
        /// </summary>
        private double _lenght;

        /// <summary>
        /// Privat fält av typen double representerande en figurs bredd.
        /// </summary>
        private double _width;

        #endregion

        #region Properties

        /// <summary>
        /// Publik abstrakt egenskap av typen double representerande en figurs area. 
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Publik egenskap av typen double som kapslar in fältet _length.
        /// 
        /// set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte 
        /// större än 0 ska ett undantag av typen ArgumentException kastas.
        /// </summary>
        public double Length
        {

            get { return _lenght; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(Error.Error_Lenght, value));
                }
                _lenght = value;
            }
        }

        /// <summary>
        /// Publik abstrakt egenskap av typen double representerande en figurs omkrets.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Publik egenskap av typen double som kapslar in fältet _width. 
        /// 
        /// set-metoden ska validera värdet som tilldelas egenskapen. Är värdet inte 
        /// större än 0 ska ett undantag av typen ArgumentException kastas.
        /// </summary>
        public double Width {

            get { return _width; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(Error.Error_Width, value));
                }
                _width = value;
            } 
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Konstruktorn, som ska vara ”protected”, ansvara för att fälten, via 
        /// egenskaperna, tilldelas de värden konstruktorns parametrar har.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        protected Shape( double length, double width)
        {
            Length = length;
            Width = width;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metoden ska jämföra två objekt med avseende på deras areor. 
        /// 
        ///     • Refererar parametern till null ska ett heltal större än 0 returneras. 
        ///     
        ///     • Refererar parametern till ett objekt som inte är av typen Shape ska ett 
        ///       undantag av typen ArgumentException kastas. 
        ///       
        ///     • Refererar parametern till ett objekt vars area är större än det anropande 
        ///       objektet ska ett heltal mindre än 0 returneras. 
        ///       
        ///     • Refererar parametern till ett objekt vars area är mindre än det anropande 
        ///       objektet ska ett heltal större än 0 returneras.
        ///       
        ///     • Refererar parametern till ett objekt vars area är lika med det anropande 
        ///       objektet ska heltalet 0 returneras.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Publik metod som överskuggar metoden ToString() i basklassen Object. Metoden ska 
        /// returnera en sträng representerande värdet av en instans. Strängen ska vara lite 
        /// speciellt formaterad och innehålla figurens typ och värden för läng, bredd, 
        /// omkrets och area. Värdena ska vara högerjusterade med lämpliga fältbredder. 
        /// Figurens typ ges av metoden GetType(), som ärvs från klassen Object, och 
        /// egenskapen Name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}{1, 10:F1}{2, 10:F1}{3, 10:F1}{4, 10:F1}", 
                GetType().Name.PadRight(10), Length, Width, Perimeter, Area);
        }

        #endregion
    }

    /// <summary>
    /// Den uppräkningsbara typen ShapeType används för att definiera vilka typer 
    /// av figurer applikationen kan hantera. Typen används då metoden RandomizeShapes() 
    /// slumpar vilken typ av figur som ska skapas. 
    /// 
    /// Typen definieras lämpligen i filen Shape.cs, men då utanför klassdefinitionen 
    /// så att den inte blir en del av typen Shape.
    /// </summary>
    enum ShapeType { Ellipse, Rectangle };

}
