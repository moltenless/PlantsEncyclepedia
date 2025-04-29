using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlantsEncyclopedia
{
    public partial class CharacteristicControl : LinkLabel
    {
        public CharacteristicControl(Control parent, Characteristic characteristic)
        {
            InitializeComponent();
            Parent = parent;
            Tag = characteristic;
            BackColor = Color.LightCyan;
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Top;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(64, 64, 64, 64);
            Size = new Size(307, 25);
            Text = Name = "";
            TextAlign = ContentAlignment.MiddleCenter;
            LinkColor = Color.FromArgb(64, 64, 64, 64);
            ActiveLinkColor = Color.Teal;
            LinkBehavior = LinkBehavior.HoverUnderline;
            VisitedLinkColor = Color.Teal;
            GotFocus += ControlGotFocus;
        }

        private void ControlGotFocus(object sender, EventArgs e)
        {
            foreach (var characteristic in Parent.Controls)
                (characteristic as LinkLabel).LinkVisited = false;
            (sender as CharacteristicControl).LinkVisited = true;
        }
    }
}
