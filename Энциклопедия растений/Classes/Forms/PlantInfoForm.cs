using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Энциклопедия_растений.Properties;

namespace Энциклопедия_растений
{
    public partial class PlantInfoForm : Form
    {
        public PlantInfoForm(Plant plant)
        {
            InitializeComponent();
            groupBox.Text += $" ({plant.Name})";
            for (int i = 0; i < Encyclopedia.GetCharacteristics(169).Count; i++)
            {
                Panel block = new Panel
                {
                    Parent = panelChars,
                    Height = 26,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Label label = new Label
                {
                    Parent = block,
                    AutoSize = false,
                    Width = 284,
                    Dock = DockStyle.Left,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204)
                };
                if (plant.Contents[i] == null)
                {
                    label.Text = $"{Encyclopedia.GetCharacteristics(169)[i].Name} - <Не указано>";
                }
                else
                {
                    label.Text = $"{Encyclopedia.GetCharacteristics(169)[i].Name} - {plant.Contents[i]}";
                    if (plant.Contents[i].ToString() == "True") label.Text = $"{Encyclopedia.GetCharacteristics(169)[i].Name} - Да";
                    if (plant.Contents[i].ToString() == "False") label.Text = $"{Encyclopedia.GetCharacteristics(169)[i].Name} - Нет";
                }
                Button button = new Button
                {
                    Parent = block,
                    Dock = DockStyle.Right,
                    Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204),
                    Width = 46,
                    Text = "ещё",
                    FlatStyle = FlatStyle.Flat,
                };
                button.FlatAppearance.BorderSize = 0;
                button.BringToFront();
                button.Click += (sender2, e2) => MessageBox.Show(label.Text);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
