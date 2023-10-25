using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheExit
{
    /// <summary>
    /// Represents a point.
    /// </summary>
    class Point
    {
        /// <summary>
        /// Gets or sets the row of the point.
        /// </summary>
        public int Row
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the column of the point.
        /// </summary>
        public int Column
        {
            get; set;
        }

        /// <summary>
        /// Initializes an instance of Point with the specified row and column.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public Point(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Returns a custom string representation of an instance of Point.
        /// </summary>
        /// <returns>The custom string representation.</returns>
        public override string ToString()
        {
            return String.Format("[{0}, {1}]", Row, Column);
        }
    }
}
