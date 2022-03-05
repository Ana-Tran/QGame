/*QGameDesignForm.cs
 * Assignment 2
 *  Revision History
 *   Ana Tran, November 08,2020: Created
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ATranAssignment2
{
    /// <summary>
    /// Form with picture box features
    /// </summary>
    public partial class QGameDesignForm : Form
    {
        // Constants
        private const int WIDTH = 80;
        private const int HEIGHT = 80;
        private const int VGAP = 3;
        private const int HGAP = 3;
        private const int START_NUMBER = 15;
        private const int INCREASE_INDEX = 3;

        //Global variables
        private PictureBox generatedGrid;
        private string activeTool;
        private int userInputRow;
        private int userInputColumn;
        private List<int> storedValues = new List<int>();
        private int cellTypeIndex = 2;
        private int doorCounters = 0;
        private int playerCounters = 0;
        private int wallCounter = 0;

        //Assign images
        Image none = Properties.Resources.none;
        Image wall = Properties.Resources.wall;
        Image bunnyDoor = Properties.Resources.BunnyDoor;
        Image chickDoor = Properties.Resources.ChickDoor;
        Image bunny = Properties.Resources.BunnyBox;
        Image chick = Properties.Resources.ChickBox;

        /// <summary>
        /// A datatype that can be used to assign values to images
        /// </summary>
        [Flags]
        enum TypesOfImages
        {
            None,
            Wall,
            BDoor,
            CDoor,
            Bunny,
            Chick
        }

        /// <summary>
        /// Default constructor of the class
        /// </summary>
        public QGameDesignForm()
        {
            InitializeComponent();
            none.Tag = TypesOfImages.None;
            wall.Tag = TypesOfImages.Wall;
            bunnyDoor.Tag = TypesOfImages.BDoor;
            chickDoor.Tag = TypesOfImages.CDoor;
            bunny.Tag = TypesOfImages.Bunny;
            chick.Tag = TypesOfImages.Chick;

            btnNone.Click += selectedTool;
            btnWall.Click += selectedTool;
            btnBDoor.Click += selectedTool;
            btnCDoor.Click += selectedTool;
            btnBunny.Click += selectedTool;
            btnChick.Click += selectedTool;
        }
        /// <summary>
        /// Generate a picture box grid based on user input of rows and columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                userInputRow = int.Parse(txtRow.Text);
                try
                {
                    userInputColumn = int.Parse(txtColumn.Text);
                    int startX = START_NUMBER;
                    int startY = START_NUMBER;
                    for (int rows = 1; rows <= userInputRow; rows++)
                    {
                        for (int columns = 1; columns <= userInputColumn; columns++)
                        {
                            //Dimensions of the pictureboxes
                            generatedGrid = new PictureBox();
                            generatedGrid.Left = startX;
                            generatedGrid.Top += startY;
                            generatedGrid.Width = WIDTH;
                            generatedGrid.Height = HEIGHT;

                            //Style of pictureboxes
                            generatedGrid.Image = none;
                            generatedGrid.SizeMode = PictureBoxSizeMode.StretchImage;
                            generatedGrid.BorderStyle = BorderStyle.FixedSingle;

                            //Adding pictureboxes
                            pnlMainBoard.Controls.Add(generatedGrid);
                            generatedGrid.Tag = none.Tag;
                            generatedGrid.Click += displayImage;
                            startX += WIDTH + HGAP;
                        }
                        startY += HEIGHT + VGAP;
                        startX = START_NUMBER;
                        btnGenerate.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in column input: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in row input: " + ex.Message);
            }
        }

        /// <summary>
        /// Display the image on the picturebox based on tool selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayImage(object sender, EventArgs e)
        {
            generatedGrid = (PictureBox)sender;

            if (activeTool == "None")
            {
                generatedGrid.Image = none;
                generatedGrid.Tag = none.Tag;
            }
            else if (activeTool == "Wall")
            {
                generatedGrid.Image = wall;
                generatedGrid.Tag = wall.Tag;
            }
            else if (activeTool == "BDoor")
            {
                generatedGrid.Image = bunnyDoor;
                generatedGrid.Tag = bunnyDoor.Tag;
            }
            else if (activeTool == "CDoor")
            {
                generatedGrid.Image = chickDoor;
                generatedGrid.Tag = chickDoor.Tag;
            }
            else if (activeTool == "Bunny")
            {
                generatedGrid.Image = bunny;
                generatedGrid.Tag = bunny.Tag;
            }
            else if (activeTool == "Chick")
            {
                generatedGrid.Image = chick;
                generatedGrid.Tag = chick.Tag;
            }
        }
        /// <summary>
        /// Store the value of the user selected tool from the toolbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void selectedTool(object sender, EventArgs e)
        {
            Button tool = new Button();
            tool = (Button)sender;
            if (tool.Name == "btnNone")
            {
                activeTool = "None";
            }
            else if (tool.Name == "btnWall")
            {
                activeTool = "Wall";
            }
            else if (tool.Name == "btnBDoor")
            {
                activeTool = "BDoor";
            }
            else if (tool.Name == "btnCDoor")
            {
                activeTool = "CDoor";
            }
            else if (tool.Name == "btnBunny")
            {
                activeTool = "Bunny";
            }
            else if (tool.Name == "btnChick")
            {
                activeTool = "Chick";
            }
        }

        /// <summary>
        /// Saves the list from the saveList method to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    saveList(generatedGrid);
                    try
                    {
                        using (StreamWriter writeToFile = new StreamWriter(save.FileName, false))
                        {
                            writeToFile.WriteLine(userInputRow);
                            writeToFile.WriteLine(userInputColumn);
                            foreach (int item in storedValues)
                            {
                                writeToFile.WriteLine(item);
                            }
                        }
                        MessageBox.Show($"File saved.\n" +
                         $"Total Number of Walls: {wallCounter}\n" +
                         $"Total Number of Doors: {doorCounters}\n" +
                         $"Total Number of Bunnys/Chicks: {playerCounters}", "QGameDesignForm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occured with the file " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured with saving " + ex.Message);
            }

        }

        /// <summary>
        /// Add the pictureboxes location and the associated images to a list
        /// </summary>
        /// <param name="pictureBox"></param>
        private void saveList(PictureBox pictureBox)
        {
            try
            {
                for (int rows = 1; rows <= userInputRow; rows++)
                {
                    for (int columns = 1; columns <= userInputColumn; columns++)
                    {
                        storedValues.Add(rows);
                        storedValues.Add(columns);
                    }
                }
                foreach (PictureBox images in pnlMainBoard.Controls)
                {
                    if (images.Tag == none.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                    }
                    else if (images.Tag == wall.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                        wallCounter++;
                    }
                    else if (images.Tag == bunnyDoor.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                        doorCounters++;
                    }
                    else if (images.Tag == chickDoor.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                        doorCounters++;
                    }
                    else if (images.Tag == bunny.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                        playerCounters++;
                    }
                    else if (images.Tag == chick.Tag)
                    {
                        storedValues.Insert(cellTypeIndex, (int)images.Tag);
                        cellTypeIndex += INCREASE_INDEX;
                        playerCounters++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occured: " + ex.Message);
            }
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
