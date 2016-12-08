namespace visual_cluster
{
    partial class clusterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridSize = new System.Windows.Forms.TextBox();
            this.probability = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.checkShowNumbers = new System.Windows.Forms.CheckBox();
            this.checkSlowMotion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSize
            // 
            this.gridSize.Location = new System.Drawing.Point(16, 4);
            this.gridSize.Name = "gridSize";
            this.gridSize.Size = new System.Drawing.Size(73, 20);
            this.gridSize.TabIndex = 7;
            this.gridSize.Text = "10";
            // 
            // probability
            // 
            this.probability.Location = new System.Drawing.Point(16, 30);
            this.probability.Name = "probability";
            this.probability.Size = new System.Drawing.Size(73, 20);
            this.probability.TabIndex = 1;
            this.probability.Text = "0,57";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Jing Jing", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(15, 106);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(78, 32);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Draw";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grid (matrix) size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Probability (for initial state of the grid) [0.0, 1.0]";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Jing Jing", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(184, 106);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 32);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(380, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(454, 348);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(16, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fillButton
            // 
            this.fillButton.Font = new System.Drawing.Font("Jing Jing", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillButton.Location = new System.Drawing.Point(100, 106);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(78, 32);
            this.fillButton.TabIndex = 10;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // checkShowNumbers
            // 
            this.checkShowNumbers.AutoSize = true;
            this.checkShowNumbers.Location = new System.Drawing.Point(19, 57);
            this.checkShowNumbers.Name = "checkShowNumbers";
            this.checkShowNumbers.Size = new System.Drawing.Size(119, 17);
            this.checkShowNumbers.TabIndex = 11;
            this.checkShowNumbers.Text = "Show Cluster Count";
            this.checkShowNumbers.UseVisualStyleBackColor = true;
            // 
            // checkSlowMotion
            // 
            this.checkSlowMotion.AutoSize = true;
            this.checkSlowMotion.Checked = true;
            this.checkSlowMotion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSlowMotion.Location = new System.Drawing.Point(19, 84);
            this.checkSlowMotion.Name = "checkSlowMotion";
            this.checkSlowMotion.Size = new System.Drawing.Size(126, 17);
            this.checkSlowMotion.TabIndex = 12;
            this.checkSlowMotion.Text = "Slow Motion Drawing";
            this.checkSlowMotion.UseVisualStyleBackColor = true;
            // 
            // clusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(846, 504);
            this.Controls.Add(this.checkSlowMotion);
            this.Controls.Add(this.checkShowNumbers);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.probability);
            this.Controls.Add(this.gridSize);
            this.Name = "clusterForm";
            this.Text = "Visualization of percolation cluster formation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gridSize;
        private System.Windows.Forms.TextBox probability;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.CheckBox checkShowNumbers;
        private System.Windows.Forms.CheckBox checkSlowMotion;
    }
}

