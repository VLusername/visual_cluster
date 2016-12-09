using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_cluster
{
    public partial class clusterForm : Form
    {
        private Graphics paintBox;

        private FindClustersAlgorithm findClustersObj;
        private FindClustersAlgorithm3D findClustersObj3D;

        private List<int> percolationClusters;

        public clusterForm()
        {
            InitializeComponent();
            fillButton.Enabled = false;
            clearButton.Enabled = false;
        }

        public void PrintGrid(string clusterColorMark = "")
        {
            int[,] grid = this.findClustersObj.grid;
            this.richTextBox1.AppendText("\r\n");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    // TODO: different colors

                    if (clusterColorMark == grid[i, j].ToString())
                    {
                        this.richTextBox1.AppendText(grid[i, j].ToString() + "\t", Color.Blue);
                    }
                    else
                    {
                        this.richTextBox1.AppendText(grid[i, j].ToString() + "\t");
                    }
                }
                this.richTextBox1.AppendText("\r\n");
            }
            this.richTextBox1.AppendText("\r\n");
        }

        public void Print3DGrid(string clusterColorMark = "")
        {
            int[,,] grid = this.findClustersObj3D.threeDgrid;
            this.richTextBox1.AppendText("\r\n");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    for (int k = 0; k < grid.GetLength(2); k++)
                    {
                        // TODO: different colors

                        if (clusterColorMark == grid[i, j, k].ToString())
                        {
                            this.richTextBox1.AppendText(grid[i, j, k].ToString() + "\t", Color.Blue);
                        }
                        else
                        {
                            this.richTextBox1.AppendText(grid[i, j, k].ToString() + "\t");
                        }
                    }
                    this.richTextBox1.AppendText("\r\n");
                }
                this.richTextBox1.AppendText("\r\n");
            }
            this.richTextBox1.AppendText("\r\n");
        }  

        private void DrawGrid()
        {
            int[,] grid = this.findClustersObj.grid;

            SolidBrush squareBrush = new SolidBrush(Color.Black);
            Rectangle cellRect = new Rectangle(0, 0, 0, 0);
            this.paintBox = this.pictureBox1.CreateGraphics();
            this.paintBox.Clear(Color.FromArgb(224, 224, 224));

            int squareSizeX = (int)(this.pictureBox1.Width / grid.GetLength(0));
            int squareSizeY = (int)(this.pictureBox1.Height / grid.GetLength(1));

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] != 0)
                        squareBrush = new SolidBrush(Color.White);

                    cellRect = new Rectangle(0 + j * squareSizeX, 0 + i * squareSizeY, squareSizeX - 1, squareSizeY - 1);
                    this.paintBox.FillRectangle(squareBrush, cellRect);

                    if (this.checkShowNumbers.Checked)
                        using (Font cellFont = new Font("Jing Jing", (int)(14 * squareSizeX / 35), FontStyle.Regular, GraphicsUnit.Point))
                        {
                            StringFormat textFormat = new StringFormat();
                            textFormat.Alignment = StringAlignment.Center;
                            textFormat.LineAlignment = StringAlignment.Center;

                            this.paintBox.DrawString(grid[i, j].ToString(), cellFont, Brushes.Black, cellRect, textFormat);
                        }
                    squareBrush = new SolidBrush(Color.Black);
                }
                if (this.checkSlowMotion.Checked)
                    System.Threading.Thread.Sleep(50);
            }
            squareBrush.Dispose();
            this.paintBox.Dispose();       
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            int[,] grid = this.findClustersObj.grid;

            this.paintBox = this.pictureBox1.CreateGraphics();
            SolidBrush squareBrush = new SolidBrush(Color.CornflowerBlue);
            Rectangle cellRect = new Rectangle(0, 0, 0, 0);

            int squareSizeX = (int)(this.pictureBox1.Width / grid.GetLength(0));
            int squareSizeY = (int)(this.pictureBox1.Height / grid.GetLength(1));

            int filledRowCells = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                filledRowCells = 0;
                for (int j = 0; j < grid.GetLength(1); j++)
                    for (int k = 0; k < grid.GetLength(1); k++)
                        if (grid[0, k] != 0)
                            if (grid[i, j] == grid[0, k])
                            {
                                filledRowCells++;
                                cellRect = new Rectangle(0 + j * squareSizeX, 0 + i * squareSizeY, squareSizeX - 1, squareSizeY - 1);
                                this.paintBox.FillRectangle(squareBrush, cellRect);

                                if (this.checkShowNumbers.Checked)
                                    using (Font cellFont = new Font("Jing Jing", (int)(14 * squareSizeX / 35), FontStyle.Regular, GraphicsUnit.Point))
                                    {
                                        StringFormat textFormat = new StringFormat();
                                        textFormat.Alignment = StringAlignment.Center;
                                        textFormat.LineAlignment = StringAlignment.Center;

                                        this.paintBox.DrawString(grid[i, j].ToString(), cellFont, Brushes.Black, cellRect, textFormat);
                                    }
                            }
                System.Threading.Thread.Sleep(50);

                /**
                 * if entire row was not filled - stop filling
                 */
                if (filledRowCells == 0)
                    break;
            }          
            squareBrush.Dispose();
            this.paintBox.Dispose();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {          
            this.richTextBox1.Clear();
            fillButton.Enabled = true;
            clearButton.Enabled = true;

            // TODO: validate input

            int gridSize = Convert.ToInt32(this.gridSize.Text);
            double probability = Convert.ToDouble(this.probability.Text);

            //findClustersObj = new FindClustersAlgorithm(gridSize, probability);
            //findClustersObj.HoshenKopelmanAlgorithm();
            //int totalClusters = findClustersObj.RelabledGrid();
            //this.percolationClusters = findClustersObj.FindPercolationClusters();
            //findClustersObj.RelabledGrid();

            findClustersObj3D = new FindClustersAlgorithm3D(gridSize, probability);         
            findClustersObj3D.HoshenKopelmanAlgorithm3D();         
            
            this.Print3DGrid();

            findClustersObj3D.Relabled3DGrid();
            this.Print3DGrid();
            //this.richTextBox1.AppendText("\r\nСlusters total: " + totalClusters.ToString());
            //this.richTextBox1.AppendText("\r\nPercolation clusters");

            //// TODO: try reformat out with {x}

            //for (int i = 0; i < this.percolationClusters.Count; i++)
            //    if (this.percolationClusters[i] != 0)
            //        this.richTextBox1.AppendText(" #" + this.percolationClusters[i].ToString());

            //this.richTextBox1.AppendText(": " + this.percolationClusters.Count.ToString());

            //DrawGrid();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.paintBox = this.pictureBox1.CreateGraphics();
            this.paintBox.Clear(Color.FromArgb(224, 224, 224));
            this.paintBox.Dispose();
            fillButton.Enabled = false;
            clearButton.Enabled = false;
        }     
    }
}
