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

        public void PrintGrid(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    this.textBox3.AppendText(grid[i, j].ToString() + "\t");
                }
                this.textBox3.AppendText("\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
            int gridSize = Convert.ToInt32(this.textBox1.Text);
            double probability = Convert.ToDouble(this.textBox2.Text);

            FindClustersAlgorithm findObj = new FindClustersAlgorithm(gridSize, probability);

            this.PrintGrid(findObj.grid);

            findObj.HoshenKopelmanAlgorithm();

            this.textBox3.AppendText("\r\n");
            this.PrintGrid(findObj.grid);

            this.textBox3.AppendText("\r\nTotal of found clusters: " + findObj.total_clusters.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }
    }
}
