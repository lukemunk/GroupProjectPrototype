using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Classes
{
    class Item
    {
        #region
        /// <summary>
        /// Holds the name of the item
        /// </summary>
        public string ItemDesc { get; set; }
        /// <summary>
        /// Holds the single character item code
        /// </summary>
        public char ItemCode { get; set; }
        /// <summary>
        /// Holds the cost of the item
        /// </summary>
        public double Cost { get; set; }
        #endregion
    }
}
