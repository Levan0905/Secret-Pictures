namespace SecretPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonshowPicture1 = new System.Windows.Forms.Button();
            this.buttonshowpicture2 = new System.Windows.Forms.Button();
            this.buttonshowpicture3 = new System.Windows.Forms.Button();
            this.buttonshowpicture4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonshowPicture1
            // 
            this.buttonshowPicture1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonshowPicture1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowPicture1.Location = new System.Drawing.Point(12, 12);
            this.buttonshowPicture1.Name = "buttonshowPicture1";
            this.buttonshowPicture1.Size = new System.Drawing.Size(75, 23);
            this.buttonshowPicture1.TabIndex = 0;
            this.buttonshowPicture1.Text = "field";
            this.buttonshowPicture1.UseVisualStyleBackColor = false;
            this.buttonshowPicture1.Click += new System.EventHandler(this.buttonshowPicture1_Click);
            // 
            // buttonshowpicture2
            // 
            this.buttonshowpicture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonshowpicture2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowpicture2.Location = new System.Drawing.Point(297, 12);
            this.buttonshowpicture2.Name = "buttonshowpicture2";
            this.buttonshowpicture2.Size = new System.Drawing.Size(75, 23);
            this.buttonshowpicture2.TabIndex = 1;
            this.buttonshowpicture2.Text = "lake";
            this.buttonshowpicture2.UseVisualStyleBackColor = true;
            this.buttonshowpicture2.Click += new System.EventHandler(this.buttonshowpicture3_Click);
            // 
            // buttonshowpicture3
            // 
            this.buttonshowpicture3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonshowpicture3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowpicture3.Location = new System.Drawing.Point(12, 210);
            this.buttonshowpicture3.Name = "buttonshowpicture3";
            this.buttonshowpicture3.Size = new System.Drawing.Size(75, 23);
            this.buttonshowpicture3.TabIndex = 2;
            this.buttonshowpicture3.Text = "river";
            this.buttonshowpicture3.UseVisualStyleBackColor = true;
            this.buttonshowpicture3.Click += new System.EventHandler(this.buttonshowpicture3_Click_1);
            // 
            // buttonshowpicture4
            // 
            this.buttonshowpicture4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonshowpicture4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowpicture4.Location = new System.Drawing.Point(297, 210);
            this.buttonshowpicture4.Name = "buttonshowpicture4";
            this.buttonshowpicture4.Size = new System.Drawing.Size(75, 23);
            this.buttonshowpicture4.TabIndex = 3;
            this.buttonshowpicture4.Text = "road";
            this.buttonshowpicture4.UseVisualStyleBackColor = true;
            this.buttonshowpicture4.Click += new System.EventHandler(this.buttonshowpicture4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonshowpicture4);
            this.Controls.Add(this.buttonshowpicture3);
            this.Controls.Add(this.buttonshowpicture2);
            this.Controls.Add(this.buttonshowPicture1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The picture with a secret";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonshowPicture1;
        private System.Windows.Forms.Button buttonshowpicture2;
        private System.Windows.Forms.Button buttonshowpicture3;
        private System.Windows.Forms.Button buttonshowpicture4;
    }
}

