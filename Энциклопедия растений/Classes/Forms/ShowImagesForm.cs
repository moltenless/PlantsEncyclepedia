using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Энциклопедия_растений
{
    public partial class ShowImagesForm : Form
    {
        List<Image> images;
        int index = 0;

        public ShowImagesForm(List<Image> images)
        {
            InitializeComponent();

            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 45);
            this.images = images;

            BackgroundImage = images[0];
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSizeChanged(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void Back(object sender, EventArgs e)
        {
            BackgroundImage = images[--index];
        }

        private void Next(object sender, EventArgs e)
        {
            BackgroundImage = images[++index];
        }

        private void ImageChanged(object sender, EventArgs e)
        {
            Size = BackgroundImage.Size;
            if (index == 0)
                buttonBack.Enabled = false;
            else
                buttonBack.Enabled = true;
            if(index == images.Count - 1)
                buttonNext.Enabled = false;
            else
                buttonNext.Enabled = true;

            buttonBack.Text = $"Назад({index})";
            buttonNext.Text = $"Вперёд({images.Count - index - 1})";
        }

        private void Copy(object sender, EventArgs e)
        {
            Clipboard.SetImage(BackgroundImage);
        }
    }
}
