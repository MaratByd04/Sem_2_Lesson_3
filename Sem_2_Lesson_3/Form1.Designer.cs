namespace Sem_2_Lesson_3
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Кличка");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Возраст");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Прививки");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Масть");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Скорость");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Гоночная лошадь", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Кличка");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Возраст");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Прививки");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Масть");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Здоровье");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Рабочая лошадь", new System.Windows.Forms.TreeNode[] { treeNode7, treeNode8, treeNode9, treeNode10, treeNode11 });
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Кличка");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Возраст");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Прививки");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Масть");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Титул");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Выставочная лошадь", new System.Windows.Forms.TreeNode[] { treeNode13, treeNode14, treeNode15, treeNode16, treeNode17 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addInfoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 121);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Кличка";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Возраст";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Прививки";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Масть";
            treeNode5.Name = "Узел15";
            treeNode5.Text = "Скорость";
            treeNode6.Name = "RaceHorse";
            treeNode6.Text = "Гоночная лошадь";
            treeNode7.Name = "Узел7";
            treeNode7.Text = "Кличка";
            treeNode8.Name = "Узел8";
            treeNode8.Text = "Возраст";
            treeNode9.Name = "Узел9";
            treeNode9.Text = "Прививки";
            treeNode10.Name = "Узел10";
            treeNode10.Text = "Масть";
            treeNode11.Name = "Узел16";
            treeNode11.Text = "Здоровье";
            treeNode12.Name = "WorkHorse";
            treeNode12.Text = "Рабочая лошадь";
            treeNode13.Name = "Узел11";
            treeNode13.Text = "Кличка";
            treeNode14.Name = "Узел12";
            treeNode14.Text = "Возраст";
            treeNode15.Name = "Узел13";
            treeNode15.Text = "Прививки";
            treeNode16.Name = "Узел14";
            treeNode16.Text = "Масть";
            treeNode17.Name = "Узел19";
            treeNode17.Text = "Титул";
            treeNode18.Name = "ShowHorse";
            treeNode18.Text = "Выставочная лошадь";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode6, treeNode12, treeNode18 });
            this.treeView1.Size = new System.Drawing.Size(176, 240);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.nameColumn, this.ageColumn, this.vaccineColumn, this.colorColumn, this.addInfoColumn });
            this.dataGridView1.Location = new System.Drawing.Point(173, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 255);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Кличка";
            this.nameColumn.Name = "nameColumn";
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Возраст";
            this.ageColumn.Name = "ageColumn";
            // 
            // vaccineColumn
            // 
            this.vaccineColumn.HeaderText = "Прививки";
            this.vaccineColumn.Name = "vaccineColumn";
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Масть";
            this.colorColumn.Name = "colorColumn";
            // 
            // addInfoColumn
            // 
            this.addInfoColumn.HeaderText = "Доп информация";
            this.addInfoColumn.Name = "addInfoColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addInfoColumn;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TreeView treeView1;

        #endregion
    }
}