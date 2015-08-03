namespace HiFiPrototype
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
            this.Open = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.HighLight = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Share = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.Location = new System.Drawing.Point(148, 7);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 73);
            this.Open.TabIndex = 0;
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Upload
            // 
            this.Upload.Image = ((System.Drawing.Image)(resources.GetObject("Upload.Image")));
            this.Upload.Location = new System.Drawing.Point(263, 7);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 73);
            this.Upload.TabIndex = 1;
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // HighLight
            // 
            this.HighLight.Image = ((System.Drawing.Image)(resources.GetObject("HighLight.Image")));
            this.HighLight.Location = new System.Drawing.Point(416, 7);
            this.HighLight.Name = "HighLight";
            this.HighLight.Size = new System.Drawing.Size(75, 73);
            this.HighLight.TabIndex = 2;
            this.HighLight.UseVisualStyleBackColor = true;
            this.HighLight.Click += new System.EventHandler(this.HighLight_Click);
            // 
            // Find
            // 
            this.Find.Image = ((System.Drawing.Image)(resources.GetObject("Find.Image")));
            this.Find.Location = new System.Drawing.Point(531, 7);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 73);
            this.Find.TabIndex = 3;
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.button4_Click);
            // 
            // Share
            // 
            this.Share.Image = ((System.Drawing.Image)(resources.GetObject("Share.Image")));
            this.Share.Location = new System.Drawing.Point(643, 7);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(75, 73);
            this.Share.TabIndex = 4;
            this.Share.UseVisualStyleBackColor = true;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(35, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(683, 290);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(730, 397);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Share);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.HighLight);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Open);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Make Your Notes Work For You";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button HighLight;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Share;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

