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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintGrid(int[,] grid, string markCluster = "")
        {
            this.richTextBox1.AppendText("\r\n");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    // TODO: different colors

                    if (markCluster == grid[i, j].ToString())
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
        }

        public int FindPercolationClusters(FindClustersAlgorithm obj)
        {
            int percolationClustersTotal = 0;
            int[] foundClusters = new int[obj.grid.GetLength(0)];

            for (int i = 0; i < obj.grid.GetLength(0); i++)
                for (int j = 0; j < obj.grid.GetLength(0); j++)
                {
                    if (obj.grid[0, i] != 0 && foundClusters[obj.grid[0, i]] == 0 && obj.grid[0, i] == obj.grid[obj.grid.GetLength(1) - 1, j])
                    {
                        this.PrintGrid(obj.grid, obj.grid[0, i].ToString());
                        foundClusters[obj.grid[0, i]]++;
                        percolationClustersTotal++;
                        break;
                    }
                }

            return percolationClustersTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();

            // TODO: validate input

            int gridSize = Convert.ToInt32(this.textBox1.Text);
            double probability = Convert.ToDouble(this.textBox2.Text);

            FindClustersAlgorithm findObj = new FindClustersAlgorithm(gridSize, probability);
            this.PrintGrid(findObj.grid);
            findObj.HoshenKopelmanAlgorithm();
            int totalClusters = findObj.RelabledGrid();       
            int percolationClusters = this.FindPercolationClusters(findObj);

            this.richTextBox1.AppendText("\r\n");
            this.richTextBox1.AppendText("\r\nTotal found clusters: " + totalClusters.ToString());
            this.richTextBox1.AppendText("\r\nPercolation found clusters: " + percolationClusters.ToString());          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }
    }
}
