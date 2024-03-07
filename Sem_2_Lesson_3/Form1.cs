using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sem_2_Lesson_3
{
    public partial class Form1 : Form
    {
        private HorseManager horseManager;

        public Form1()
        {
            InitializeComponent();
            horseManager = new HorseManager();
        }

        private void PopulateDataGridView(List<Horse> horses)
        {
            dataGridView1.Rows.Clear();
            foreach (var horse in horses)
            {
                dataGridView1.Rows.Add(horse.Name, horse.Age, horse.Vaccinated, horse.Color);
            }
        }

        private void PopulateTreeView(List<Horse> horses)
        {
            treeView1.Nodes.Clear();
            foreach (var horse in horses)
            {
                TreeNode horseNode = new TreeNode(horse.Name);
                horseNode.Nodes.Add("Возраст: " + horse.Age);
                horseNode.Nodes.Add("Прививки: " + horse.Vaccinated);
                horseNode.Nodes.Add("Масть: " + horse.Color);
                treeView1.Nodes.Add(horseNode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Horse> horses = horseManager.LoadFromFile(openFileDialog.FileName);

                if (horses != null)
                {
                    PopulateDataGridView(horses);
                    PopulateTreeView(horses);
                }
            }
        }
    }
}