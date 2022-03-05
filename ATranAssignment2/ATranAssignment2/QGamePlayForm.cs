/*QGamePlayForm.cs
 * Assignment 3
 *  Revision History
 *   Ana Tran, December 05,2020: Created
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ATranAssignment2
{
    /// <summary>
    /// Main for to run game
    /// </summary>
    public partial class QGamePlayForm : Form
    {
        #region Variables
        //Constants 
        private const int WIDTH = 60;
        private const int HEIGHT = 60;
        private const int VGAP = 3;
        private const int HGAP = 3;
        private const int START_NUMBER = 15;
        private const int START_INDEX = 0;
        private const int START = 1;
        private const int INTERVAL = 3;
        private const int RESET_COUNTER = 4;


        //Global variables
        private PictureBox generatedGrid;
        private PictureBox box;
        private int counter = 4;
        private bool selected = false;
        private string keyBoard;
        private int mrCounterMoves = 0;
        private int mrCounterBox = 0;

        //Variables for images
        Image none = Properties.Resources.none;
        Image wall = Properties.Resources.wall;
        Image bunnyDoor = Properties.Resources.BunnyDoor;
        Image chickDoor = Properties.Resources.ChickDoor;
        Image bunny = Properties.Resources.BunnyBox;
        Image chick = Properties.Resources.ChickBox; 
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public QGamePlayForm()
        {
            InitializeComponent();
        }

        #region Load Game
        /// <summary>
        /// Menu strip to load game map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            List<int> readStream = new List<int>();
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFile.FileName;
                    string readFile;
                    using (StreamReader read = new StreamReader(fileName))
                    {
                        while ((readFile = read.ReadLine()) != null)
                        {
                            readStream.Add(int.Parse(readFile));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured" + ex.Message);
            }
            resetGame();
            int startX = START_NUMBER;
            int startY = START_NUMBER;
            for (int rows = START; rows <= readStream[START_INDEX]; rows++)
            {
                for (int columns = START; columns <= readStream[START]; columns++)
                {
                    generatedGrid = new PictureBox();
                    generatedGrid.Left = startX;
                    generatedGrid.Top += startY;
                    generatedGrid.Width = WIDTH;
                    generatedGrid.Height = HEIGHT;
                    getImage(readStream);
                    generatedGrid.SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlGame.Controls.Add(generatedGrid);
                    startX += WIDTH + HGAP;
                }
                startY += HEIGHT + VGAP;
                startX = START_NUMBER;
            }
            txtMoves.Text = mrCounterMoves.ToString();
            txtRemainingBoxes.Text = mrCounterBox.ToString();
        }
        #endregion
        #region Display Images
        /// <summary>
        /// Loads associated image from file
        /// </summary>
        /// <param name="readStream"></param>
        private void getImage(List<int> readStream)
        {
            if (readStream[counter] == 0)
            {
                this.Controls.Remove(generatedGrid);
                counter += INTERVAL;
            }
            else if (readStream[counter] == 1)
            {
                generatedGrid.Image = wall;
                generatedGrid.BorderStyle = BorderStyle.FixedSingle;
                counter += INTERVAL;
            }
            else if (readStream[counter] == 2)
            {
                generatedGrid.Image = bunnyDoor;
                generatedGrid.BorderStyle = BorderStyle.FixedSingle;
                counter += INTERVAL;
            }
            else if (readStream[counter] == 3)
            {
                generatedGrid.Image = chickDoor;
                generatedGrid.BorderStyle = BorderStyle.FixedSingle;
                counter += INTERVAL;
            }
            else if (readStream[counter] == 4)
            {
                generatedGrid.Image = bunny;
                generatedGrid.BorderStyle = BorderStyle.FixedSingle;
                generatedGrid.Click += boxClick;
                counter += INTERVAL;
                mrCounterBox++;
            }
            else if (readStream[counter] == 5)
            {
                generatedGrid.Image = chick;
                generatedGrid.BorderStyle = BorderStyle.FixedSingle;
                generatedGrid.Click += boxClick;
                counter += INTERVAL;
                mrCounterBox++;
            }
        }
        #endregion
        #region Box Click
        /// <summary>
        /// Click event for boxes to show user which is selected box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxClick(object sender, EventArgs e)
        {
            foreach (PictureBox picturebox in pnlGame.Controls)
            {
                if (picturebox.Image == chick || picturebox.Image == bunny)
                {
                    picturebox.BackColor = Color.Transparent;
                }
            }
            box = (PictureBox)sender;
            selected = true;
            box.Padding = new System.Windows.Forms.Padding(all: 2);
            box.BackColor = Color.Magenta;
        }
        #endregion
        #region Move Up
        /// <summary>
        /// Moves selected box up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                MessageBox.Show("Please select a bunny or chick");
            }
            else
            {
                keyBoard = "up";
                mrCounterMoves++;
                txtMoves.Text = mrCounterMoves.ToString();
                while (canIStop(keyBoard) == false)
                {
                    box.BringToFront();
                    box.Top -= HEIGHT + VGAP;
                }
                winner(mrCounterBox);
            }

        }
        #endregion
        #region Move Right
        /// <summary>
        /// Moves selected box right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                MessageBox.Show("Please select a bunny or chick");
            }
            else
            {
                keyBoard = "right";
                mrCounterMoves++;
                txtMoves.Text = mrCounterMoves.ToString();
                while (canIStop(keyBoard) == false)
                {
                    box.BringToFront();
                    box.Left += WIDTH + HGAP;
                }
                winner(mrCounterBox);
            }
        }
        #endregion
        #region Move Left
        /// <summary>
        /// Moves selected box Left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                MessageBox.Show("Please select a bunny or chick");
            }
            else
            {
                keyBoard = "left";
                mrCounterMoves++;
                txtMoves.Text = mrCounterMoves.ToString();
                while (canIStop(keyBoard) == false)
                {
                    box.BringToFront();
                    box.Left -= WIDTH + HGAP;
                }
                winner(mrCounterBox);
            }
        }
        #endregion
        #region Move Down
        /// <summary>
        /// Moves selected box down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!selected)
            {
                MessageBox.Show("Please select a bunny or chick");
            }
            else
            {
                keyBoard = "down";
                mrCounterMoves++;
                txtMoves.Text = mrCounterMoves.ToString();
                while (canIStop(keyBoard) == false)
                {
                    box.BringToFront();
                    box.Top += HEIGHT + VGAP;
                }
                winner(mrCounterBox);
            }
        } 
        #endregion
        #region Stopping Method
        /// <summary>
        /// Method to check whether the selected box can continue to move
        /// </summary>
        /// <param name="selectedKey"></param>
        /// <returns></returns>
        private bool canIStop(string selectedKey)
        {
            bool stop = false;
            foreach (PictureBox picture in pnlGame.Controls)
            {
                if (selectedKey == "up")
                {
                    if (box.Top == (picture.Bottom + VGAP) && box.Left == picture.Left && picture.Image == wall)
                    {
                        stop = true;
                    }
                    else if (box.Top == (picture.Bottom + VGAP) && box.Left == picture.Left && picture.Image == bunnyDoor)
                    {
                        if (box.Image == bunny)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == chick)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Top == (picture.Bottom + VGAP) && box.Left == picture.Left && picture.Image == chickDoor)
                    {
                        if (box.Image == chick)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == bunny)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Top == (picture.Bottom + VGAP) && box.Left == picture.Left && (picture.Image == chick || picture.Image == bunny))
                    {
                        stop = true;
                    }
                }
                else if (selectedKey == "down")
                {
                    if (box.Bottom == (picture.Top - VGAP) && box.Left == picture.Left && picture.Image == wall)
                    {
                        stop = true;
                    }
                    else if (box.Bottom == (picture.Top - VGAP) && box.Left == picture.Left && picture.Image == bunnyDoor)
                    {
                        if (box.Image == bunny)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == chick)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Bottom == (picture.Top - VGAP) && box.Left == picture.Left && picture.Image == chickDoor)
                    {
                        if (box.Image == chick)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == bunny)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Bottom == (picture.Top - VGAP) && box.Left == picture.Left && (picture.Image == chick || picture.Image == bunny))
                    {
                        stop = true;
                    }
                }
                else if (selectedKey == "left")
                {
                    if (box.Left == (picture.Right + HGAP) && box.Top == picture.Top && picture.Image == wall)
                    {
                        stop = true;
                    }
                    else if (box.Left == (picture.Right + HGAP) && box.Top == picture.Top && picture.Image == bunnyDoor)
                    {
                        if (box.Image == bunny)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == chick)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Left == (picture.Right + HGAP) && box.Top == picture.Top && picture.Image == chickDoor)
                    {
                        if (box.Image == chick)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == bunny)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Left == (picture.Right + HGAP) && box.Top == picture.Top && (picture.Image == chick || picture.Image == bunny))
                    {
                        stop = true;
                    }
                }
                else if (selectedKey == "right")
                {
                    if (box.Right == (picture.Left - HGAP) && box.Top == picture.Top && picture.Image == wall)
                    {
                        stop = true;
                    }
                    else if (box.Right == (picture.Left - HGAP) && box.Top == picture.Top && picture.Image == bunnyDoor)
                    {
                        if (box.Image == bunny)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == chick)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Right == (picture.Left - HGAP) && box.Top == picture.Top && picture.Image == chickDoor)
                    {
                        if (box.Image == chick)
                        {
                            box.Dispose();
                            selected = false;
                            mrCounterBox--;
                            txtRemainingBoxes.Text = mrCounterBox.ToString();
                            stop = true;
                        }
                        else if (box.Image == bunny)
                        {
                            stop = true;
                        }
                    }
                    else if (box.Right == (picture.Left - HGAP) && box.Top == picture.Top && (picture.Image == chick || picture.Image == bunny))
                    {
                        stop = true;
                    }
                }
            }
            return stop;
        } 
        #endregion
        #region winner Method
        /// <summary>
        /// Method to check if there are no boxes remaining on map
        /// </summary>
        /// <param name="mrCounterBox"></param>
        private void winner(int mrCounterBox)
        {
            if (mrCounterBox == START_INDEX)
            {
                MessageBox.Show("Winner");
                pnlGame.Controls.Clear();
                mrCounterMoves = START_INDEX;
                selected = false;
                counter = RESET_COUNTER;
                txtMoves.Text = mrCounterMoves.ToString();
            }
        } 
        #endregion
        #region reset Method
        /// <summary>
        /// Method to reset game when user loads new map before finishing
        /// </summary>
        private void resetGame()
        {
            pnlGame.Controls.Clear();
            mrCounterMoves = START_INDEX;
            mrCounterBox = START_INDEX;
            selected = false;
            counter = RESET_COUNTER;
            txtMoves.Text = mrCounterMoves.ToString();
            txtRemainingBoxes.Text = mrCounterBox.ToString();
        }
        #endregion
        #region Close
        /// <summary>
        /// Close the play form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } 
        #endregion
    }
}