
namespace UpworkProject
{
    partial class FileUploadWithResize
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.Label();
            this.Extension = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.OrgPath = new System.Windows.Forms.Label();
            this.compressed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 203);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Preview";
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(449, 104);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(55, 13);
            this.filename.TabIndex = 3;
            this.filename.Text = "Filename: ";
            // 
            // Extension
            // 
            this.Extension.AutoSize = true;
            this.Extension.Location = new System.Drawing.Point(449, 135);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(53, 13);
            this.Extension.TabIndex = 4;
            this.Extension.Text = "Extension";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(449, 187);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(27, 13);
            this.Size.TabIndex = 5;
            this.Size.Text = "Size";
            // 
            // OrgPath
            // 
            this.OrgPath.AutoSize = true;
            this.OrgPath.Location = new System.Drawing.Point(449, 162);
            this.OrgPath.Name = "OrgPath";
            this.OrgPath.Size = new System.Drawing.Size(67, 13);
            this.OrgPath.TabIndex = 6;
            this.OrgPath.Text = "Original Path";
            // 
            // compressed
            // 
            this.compressed.AutoSize = true;
            this.compressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressed.Location = new System.Drawing.Point(449, 215);
            this.compressed.Name = "compressed";
            this.compressed.Size = new System.Drawing.Size(45, 25);
            this.compressed.TabIndex = 7;
            this.compressed.Text = "123";
            this.compressed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 391);
            this.Controls.Add(this.compressed);
            this.Controls.Add(this.OrgPath);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Extension);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Upwork Project";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label Extension;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label OrgPath;
        private System.Windows.Forms.Label compressed;
    }
}

