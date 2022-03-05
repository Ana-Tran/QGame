/*ControlPanelForm.cs
 * Assignment 2
 *  Revision History
 *   Ana Tran, November 08,2020: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATranAssignment2
{
    /// <summary>
    /// Form with button features
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exits the form when user hits exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Opens the QGameDesign form when the user hits the Design button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            QGameDesignForm q2 = new QGameDesignForm();
            q2.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            QGamePlayForm q3 = new QGamePlayForm();
            q3.Show();
        }
    }
}
