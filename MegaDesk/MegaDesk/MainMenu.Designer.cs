namespace MegaDesk
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deskImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.BackColor = System.Drawing.Color.White;
            this.newQuote.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(94, 49);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(200, 60);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "Add New Quote";
            this.newQuote.UseVisualStyleBackColor = false;
            this.newQuote.Click += new System.EventHandler(this.newQuote_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.BackColor = System.Drawing.Color.White;
            this.searchQuote.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuote.Location = new System.Drawing.Point(94, 205);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(200, 60);
            this.searchQuote.TabIndex = 1;
            this.searchQuote.Text = "Search Quotes";
            this.searchQuote.UseVisualStyleBackColor = false;
            this.searchQuote.Click += new System.EventHandler(this.searchQuote_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.BackColor = System.Drawing.Color.White;
            this.viewQuote.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuote.Location = new System.Drawing.Point(94, 128);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(200, 60);
            this.viewQuote.TabIndex = 2;
            this.viewQuote.Text = "View Quotes";
            this.viewQuote.UseVisualStyleBackColor = false;
            this.viewQuote.Click += new System.EventHandler(this.viewQuote_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(94, 283);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 60);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // deskImage
            // 
            this.deskImage.Image = global::MegaDesk.Properties.Resources.deskImage3;
            this.deskImage.ImageLocation = "";
            this.deskImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("deskImage.InitialImage")));
            this.deskImage.Location = new System.Drawing.Point(409, 60);
            this.deskImage.Name = "deskImage";
            this.deskImage.Size = new System.Drawing.Size(302, 292);
            this.deskImage.TabIndex = 4;
            this.deskImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(796, 405);
            this.Controls.Add(this.deskImage);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.newQuote);
            this.Name = "Form1";
            this.Text = "Mega Desk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button searchQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox deskImage;
    }
}

