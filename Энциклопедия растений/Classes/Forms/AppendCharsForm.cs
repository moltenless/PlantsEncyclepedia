using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Энциклопедия_растений
{
    public partial class AppendCharsForm : Form
    {
        Characteristic characteristic;
        Plant plant;
        List<object> newContents;

        public AppendCharsForm(Characteristic characteristic)
        {
            InitializeComponent();

            this.characteristic = characteristic;
            plant = Encyclopedia.GetPlants(169)[0];
            newContents = new List<object>();

            labelPlantName.Text = plant.Name;
            pictureBoxImage.Image = plant.Images[0];
            labelCharName.Text = characteristic.Name;

            switch (characteristic.Type)
            {
                case ContentType.Text:
                    {
                        textBoxText.Visible = true;
                        textBoxText.Text = "<Не указано>";
                        textBoxText.Click += (sender2, e2) => { if (textBoxText.Text == "<Не указано>") textBoxText.SelectAll(); };
                        break;
                    }
                case ContentType.List:
                    {
                        comboBoxList.Visible = true;
                        foreach (var item in characteristic.List)
                            comboBoxList.Items.Add(item);
                        comboBoxList.Items.Add("<Не указано>");
                        comboBoxList.Text = "<Не указано>";
                        break;
                    }
                case ContentType.Bool:
                    {
                        comboBoxBool.Visible = true;
                        comboBoxBool.Items.Add("<Не указано>");
                        comboBoxBool.Text = "<Не указано>";
                        break;
                    }
            }
        }

        private void Next(object sender, EventArgs e)
        {
            switch (characteristic.Type)
            {
                case ContentType.Text:
                    {
                        string text = textBoxText.Text;
                        if (text == "<Не указано>")
                        {
                            newContents.Add(null);
                            GoNext();
                        }
                        else if (text.Length > 2 && text[0] != ' ' && text[text.Length - 1] != ' ')
                        {
                            newContents.Add(text);
                            GoNext();
                        }
                        else
                        {
                            MessageBox.Show("Внесите текст!");
                        }
                        break;
                    }
                case ContentType.List:
                    {
                        string element = comboBoxList.Text;
                        if (element == "<Не указано>")
                        {
                            newContents.Add(null);
                            GoNext();
                        }
                        else if (element != "")
                        {
                            newContents.Add(element);
                            GoNext();
                        }
                        else
                        {
                            MessageBox.Show("Выберите один из елементов выходящего списка!");
                        }
                        break;
                    }
                case ContentType.Bool:
                    {
                        if (comboBoxBool.Text == "<Не указано>")
                        {
                            newContents.Add(null);
                            GoNext();
                        }
                        else if (comboBoxBool.Text == "да")
                        {
                            newContents.Add(true);
                            GoNext();
                        }
                        else if (comboBoxBool.Text == "нет")
                        {
                            newContents.Add(false);
                            GoNext();
                        }
                        else
                        {
                            MessageBox.Show(@"Выберите ""ДА"" или ""НЕТ"" из выходящего списка!");
                        }
                        break;
                    }
            }

            void GoNext()
            {
                int indexOfNext = Encyclopedia.GetPlants(169).IndexOf(plant) + 1;
                if (Encyclopedia.GetPlants(169).Count >= indexOfNext + 1)
                {
                    plant = Encyclopedia.GetPlants(169)[indexOfNext];
                    textBoxText.Text = comboBoxList.Text = comboBoxBool.Text = "<Не указано>";
                    labelPlantName.Text = plant.Name;
                    pictureBoxImage.Image = plant.Images[0];
                    labelCharName.Text = characteristic.Name;
                }
                else
                {
                    Characteristic.Create(characteristic, newContents.ToArray());
                    Close();
                }
            }
        }
    }
}
