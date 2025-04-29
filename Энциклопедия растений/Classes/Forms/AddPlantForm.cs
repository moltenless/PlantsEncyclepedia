using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Энциклопедия_растений.Properties;

namespace Энциклопедия_растений
{
    public partial class AddPlantForm : Form
    {
        Plant plant;
        List<Image> imageList = new List<Image>();

        public AddPlantForm()
        {
            InitializeComponent();
            if (Encyclopedia.GetCharacteristics(169).Count > 0)
            {
                labelCharsInfo.Text = $"Характеристики ({Encyclopedia.GetCharacteristics(169).Count}):";
                for (int i = 0; i < Encyclopedia.GetCharacteristics(169).Count; i++)
                {
                    Panel block = new Panel
                    {
                        Parent = panelChars,
                        BorderStyle = BorderStyle.Fixed3D,
                        Dock = DockStyle.Top,
                        Height = 50,
                    };
                    Label label = new Label
                    {
                        Parent = block,
                        Dock = DockStyle.Top,
                        Text = Encyclopedia.GetCharacteristics(169)[i].Name,
                        Font = new Font(labelCharsInfo.Font.FontFamily, 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.TopCenter,
                    };
                    ComboBox comboBox = new ComboBox
                    {
                        Dock = DockStyle.Bottom,
                        Font = new Font(labelCharsInfo.Font.FontFamily, 10, FontStyle.Bold),
                        ForeColor = Color.FromArgb(64, 64, 64, 64),
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.LightCyan,
                        Tag = "char control",
                    };
                    TextBox textBox = new TextBox
                    {
                        Dock = DockStyle.Bottom,
                        Font = new Font(labelCharsInfo.Font.FontFamily, 10, FontStyle.Bold),
                        ForeColor = Color.FromArgb(64, 64, 64, 64),
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor = Color.LightCyan,
                        Text = "<Не указано>",
                        Multiline = true,
                        ScrollBars = ScrollBars.Vertical,
                        Height = 77,
                        Tag = "char control",
                    };

                    switch (Encyclopedia.GetCharacteristics(169)[i].Type)
                    {
                        case ContentType.Text:
                            {
                                textBox.Parent = block;
                                textBox.Click += (sender2, e2) => { if (textBox.Text == "<Не указано>") textBox.SelectAll(); };
                                block.Height = 100;
                                break;
                            }
                        case ContentType.List:
                            {
                                comboBox.Parent = block;
                                comboBox.Items.AddRange(Encyclopedia.GetCharacteristics(169)[i].List);
                                comboBox.Items.Add("<Не указано>");
                                comboBox.Text = "<Не указано>";
                                break;
                            }
                        case ContentType.Bool:
                            {
                                comboBox.Parent = block;
                                comboBox.Items.AddRange(new string[] { "Да", "Нет", "<Не указано>" });
                                comboBox.Text = "<Не указано>";
                                break;
                            }
                    }
                }
            }
            else
            {
                labelCharsInfo.Text = "Нет других характеристик.\r\nВы можете добавить их на начальной странице.";
                labelCharsInfo.Font = new Font(labelCharsInfo.Font.FontFamily, 12, FontStyle.Bold);
                panelChars.Parent = null;
            }
        }

        private void AddImage(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog { Multiselect = true, Title = "Выберите файлы одного или нескольких изображений", Filter = "Изображения|*.png;*.jpeg;*.jpg;*.gif" };
            fileDialog.ShowDialog();

            if (imageList.Count + fileDialog.FileNames.Length > 15)
            {
                MessageBox.Show("Слишком много изображений");
                return;
            }

            for (int i = 0; i < fileDialog.FileNames.Length; i++)
            {
                try
                {
                    imageList.Add(Image.FromFile(fileDialog.FileNames[i]));
                    Label label = new Label
                    {
                        Tag = panelImages.Controls.Count,
                        Parent = panelImages,
                        Dock = DockStyle.Top,
                        AutoSize = false,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = fileDialog.FileNames[i].Split(new char[] { '\\' })[fileDialog.FileNames[i].Split(new char[] { '\\' }).Length - 1],
                        Font = new Font(labelCharsInfo.Font.FontFamily, 10, FontStyle.Regular),
                    };
                    label.MouseEnter += (sender2, e2) => { label.BackColor = Color.Red; label.ForeColor = Color.WhiteSmoke; };
                    label.MouseLeave += (sender2, e2) => { label.BackColor = Color.LightCyan; label.ForeColor = Color.FromArgb(64, 64, 64, 64); };
                    label.Click += (sender2, e2) => {
                        (sender2 as Label).Tag = panelImages.Controls.IndexOf(sender2 as Label);
                        (sender2 as Label).Parent = null;
                        imageList.RemoveAt((int)(sender2 as Label).Tag);
                    };
                }
                catch { }
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void Create(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length <= 1 || textBoxName.Text[0] == ' ')
            {
                MessageBox.Show("Название должно содержать более 1 символа.");
                return;
            }

            bool isCharsNotImplement = false;
            foreach (Control block in panelChars.Controls)
            {
                if (block.Controls[1].Text == "<Не указано>")
                {
                    isCharsNotImplement = true;
                    break;
                }
            }

            if (isCharsNotImplement)
            {
                if (MessageBox.Show("Некоторые характеристики не указаны. Все равно продолжить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            if (imageList.Count == 0)
            {
                if (MessageBox.Show("Вы не добавили ни одного изображения к растению. Все равно продолжить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                else
                    imageList.Add(Resources.default_plant_image);
            }

            List<object> contentList = new List<object>();
            foreach (Control block in panelChars.Controls)
            {
                foreach (Control control in block.Controls)
                {
                    if ((string)control.Tag == "char control")
                    {
                        if (control.Text == "<Не указано>")
                        {
                            contentList.Add(null);
                        }
                        else
                        {
                            switch (Encyclopedia.GetCharacteristics(169)[panelChars.Controls.IndexOf(block)].Type)
                            {
                                case ContentType.Bool:
                                    {
                                        if (control.Text == "Да")
                                        {
                                            contentList.Add(true);
                                        }
                                        else if (control.Text == "Нет")
                                        {
                                            contentList.Add(false);
                                        }
                                        else
                                            throw new Exception();
                                        break;
                                    }
                                case ContentType.Text: goto case ContentType.List;
                                case ContentType.List:
                                    {
                                        contentList.Add(control.Text);
                                        break;
                                    }
                            }
                        }
                    }
                }
            }

            plant = new Plant(textBoxName.Text, imageList, contentList);
            Plant.Create(plant);
            Close();
        }
    }
}
