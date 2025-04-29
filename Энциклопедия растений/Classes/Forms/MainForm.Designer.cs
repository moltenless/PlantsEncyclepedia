namespace Энциклопедия_растений
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxChar = new System.Windows.Forms.GroupBox();
            this.panelChar = new System.Windows.Forms.Panel();
            this.labelCharImages = new System.Windows.Forms.LinkLabel();
            this.labelCharName = new System.Windows.Forms.LinkLabel();
            this.buttonRemoveChar = new System.Windows.Forms.Button();
            this.buttonAddChar = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonTick = new System.Windows.Forms.Button();
            this.buttonLeftArrow = new System.Windows.Forms.Button();
            this.buttonRightArrow = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.groupBoxPlants = new System.Windows.Forms.GroupBox();
            this.panelPlants = new System.Windows.Forms.Panel();
            this.buttonAddPlant = new System.Windows.Forms.Button();
            this.buttonChangePlant = new System.Windows.Forms.Button();
            this.buttonRemovePlant = new System.Windows.Forms.Button();
            this.groupBoxChar.SuspendLayout();
            this.panelChar.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxPlants.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChar
            // 
            this.groupBoxChar.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxChar.Controls.Add(this.panelChar);
            this.groupBoxChar.Controls.Add(this.buttonRemoveChar);
            this.groupBoxChar.Controls.Add(this.buttonAddChar);
            this.groupBoxChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxChar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChar.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxChar.Location = new System.Drawing.Point(16, 31);
            this.groupBoxChar.Name = "groupBoxChar";
            this.groupBoxChar.Size = new System.Drawing.Size(224, 613);
            this.groupBoxChar.TabIndex = 1;
            this.groupBoxChar.TabStop = false;
            this.groupBoxChar.Text = "Характеристики растений";
            // 
            // panelChar
            // 
            this.panelChar.AutoScroll = true;
            this.panelChar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChar.Controls.Add(this.labelCharImages);
            this.panelChar.Controls.Add(this.labelCharName);
            this.panelChar.Location = new System.Drawing.Point(6, 30);
            this.panelChar.Name = "panelChar";
            this.panelChar.Size = new System.Drawing.Size(212, 547);
            this.panelChar.TabIndex = 2;
            // 
            // labelCharImages
            // 
            this.labelCharImages.BackColor = System.Drawing.Color.LightCyan;
            this.labelCharImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCharImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCharImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCharImages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharImages.ForeColor = System.Drawing.Color.Gray;
            this.labelCharImages.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelCharImages.LinkColor = System.Drawing.Color.Gray;
            this.labelCharImages.Location = new System.Drawing.Point(0, 25);
            this.labelCharImages.Name = "labelCharImages";
            this.labelCharImages.Size = new System.Drawing.Size(208, 25);
            this.labelCharImages.TabIndex = 1;
            this.labelCharImages.TabStop = true;
            this.labelCharImages.Text = "Изображения";
            this.labelCharImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCharName
            // 
            this.labelCharName.BackColor = System.Drawing.Color.LightCyan;
            this.labelCharName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCharName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCharName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCharName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharName.ForeColor = System.Drawing.Color.Gray;
            this.labelCharName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelCharName.LinkColor = System.Drawing.Color.Gray;
            this.labelCharName.Location = new System.Drawing.Point(0, 0);
            this.labelCharName.Name = "labelCharName";
            this.labelCharName.Size = new System.Drawing.Size(208, 25);
            this.labelCharName.TabIndex = 0;
            this.labelCharName.TabStop = true;
            this.labelCharName.Text = "Полное назание растения ";
            this.labelCharName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRemoveChar
            // 
            this.buttonRemoveChar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRemoveChar.Enabled = false;
            this.buttonRemoveChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveChar.ForeColor = System.Drawing.Color.Crimson;
            this.buttonRemoveChar.Location = new System.Drawing.Point(114, 583);
            this.buttonRemoveChar.Name = "buttonRemoveChar";
            this.buttonRemoveChar.Size = new System.Drawing.Size(102, 24);
            this.buttonRemoveChar.TabIndex = 1;
            this.buttonRemoveChar.Text = "Удалить";
            this.buttonRemoveChar.UseVisualStyleBackColor = false;
            this.buttonRemoveChar.Click += new System.EventHandler(this.RemoveChar);
            // 
            // buttonAddChar
            // 
            this.buttonAddChar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddChar.Location = new System.Drawing.Point(6, 583);
            this.buttonAddChar.Name = "buttonAddChar";
            this.buttonAddChar.Size = new System.Drawing.Size(102, 24);
            this.buttonAddChar.TabIndex = 0;
            this.buttonAddChar.Text = "Добавить";
            this.buttonAddChar.UseVisualStyleBackColor = false;
            this.buttonAddChar.Click += new System.EventHandler(this.AddChar);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxFilter.Controls.Add(this.buttonTick);
            this.groupBoxFilter.Controls.Add(this.buttonLeftArrow);
            this.groupBoxFilter.Controls.Add(this.buttonRightArrow);
            this.groupBoxFilter.Controls.Add(this.panelFilter);
            this.groupBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFilter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxFilter.Location = new System.Drawing.Point(246, 463);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1002, 181);
            this.groupBoxFilter.TabIndex = 5;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Поиск растений с заданным фильтром";
            // 
            // buttonTick
            // 
            this.buttonTick.BackgroundImage = global::Энциклопедия_растений.Properties.Resources.tick;
            this.buttonTick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTick.FlatAppearance.BorderSize = 0;
            this.buttonTick.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonTick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonTick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTick.Location = new System.Drawing.Point(945, 130);
            this.buttonTick.Name = "buttonTick";
            this.buttonTick.Size = new System.Drawing.Size(51, 40);
            this.buttonTick.TabIndex = 5;
            this.buttonTick.UseVisualStyleBackColor = true;
            this.buttonTick.Click += new System.EventHandler(this.Filter);
            // 
            // buttonLeftArrow
            // 
            this.buttonLeftArrow.BackgroundImage = global::Энциклопедия_растений.Properties.Resources.leftarrow;
            this.buttonLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeftArrow.FlatAppearance.BorderSize = 0;
            this.buttonLeftArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonLeftArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonLeftArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftArrow.Location = new System.Drawing.Point(945, 79);
            this.buttonLeftArrow.Name = "buttonLeftArrow";
            this.buttonLeftArrow.Size = new System.Drawing.Size(51, 45);
            this.buttonLeftArrow.TabIndex = 4;
            this.buttonLeftArrow.Tag = "left";
            this.buttonLeftArrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeftArrow.UseVisualStyleBackColor = true;
            this.buttonLeftArrow.Click += new System.EventHandler(this.ArrowClick);
            // 
            // buttonRightArrow
            // 
            this.buttonRightArrow.BackgroundImage = global::Энциклопедия_растений.Properties.Resources.rightarrow;
            this.buttonRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRightArrow.FlatAppearance.BorderSize = 0;
            this.buttonRightArrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonRightArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonRightArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonRightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightArrow.Location = new System.Drawing.Point(945, 33);
            this.buttonRightArrow.Name = "buttonRightArrow";
            this.buttonRightArrow.Size = new System.Drawing.Size(51, 45);
            this.buttonRightArrow.TabIndex = 3;
            this.buttonRightArrow.Tag = "right";
            this.buttonRightArrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRightArrow.UseVisualStyleBackColor = true;
            this.buttonRightArrow.Click += new System.EventHandler(this.ArrowClick);
            // 
            // panelFilter
            // 
            this.panelFilter.AutoScroll = true;
            this.panelFilter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelFilter.Location = new System.Drawing.Point(6, 33);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(933, 139);
            this.panelFilter.TabIndex = 2;
            // 
            // groupBoxPlants
            // 
            this.groupBoxPlants.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxPlants.Controls.Add(this.panelPlants);
            this.groupBoxPlants.Controls.Add(this.buttonAddPlant);
            this.groupBoxPlants.Controls.Add(this.buttonChangePlant);
            this.groupBoxPlants.Controls.Add(this.buttonRemovePlant);
            this.groupBoxPlants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPlants.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPlants.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxPlants.Location = new System.Drawing.Point(246, 31);
            this.groupBoxPlants.Name = "groupBoxPlants";
            this.groupBoxPlants.Size = new System.Drawing.Size(1002, 426);
            this.groupBoxPlants.TabIndex = 4;
            this.groupBoxPlants.TabStop = false;
            this.groupBoxPlants.Text = "Список растений";
            // 
            // panelPlants
            // 
            this.panelPlants.AutoScroll = true;
            this.panelPlants.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelPlants.Location = new System.Drawing.Point(6, 30);
            this.panelPlants.Name = "panelPlants";
            this.panelPlants.Size = new System.Drawing.Size(990, 357);
            this.panelPlants.TabIndex = 2;
            // 
            // buttonAddPlant
            // 
            this.buttonAddPlant.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddPlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPlant.ForeColor = System.Drawing.Color.Teal;
            this.buttonAddPlant.Location = new System.Drawing.Point(6, 392);
            this.buttonAddPlant.Name = "buttonAddPlant";
            this.buttonAddPlant.Size = new System.Drawing.Size(110, 28);
            this.buttonAddPlant.TabIndex = 0;
            this.buttonAddPlant.Text = "Добавить";
            this.buttonAddPlant.UseVisualStyleBackColor = false;
            this.buttonAddPlant.Click += new System.EventHandler(this.AddPlant);
            // 
            // buttonChangePlant
            // 
            this.buttonChangePlant.BackColor = System.Drawing.Color.LightCyan;
            this.buttonChangePlant.Enabled = false;
            this.buttonChangePlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePlant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePlant.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePlant.Location = new System.Drawing.Point(122, 392);
            this.buttonChangePlant.Name = "buttonChangePlant";
            this.buttonChangePlant.Size = new System.Drawing.Size(110, 28);
            this.buttonChangePlant.TabIndex = 2;
            this.buttonChangePlant.Text = "Изменить";
            this.buttonChangePlant.UseVisualStyleBackColor = false;
            this.buttonChangePlant.Click += new System.EventHandler(this.ChangePlant);
            // 
            // buttonRemovePlant
            // 
            this.buttonRemovePlant.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRemovePlant.Enabled = false;
            this.buttonRemovePlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePlant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemovePlant.ForeColor = System.Drawing.Color.Crimson;
            this.buttonRemovePlant.Location = new System.Drawing.Point(912, 393);
            this.buttonRemovePlant.Name = "buttonRemovePlant";
            this.buttonRemovePlant.Size = new System.Drawing.Size(84, 28);
            this.buttonRemovePlant.TabIndex = 1;
            this.buttonRemovePlant.Text = "Удалить";
            this.buttonRemovePlant.UseVisualStyleBackColor = false;
            this.buttonRemovePlant.Click += new System.EventHandler(this.RemovePlant);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Энциклопедия_растений.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxPlants);
            this.Controls.Add(this.groupBoxChar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Энциклопедия растений";
            this.groupBoxChar.ResumeLayout(false);
            this.panelChar.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxPlants.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChar;
        private System.Windows.Forms.Panel panelChar;
        private System.Windows.Forms.LinkLabel labelCharImages;
        private System.Windows.Forms.LinkLabel labelCharName;
        private System.Windows.Forms.Button buttonRemoveChar;
        private System.Windows.Forms.Button buttonAddChar;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox groupBoxPlants;
        private System.Windows.Forms.Panel panelPlants;
        private System.Windows.Forms.Button buttonAddPlant;
        private System.Windows.Forms.Button buttonChangePlant;
        private System.Windows.Forms.Button buttonRemovePlant;
        private System.Windows.Forms.Button buttonRightArrow;
        private System.Windows.Forms.Button buttonTick;
        private System.Windows.Forms.Button buttonLeftArrow;
    }
}