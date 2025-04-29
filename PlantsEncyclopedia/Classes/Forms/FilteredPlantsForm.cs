using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlantsEncyclopedia
{
    public partial class FilteredPlantsForm : Form
    {
        List<Plant> plants = new List<Plant>();
        public FilteredPlantsForm(Filter filter)
        {
            InitializeComponent();
            plants = filter.GetResults(Encyclopedia.GetPlants(169));
        }

        private void FilteredPlantsForm_Load(object sender, EventArgs e)
        {
            if (plants.Count == 0)
            {
                MessageBox.Show("Ни одно растение не подходит под фильтр.");
                Close();
            }
            foreach (var plant in plants)
            {
                PlantControl plantControl = new PlantControl(this, plant);
                Width = plants.Count * 330;
            }
            if (plants.Count == 1)
            {
                pictureBoxCross.Location = new Point(316, 0);
            }
            if (plants.Count >= 2)
            {
                pictureBoxCross.Location = new Point(646, 0);
            }
            Controls[Controls.Count - 1].Focus();
            CenterToParent();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void FilteredPlantsForm_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBoxCross.Location = new Point(646, 0);
        }
    }
}
