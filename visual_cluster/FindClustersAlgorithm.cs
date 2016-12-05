using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_cluster
{
    class FindClustersAlgorithm
    {
        public int[,] grid;
        public int[] labels;
        public int total_clusters = 0;

        public FindClustersAlgorithm(int size, double probability)
        {
            this.grid = new int[size, size];
            this.labels = new int[size * size / 2];

            Random randObj = new Random();

            //this.grid = new int[,]
            //{
            //    {1, 1, 1, 0, 0},
            //    {1, 1, 0, 0, 0},
            //    {0, 1, 0, 1, 1},
            //    {0, 0, 0, 1, 0},
            //    {0, 1, 1, 0, 1}
            //};

            for (int i = 0; i < this.grid.GetLength(0); i++)
                for (int j = 0; j < this.grid.GetLength(1); j++)
                    this.grid[i, j] = (randObj.NextDouble() < probability) ? 1 : 0;
        }

        public int SetNewCluster()
        {
            this.labels[0]++;

            // TODO:  if(this.labels[0] < this.labels.Length)

            this.labels[labels[0]] = this.labels[0];
            return this.labels[0];
        }

        public int FindRoot(int x)
        {
            if (this.labels[x] == x) return x;
            return this.labels[x] = FindRoot(this.labels[x]);

            //int y = x;
            //while (this.labels[y] != y)
            //    y = this.labels[y];

            //while (this.labels[x] != x)
            //{
            //    int z = this.labels[x];
            //    this.labels[x] = y;
            //    x = z;
            //}
            //return y;
        }

        public int Union(int x, int y)
        {
            int xRoot = this.FindRoot(x);
            int yRoot= this.FindRoot(y);

            // random root of new union tree
            if (new Random().Next() % 2 == 0)
                return this.labels[yRoot] = xRoot;

            return this.labels[xRoot] = yRoot;
        }

        public void HoshenKopelmanAlgorithm()
        {
            for (int i = 0; i < this.grid.GetLength(0); i++)
                for (int j = 0; j < this.grid.GetLength(1); j++)
                    if (this.grid[i, j] != 0)
                    {
                        int up = (i == 0 ? 0 : this.grid[i - 1, j]);
                        int left = (j == 0 ? 0 : this.grid[i, j - 1]);

                        if (left == 0 && up == 0)
                        {
                            this.grid[i, j] = this.SetNewCluster();
                        }
                        else if (left != 0 && up == 0 || left == 0 && up != 0 )
                        {
                            this.grid[i, j] = Math.Max(up, left);
                        }
                        else
                        {
                            this.grid[i, j] = this.Union(up, left);
                        }               

                        //switch (up + left)
                        //{
                        //    case 0:
                        //        this.grid[i, j] = this.SetNewCluster();
                        //        break;
                        //    case 1:
                        //        this.grid[i, j] = Math.Max(up, left);
                        //        break;
                        //    case 2:
                        //        this.grid[i, j] = this.Union(up, left);
                        //        break;
                        //}

                    }

            int[] new_labels = new int[this.labels.Length];

            for (int i = 0; i < this.grid.GetLength(0); i++)
                for (int j = 0; j < this.grid.GetLength(1); j++)
                    if (this.grid[i, j] != 0)
                    {
                        int x = this.FindRoot(this.grid[i, j]);
                        if (new_labels[x] == 0)
                        {
                            new_labels[0]++;
                            new_labels[x] = new_labels[0];
                        }
                        this.grid[i, j] = new_labels[x];
                    }

            this.total_clusters = new_labels[0];
        }

    }
}
