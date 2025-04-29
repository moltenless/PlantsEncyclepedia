using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PlantsEncyclopedia
{
    public partial class PlantControl : GroupBox
    {
        public PlantControl(Control parent, Plant plant)
        {
            InitializeComponent();
            Parent = parent;
            Tag = plant;
            BackColor = Color.LightCyan;
            Dock = DockStyle.Left;
            FlatStyle = FlatStyle.Popup;
            ForeColor = Color.FromArgb(64, 64, 64);
            Location = new Point(0, 0);
            Size = new Size(330, 340);
            TabStop = false;
            Text = plant.Name;
            Controls.Add(labelShowInfo);
            Controls.Add(labelShowImages);
            Controls.Add(pictureBoxImage);

            //labelShowInfo
            labelShowImages.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            labelShowImages.AutoSize = true;
            labelShowImages.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelShowImages.ForeColor = Color.Gray;
            labelShowImages.LinkBehavior = LinkBehavior.HoverUnderline;
            labelShowImages.LinkColor = Color.Black;
            labelShowImages.Location = new Point(3, 319);
            labelShowImages.Size = new Size(149, 16);
            labelShowImages.TabStop = true;
            labelShowImages.Text = "other images";
            labelShowImages.Click += ShowImages;

            //labelShowImages
            labelShowInfo.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            labelShowInfo.AutoSize = true;
            labelShowInfo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelShowInfo.ForeColor = Color.Gray;
            labelShowInfo.LinkBehavior = LinkBehavior.HoverUnderline;
            labelShowInfo.LinkColor = Color.Black;
            labelShowInfo.Location = new Point(177, 319);
            labelShowInfo.Size = new Size(147, 16);
            labelShowInfo.TabStop = true;
            labelShowInfo.Text = "full info";
            labelShowInfo.Click += ShowInfo;

            //pictureBoxImage
            pictureBoxImage.Location = new Point(3, 27);
            pictureBoxImage.Size = new Size(321, 289);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Image = plant.Images[0];
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            new PlantInfoForm(Tag as Plant).ShowDialog();
        }

        private void ShowImages(object sender, EventArgs e)
        {
            new ShowImagesForm((Tag as Plant).Images.ToList()).ShowDialog();
        }

        LinkLabel labelShowInfo = new LinkLabel();
        LinkLabel labelShowImages = new LinkLabel();
        PictureBox pictureBoxImage = new PictureBox();
    }
}
