namespace HiFiPrototype
{
    partial class UploadForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadForm2 = new System.Windows.Forms.Button();
            this.btnCancelUploadForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // btnUploadForm2
            // 
            this.btnUploadForm2.Location = new System.Drawing.Point(434, 227);
            this.btnUploadForm2.Name = "btnUploadForm2";
            this.btnUploadForm2.Size = new System.Drawing.Size(75, 23);
            this.btnUploadForm2.TabIndex = 2;
            this.btnUploadForm2.Text = "Upload";
            this.btnUploadForm2.UseVisualStyleBackColor = true;
            // 
            // btnCancelUploadForm2
            // 
            this.btnCancelUploadForm2.Location = new System.Drawing.Point(515, 228);
            this.btnCancelUploadForm2.Name = "btnCancelUploadForm2";
            this.btnCancelUploadForm2.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUploadForm2.TabIndex = 3;
            this.btnCancelUploadForm2.Text = "Cancel";
            this.btnCancelUploadForm2.UseVisualStyleBackColor = true;
            this.btnCancelUploadForm2.Click += new System.EventHandler(this.btnCancelUploadForm2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UploadForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelUploadForm2);
            this.Controls.Add(this.btnUploadForm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UploadForm2";
            this.Text = "Upload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadForm2;
        private System.Windows.Forms.Button btnCancelUploadForm2;
        private System.Windows.Forms.TextBox textBox1;
    }
}