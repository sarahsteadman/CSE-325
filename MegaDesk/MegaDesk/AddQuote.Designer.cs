namespace MegaDesk
{
    partial class AddQuote
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
            this.mainMenu = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthEntry = new System.Windows.Forms.TextBox();
            this.depthEntry = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerEntry = new System.Windows.Forms.TextBox();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.turnAroundTime = new System.Windows.Forms.ComboBox();
            this.materials = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(34, 348);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(120, 40);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(131, 51);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(127, 22);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = " Width of Desk";
            // 
            // widthEntry
            // 
            this.widthEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthEntry.Location = new System.Drawing.Point(135, 76);
            this.widthEntry.Name = "widthEntry";
            this.widthEntry.Size = new System.Drawing.Size(205, 30);
            this.widthEntry.TabIndex = 2;
            this.widthEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Key_Type);
            this.widthEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Validate_Width);
            // 
            // depthEntry
            // 
            this.depthEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthEntry.Location = new System.Drawing.Point(135, 164);
            this.depthEntry.Name = "depthEntry";
            this.depthEntry.Size = new System.Drawing.Size(205, 30);
            this.depthEntry.TabIndex = 4;
            this.depthEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Key_Type);
            this.depthEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Validate_Depth);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(131, 141);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(124, 22);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth of Desk";
            // 
            // drawerEntry
            // 
            this.drawerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerEntry.Location = new System.Drawing.Point(135, 261);
            this.drawerEntry.Name = "drawerEntry";
            this.drawerEntry.Size = new System.Drawing.Size(205, 30);
            this.drawerEntry.TabIndex = 6;
            this.drawerEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_Key_Type);
            this.drawerEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Validate_Drawers);
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(131, 238);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(165, 22);
            this.drawerLabel.TabIndex = 5;
            this.drawerLabel.Text = "Number of Drawers";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(425, 236);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameEntry
            // 
            this.nameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEntry.Location = new System.Drawing.Point(429, 261);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(205, 30);
            this.nameEntry.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(516, 348);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(120, 40);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Make_Order);
            // 
            // turnAroundTime
            // 
            this.turnAroundTime.FormattingEnabled = true;
            this.turnAroundTime.Location = new System.Drawing.Point(430, 166);
            this.turnAroundTime.Name = "turnAroundTime";
            this.turnAroundTime.Size = new System.Drawing.Size(204, 28);
            this.turnAroundTime.TabIndex = 7;
            // 
            // materials
            // 
            this.materials.FormattingEnabled = true;
            this.materials.Location = new System.Drawing.Point(430, 69);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(205, 28);
            this.materials.TabIndex = 8;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(426, 44);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(149, 22);
            this.materialLabel.TabIndex = 1;
            this.materialLabel.Text = "Surface Materials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn Around Time";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(770, 426);
            this.Controls.Add(this.materials);
            this.Controls.Add(this.turnAroundTime);
            this.Controls.Add(this.drawerEntry);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.depthEntry);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.widthEntry);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.mainMenu);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthEntry;
        private System.Windows.Forms.TextBox depthEntry;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox drawerEntry;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ComboBox turnAroundTime;
        private System.Windows.Forms.ComboBox materials;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label label2;
    }
}