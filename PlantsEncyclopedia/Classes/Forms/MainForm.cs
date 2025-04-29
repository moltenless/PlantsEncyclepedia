using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlantsEncyclopedia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateDataInControls();
        }

        private void UpdateDataInControls()
        {
            #region Chars
            panelChar.Controls.Clear();
            panelChar.Controls.AddRange(new Control[] { labelCharImages, labelCharName });
            for (int i = 0; i < Encyclopedia.GetCharacteristics(169).Count; i++)
            {
                CharacteristicControl characteristic = new CharacteristicControl(panelChar, Encyclopedia.GetCharacteristics(169)[i]);
                characteristic.GotFocus += (sender2, e2) =>
                {
                    buttonRemoveChar.Enabled = true;
                    panelChar.Tag = sender2;
                };
                characteristic.Text = (characteristic.Tag as Characteristic).Name;
            }
            #endregion
            #region Plants
            panelPlants.Controls.Clear();
            for (int i = 0; i < Encyclopedia.GetPlants(169).Count; i++)
            {
                PlantControl plant = new PlantControl(panelPlants, Encyclopedia.GetPlants(169)[i]);
                plant.Click += (sender2, e2) => plant.Focus();
                plant.Controls[2].Click += (sender2, e2) => plant.Focus();
                plant.GotFocus += (sender2, e2) =>
                {
                    foreach (PlantControl control in panelPlants.Controls)
                    {
                        control.BackColor = Color.LightCyan;
                        panelPlants.Tag = null;
                    }
                    plant.BackColor = Color.PaleTurquoise;
                    panelPlants.Tag = Encyclopedia.GetPlants(169)[panelPlants.Controls.IndexOf(sender2 as PlantControl)];
                    buttonRemovePlant.Enabled = true;
                    buttonChangePlant.Enabled = true;
                };
            }
            #endregion
            #region Filter controls
            panelFilter.Controls.Clear();
            if (Encyclopedia.GetCharacteristics(169).Count == 0) return;
            for (int i = 0; i < Encyclopedia.GetCharacteristics(169).Count; i++)
            {
                GroupBox block = new GroupBox
                {
                    Parent = panelFilter,
                    Text = Encyclopedia.GetCharacteristics(169)[i].Name,
                    ForeColor = Color.FromArgb(64, 64, 64, 64),
                    Dock = DockStyle.Left,
                    BackColor = Color.LightCyan,
                    TabIndex = i,
                    Enabled = false,
                };
                TextBox textBox = new TextBox
                {
                    Dock = DockStyle.Top,
                    ForeColor = Color.FromArgb(64, 64, 64, 64),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.LightCyan,
                    Multiline = true,
                    MaximumSize = new Size(200, 72),
                    MinimumSize = new Size(0, 72),
                };
                CheckedListBox checkedListBox = new CheckedListBox
                {
                    Dock = DockStyle.Top,
                    ForeColor = Color.FromArgb(64, 64, 64, 64),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.LightCyan,
                    CheckOnClick = true,
                    HorizontalScrollbar = true,
                    MaximumSize = new Size(200, 72),
                    MinimumSize = new Size(0, 72),
                };
                ComboBox comboBox = new ComboBox
                {
                    Dock = DockStyle.Top,
                    ForeColor = Color.FromArgb(64, 64, 64, 64),
                    FlatStyle = FlatStyle.Standard,
                    BackColor = Color.LightCyan,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    MaximumSize = new Size(200, 72),
                    MinimumSize = new Size(0, 72),
                };
                CheckBox checkBox = new CheckBox
                {
                    Parent = block,
                    Dock = DockStyle.Top,
                    ForeColor = Color.FromArgb(64, 64, 64, 64),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightCyan,
                    Text = "Не важно",
                    CheckState = CheckState.Checked,
                };

                switch (Encyclopedia.GetCharacteristics(169)[i].Type)
                {
                    case ContentType.Text:
                        {
                            checkBox.Enabled = false;
                            textBox.Parent = block;
                            new Panel { Parent = block, Dock = DockStyle.Fill, BackColor = Color.LightCyan, };//background
                            textBox.TextChanged += (sender2, e2) =>
                            {
                                if (textBox.Text != "") checkBox.CheckState = CheckState.Unchecked;
                                else if (textBox.Text == "") checkBox.CheckState = CheckState.Checked;
                            };
                            break;
                        }
                    case ContentType.List:
                        {
                            checkBox.Enabled = false;
                            checkedListBox.Parent = block;
                            new Panel { Parent = block, Dock = DockStyle.Fill, BackColor = Color.LightCyan, };//background
                            checkedListBox.Items.AddRange(Encyclopedia.GetCharacteristics(169)[i].List);
                            checkedListBox.ItemCheck += CheckValueChanged;
                            checkBox.Click += (sender2, e2) =>
                            {
                                if (checkBox.CheckState == CheckState.Checked)
                                {
                                    checkedListBox.ItemCheck -= CheckValueChanged;
                                    for (int j = 0; j < checkedListBox.Items.Count; j++)
                                    {
                                        checkedListBox.SetItemCheckState(j, CheckState.Unchecked);
                                    }
                                    checkBox.Enabled = false;
                                    checkedListBox.ItemCheck += CheckValueChanged;
                                }
                            };
                            void CheckValueChanged(object sender2, ItemCheckEventArgs e2)
                            {
                                checkBox.CheckState = CheckState.Unchecked;
                                bool isAllItemsCheked = true, isAllItemsUncheked = true;
                                for (int j = 0; j < checkedListBox.Items.Count; j++)
                                {
                                    if (j == e2.Index) continue;
                                    CheckState state = checkedListBox.GetItemCheckState(j);
                                    if (state == CheckState.Checked)
                                        isAllItemsUncheked = false;
                                    else
                                        isAllItemsCheked = false;
                                }
                                if (e2.NewValue == CheckState.Checked)
                                    isAllItemsUncheked = false;
                                else
                                    isAllItemsCheked = false;

                                if (isAllItemsCheked || isAllItemsUncheked)
                                {
                                    checkBox.CheckState = CheckState.Checked;
                                    checkBox.Enabled = false;
                                }
                                else
                                {
                                    checkBox.Enabled = true;
                                }
                            }
                            break;
                        }
                    case ContentType.Bool:
                        {
                            checkBox.Enabled = false;
                            comboBox.Parent = block;
                            new Panel { Parent = block, Dock = DockStyle.Fill, BackColor = Color.LightCyan, };//background
                            comboBox.Items.AddRange(new string[] { "Да", "Нет", "Не важно" });
                            comboBox.Text = "Не важно";
                            comboBox.SelectedIndexChanged += (sender2, e2) =>
                            {
                                if (comboBox.Text == "Не важно")
                                    checkBox.CheckState = CheckState.Checked;
                                else
                                    checkBox.CheckState = CheckState.Unchecked;
                            };
                            break;
                        }
                }
            }
            int lastIndex = panelFilter.Controls.Count - 1;
            panelFilter.TabIndex = lastIndex;
            FilterNextStep();
            #endregion
        }

        private void FilterNextStep()
        {
            Control block = panelFilter.Controls[panelFilter.TabIndex];
            foreach (Control bl in panelFilter.Controls)
            {
                bl.Enabled = false;
                bl.BackColor = Color.LightCyan;
            }
            block.Enabled = true;
            block.Focus();
            block.BackColor = Color.PaleTurquoise;

            if (block.TabIndex == panelFilter.Controls.Count - 1)
                buttonLeftArrow.Enabled = false;
            else
                buttonLeftArrow.Enabled = true;
            if (block.TabIndex == 0)
                buttonRightArrow.Enabled = false;
            else
                buttonRightArrow.Enabled = true;

            buttonLeftArrow.Text = (panelFilter.Controls.Count - block.TabIndex - 1).ToString();
            buttonRightArrow.Text = block.TabIndex.ToString();
        }

        private void Filter(object sender, EventArgs e)
        {
            bool isAllFilterUnimplemented = true;
            for (int i = 0; i < panelFilter.Controls.Count; i++)
            {
                if ((panelFilter.Controls[i].Controls[0] as CheckBox).CheckState == CheckState.Unchecked)
                {
                    isAllFilterUnimplemented = false;
                    break;
                }
            }
            if (isAllFilterUnimplemented)
            {
                MessageBox.Show("Измените параметры фильтра, иначе он будет бесполезеным");
                return;
            }

            Filter filter = new Filter(null);// MUST DO THIS LATER
            for (int i = 0; i < panelFilter.Controls.Count; i++)
            {
                if ((panelFilter.Controls[i].Controls[0] as CheckBox).CheckState == CheckState.Checked)
                {
                    filter.AddItemToFilter(null, ContentType.Bool/*whatever which ContentType*/);
                    continue;
                }
                Control control = panelFilter.Controls[i].Controls[1];
                if (control is TextBox textBox)
                {
                    filter.AddItemToFilter(textBox.Text, ContentType.Text);
                }
                else if (control is ComboBox comboBox)
                {
                    filter.AddItemToFilter(comboBox.Text, ContentType.Bool);
                }
                else if (control is CheckedListBox checkedList)
                {
                    bool[] isItemsChecked = new bool[checkedList.Items.Count];
                    for (int j = 0; j < isItemsChecked.Length; j++)
                    {
                        if (checkedList.GetItemCheckState(j) == CheckState.Checked)
                            isItemsChecked[j] = true;
                        else
                            isItemsChecked[j] = false;
                    }
                    filter.AddItemToFilter(isItemsChecked, ContentType.List);
                }
            }
            new FilteredPlantsForm(filter).ShowDialog();
        }

        private void AddChar(object sender, EventArgs e)
        {
            new AddCharForm().ShowDialog();
            UpdateDataInControls();
        }

        private void RemoveChar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите безвозвратно удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CharacteristicControl control = (CharacteristicControl)panelChar.Tag;
                int indexOfChar = Encyclopedia.GetCharacteristics(169).IndexOf((Characteristic)control.Tag);

                foreach (var plant in Encyclopedia.GetPlants(169))
                    plant.Contents.RemoveAt(indexOfChar);

                Encyclopedia.GetCharacteristics(169).Remove((Characteristic)control.Tag);
                buttonRemoveChar.Enabled = false;
                UpdateDataInControls();
            }
        }

        private void AddPlant(object sender, EventArgs e)
        {
            new AddPlantForm().ShowDialog();
            UpdateDataInControls();
        }

        private void ChangePlant(object sender, EventArgs e)
        {
            new ChangePlantForm((Plant)panelPlants.Tag).ShowDialog();
            UpdateDataInControls();
        }

        private void RemovePlant(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите безвозвратно удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Encyclopedia.GetPlants(169).Remove((Plant)panelPlants.Tag);
                buttonRemovePlant.Enabled = false;
                UpdateDataInControls();
            }
        }

        private void ArrowClick(object sender, EventArgs e)
        {
            if ((string)(sender as Control).Tag == "right")
            {
                panelFilter.TabIndex--;
                FilterNextStep();
            }
            else
            {
                panelFilter.TabIndex++;
                FilterNextStep();
            }
        }
    }
}
