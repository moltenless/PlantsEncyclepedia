using System;
using System.Windows.Forms;

namespace Энциклопедия_растений
{
    public partial class AddCharForm : Form
    {
        Characteristic characteristic;

        public AddCharForm()
        {
            InitializeComponent();
        }

        private void InputChanged(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string type = comboBoxType.Text;

            textBoxList.Visible = labelTip.Visible = false;

            if (name.Length < 2 || name[0] == ' ' || name[name.Length - 1] == ' ')
            {
                buttonAddChar.Enabled = false;
                return;
            }
            if (type == "текст")
            {
                characteristic = new Characteristic(name, ContentType.Text);
                buttonAddChar.Enabled = true;
            }
            else if (type == "список")
            {
                textBoxList.Visible = labelTip.Visible = true;

                if (textBoxList.Lines.Length > 1)
                {
                    characteristic = new Characteristic(name, ContentType.List, textBoxList.Lines);
                    buttonAddChar.Enabled = true;
                }
                else
                    buttonAddChar.Enabled = false;

                textBoxList.TextChanged += (sender2, e2) =>
                {
                    if (textBoxList.Lines.Length > 1)
                    {
                        characteristic = new Characteristic(name, ContentType.List, textBoxList.Lines);
                        buttonAddChar.Enabled = true;
                    }
                    else
                        buttonAddChar.Enabled = false;
                };
            }
            else if (type == "да/нет")
            {
                characteristic = new Characteristic(name, ContentType.Bool);
                buttonAddChar.Enabled = true;
            }
        }

        private void AddChar(object sender, EventArgs e)
        {
            if (Encyclopedia.GetPlants(169).Count > 0)
                new AppendCharsForm(characteristic).ShowDialog();
            Close();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
