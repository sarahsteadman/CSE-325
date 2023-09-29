namespace MegaDesk
{
    partial class DisplayQuote
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
            this.width = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.quote = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(34, 398);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(155, 40);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(86, 78);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(80, 29);
            this.width.TabIndex = 2;
            this.width.Text = "Width:";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Location = new System.Drawing.Point(86, 195);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(109, 29);
            this.drawers.TabIndex = 2;
            this.drawers.Text = "Drawers:";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(86, 131);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(83, 29);
            this.depth.TabIndex = 2;
            this.depth.Text = "Depth:";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Location = new System.Drawing.Point(86, 263);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(99, 29);
            this.material.TabIndex = 2;
            this.material.Text = "Material";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(409, 131);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(63, 29);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(409, 195);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(208, 29);
            this.time.TabIndex = 2;
            this.time.Text = "Turn Around Time";
            // 
            // quote
            // 
            this.quote.AutoSize = true;
            this.quote.BackColor = System.Drawing.Color.GhostWhite;
            this.quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.Location = new System.Drawing.Point(408, 239);
            this.quote.Name = "quote";
            this.quote.Padding = new System.Windows.Forms.Padding(25);
            this.quote.Size = new System.Drawing.Size(164, 82);
            this.quote.TabIndex = 2;
            this.quote.Text = "Quote: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(409, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 29);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.quote);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.date);
            this.Controls.Add(this.material);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.width);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenu);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label quote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
    }
}