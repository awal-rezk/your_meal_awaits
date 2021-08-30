
namespace DinerApplication
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
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundImage1 = new System.Windows.Forms.PictureBox();
            this.welcome_txt_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.Location = new System.Drawing.Point(333, 334);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // backgroundImage1
            // 
            this.backgroundImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImage1.Image = ((System.Drawing.Image)(resources.GetObject("backgroundImage1.Image")));
            this.backgroundImage1.Location = new System.Drawing.Point(0, 0);
            this.backgroundImage1.Name = "backgroundImage1";
            this.backgroundImage1.Size = new System.Drawing.Size(800, 450);
            this.backgroundImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage1.TabIndex = 1;
            this.backgroundImage1.TabStop = false;
            this.backgroundImage1.Click += new System.EventHandler(this.backgroundImage1_Click);
            // 
            // welcome_txt_box
            // 
            this.welcome_txt_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_txt_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome_txt_box.ForeColor = System.Drawing.Color.LightCoral;
            this.welcome_txt_box.Location = new System.Drawing.Point(0, 0);
            this.welcome_txt_box.Name = "welcome_txt_box";
            this.welcome_txt_box.Size = new System.Drawing.Size(800, 13);
            this.welcome_txt_box.TabIndex = 2;
            this.welcome_txt_box.Text = "Welcome To Our Diner!";
            this.welcome_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.welcome_txt_box.TextChanged += new System.EventHandler(this.welcome_txt_box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_txt_box);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.backgroundImage1);
            this.Name = "Form1";
            this.Text = "Your Meal Awaits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox backgroundImage1;
        private System.Windows.Forms.TextBox welcome_txt_box;
    }
}

