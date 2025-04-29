namespace Энциклопедия_растений
{
    partial class AppendCharsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendCharsForm));
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.comboBoxBool = new System.Windows.Forms.ComboBox();
            this.textBoxText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.buttonТext = new System.Windows.Forms.Button();
            this.labelCharName = new System.Windows.Forms.Label();
            this.labelPlantName = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.comboBoxList);
            this.groupBoxAdd.Controls.Add(this.comboBoxBool);
            this.groupBoxAdd.Controls.Add(this.textBoxText);
            this.groupBoxAdd.Controls.Add(this.pictureBoxImage);
            this.groupBoxAdd.Controls.Add(this.labelTip);
            this.groupBoxAdd.Controls.Add(this.buttonТext);
            this.groupBoxAdd.Controls.Add(this.labelCharName);
            this.groupBoxAdd.Controls.Add(this.labelPlantName);
            this.groupBoxAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAdd.Location = new System.Drawing.Point(2, 2);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(559, 300);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление характеристики в существующии растения";
            // 
            // comboBoxList
            // 
            this.comboBoxList.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(299, 71);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(164, 27);
            this.comboBoxList.TabIndex = 11;
            this.comboBoxList.Visible = false;
            // 
            // comboBoxBool
            // 
            this.comboBoxBool.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBool.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxBool.FormattingEnabled = true;
            this.comboBoxBool.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.comboBoxBool.Location = new System.Drawing.Point(299, 71);
            this.comboBoxBool.Name = "comboBoxBool";
            this.comboBoxBool.Size = new System.Drawing.Size(164, 27);
            this.comboBoxBool.TabIndex = 10;
            this.comboBoxBool.Visible = false;
            // 
            // textBoxText
            // 
            this.textBoxText.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxText.Location = new System.Drawing.Point(299, 71);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(164, 162);
            this.textBoxText.TabIndex = 9;
            this.textBoxText.Text = "";
            this.textBoxText.Visible = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(35, 71);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(176, 162);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 8;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTip.Location = new System.Drawing.Point(296, 233);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(267, 15);
            this.labelTip.TabIndex = 6;
            this.labelTip.Text = "! для вставки новых елементов нажмите Enter";
            this.labelTip.Visible = false;
            // 
            // buttonТext
            // 
            this.buttonТext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonТext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonТext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonТext.Location = new System.Drawing.Point(395, 255);
            this.buttonТext.Name = "buttonТext";
            this.buttonТext.Size = new System.Drawing.Size(158, 39);
            this.buttonТext.TabIndex = 4;
            this.buttonТext.Text = "Далее";
            this.buttonТext.UseVisualStyleBackColor = false;
            this.buttonТext.Click += new System.EventHandler(this.Next);
            // 
            // labelCharName
            // 
            this.labelCharName.AutoSize = true;
            this.labelCharName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharName.Location = new System.Drawing.Point(294, 43);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(113, 25);
            this.labelCharName.TabIndex = 1;
            this.labelCharName.Text = "Название";
            // 
            // labelPlantName
            // 
            this.labelPlantName.AutoSize = true;
            this.labelPlantName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlantName.Location = new System.Drawing.Point(30, 43);
            this.labelPlantName.Name = "labelPlantName";
            this.labelPlantName.Size = new System.Drawing.Size(99, 25);
            this.labelPlantName.TabIndex = 0;
            this.labelPlantName.Text = "Назвние";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(563, 304);
            this.pictureBoxBackground.TabIndex = 7;
            this.pictureBoxBackground.TabStop = false;
            // 
            // AppendCharsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(563, 304);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppendCharsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление характеристики в существующии растения";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelCharName;
        private System.Windows.Forms.Label labelPlantName;
        private System.Windows.Forms.Button buttonТext;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.RichTextBox textBoxText;
        private System.Windows.Forms.ComboBox comboBoxBool;
        private System.Windows.Forms.ComboBox comboBoxList;
    }
}