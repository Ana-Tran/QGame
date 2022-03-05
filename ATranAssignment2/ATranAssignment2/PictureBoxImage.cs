/*PictureBoxImage.cs
 * Assignment 2
 *  Revision History
 *   Ana Tran, November 08,2020: Created
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATranAssignment2
{
    /// <summary>
    /// Class to inherit the picture box object
    /// </summary>
    class PictureBoxImage : PictureBox
    {
        private Image images;
        public Image Images { get => images; set => images = value; }
    }
}
