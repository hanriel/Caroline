namespace Caroline
{
    partial class CoreLine
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
            this.b_VI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_VI
            // 
            this.b_VI.Location = new System.Drawing.Point(12, 12);
            this.b_VI.Name = "b_VI";
            this.b_VI.Size = new System.Drawing.Size(260, 237);
            this.b_VI.TabIndex = 0;
            this.b_VI.Text = "CarolineVI";
            this.b_VI.UseVisualStyleBackColor = true;
            this.b_VI.Click += new System.EventHandler(this.b_VI_Click);
            // 
            // CoreLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_VI);
            this.Name = "CoreLine";
            this.Text = "CoreLine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_VI;
    }
}

