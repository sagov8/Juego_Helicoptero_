namespace splash
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.helicoptero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helicoptero)).BeginInit();
            this.SuspendLayout();
            // 
            // helicoptero
            // 
            this.helicoptero.BackColor = System.Drawing.Color.Transparent;
            this.helicoptero.Image = ((System.Drawing.Image)(resources.GetObject("helicoptero.Image")));
            this.helicoptero.Location = new System.Drawing.Point(12, 1);
            this.helicoptero.Name = "helicoptero";
            this.helicoptero.Size = new System.Drawing.Size(177, 162);
            this.helicoptero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helicoptero.TabIndex = 0;
            this.helicoptero.TabStop = false;
            this.helicoptero.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 502);
            this.Controls.Add(this.helicoptero);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.helicoptero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox helicoptero;
    }
}