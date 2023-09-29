namespace MegaDesk
{
    partial class SearchQuote
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
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(313, 195);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(174, 61);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.Name = "SearchQuote";
            this.Text = "SearchQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
    }
}