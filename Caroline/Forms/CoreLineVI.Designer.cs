namespace Caroline.Forms
{
    partial class CoreLineVi
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
            this.la_Name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_Load = new System.Windows.Forms.PictureBox();
            this.la_subLoad = new System.Windows.Forms.Label();
            this.la_Face = new System.Windows.Forms.Label();
            this.faceUpdate = new System.Windows.Forms.Timer(this.components);
            this.la_text = new System.Windows.Forms.Label();
            this.pa_load = new System.Windows.Forms.Panel();
            this.la_state = new System.Windows.Forms.Label();
            this.b_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Load)).BeginInit();
            this.pa_load.SuspendLayout();
            this.SuspendLayout();
            // 
            // la_Name
            // 
            this.la_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.la_Name.AutoSize = true;
            this.la_Name.BackColor = System.Drawing.Color.Black;
            this.la_Name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Name.ForeColor = System.Drawing.Color.White;
            this.la_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.la_Name.Location = new System.Drawing.Point(73, 3);
            this.la_Name.Name = "la_Name";
            this.la_Name.Size = new System.Drawing.Size(134, 37);
            this.la_Name.TabIndex = 0;
            this.la_Name.Text = "CoreLine..";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_Load
            // 
            this.pb_Load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_Load.Image = global::Caroline.Properties.Resources.load3;
            this.pb_Load.Location = new System.Drawing.Point(3, 3);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(64, 64);
            this.pb_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Load.TabIndex = 1;
            this.pb_Load.TabStop = false;
            this.pb_Load.UseWaitCursor = true;
            // 
            // la_subLoad
            // 
            this.la_subLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.la_subLoad.AutoSize = true;
            this.la_subLoad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_subLoad.ForeColor = System.Drawing.Color.White;
            this.la_subLoad.Location = new System.Drawing.Point(73, 40);
            this.la_subLoad.Name = "la_subLoad";
            this.la_subLoad.Size = new System.Drawing.Size(51, 13);
            this.la_subLoad.TabIndex = 2;
            this.la_subLoad.Text = "Запуск...";
            this.la_subLoad.UseWaitCursor = true;
            // 
            // la_Face
            // 
            this.la_Face.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_Face.ForeColor = System.Drawing.Color.White;
            this.la_Face.Location = new System.Drawing.Point(2, 128);
            this.la_Face.Name = "la_Face";
            this.la_Face.Size = new System.Drawing.Size(501, 128);
            this.la_Face.TabIndex = 0;
            this.la_Face.Text = "ʘ‿ʘ";
            this.la_Face.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.la_Face.Visible = false;
            // 
            // faceUpdate
            // 
            this.faceUpdate.Interval = 500;
            this.faceUpdate.Tick += new System.EventHandler(this.faceupdate_Tick);
            // 
            // la_text
            // 
            this.la_text.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.la_text.AutoSize = true;
            this.la_text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_text.ForeColor = System.Drawing.Color.White;
            this.la_text.Location = new System.Drawing.Point(12, 317);
            this.la_text.Name = "la_text";
            this.la_text.Size = new System.Drawing.Size(50, 20);
            this.la_text.TabIndex = 4;
            this.la_text.Text = "label1";
            this.la_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.la_text.Visible = false;
            // 
            // pa_load
            // 
            this.pa_load.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pa_load.BackColor = System.Drawing.Color.Black;
            this.pa_load.Controls.Add(this.pb_Load);
            this.pa_load.Controls.Add(this.la_Name);
            this.pa_load.Controls.Add(this.la_subLoad);
            this.pa_load.Location = new System.Drawing.Point(12, 12);
            this.pa_load.Name = "pa_load";
            this.pa_load.Size = new System.Drawing.Size(215, 71);
            this.pa_load.TabIndex = 5;
            // 
            // la_state
            // 
            this.la_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.la_state.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_state.ForeColor = System.Drawing.Color.White;
            this.la_state.Location = new System.Drawing.Point(268, 9);
            this.la_state.Name = "la_state";
            this.la_state.Size = new System.Drawing.Size(227, 23);
            this.la_state.TabIndex = 6;
            this.la_state.Text = "Loading...";
            this.la_state.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // b_1
            // 
            this.b_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.b_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_1.ForeColor = System.Drawing.Color.White;
            this.b_1.Location = new System.Drawing.Point(420, 311);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(75, 23);
            this.b_1.TabIndex = 7;
            this.b_1.Text = "Exit";
            this.b_1.UseVisualStyleBackColor = false;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // CoreLineVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 346);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.la_state);
            this.Controls.Add(this.pa_load);
            this.Controls.Add(this.la_text);
            this.Controls.Add(this.la_Face);
            this.Name = "CoreLineVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoreLineVI";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Load)).EndInit();
            this.pa_load.ResumeLayout(false);
            this.pa_load.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_Name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_Load;
        private System.Windows.Forms.Label la_subLoad;
        private System.Windows.Forms.Label la_Face;
        private System.Windows.Forms.Timer faceUpdate;
        private System.Windows.Forms.Label la_text;
        private System.Windows.Forms.Panel pa_load;
        private System.Windows.Forms.Label la_state;
        private System.Windows.Forms.Button b_1;
    }
}