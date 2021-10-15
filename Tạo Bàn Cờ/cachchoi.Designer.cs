
namespace Tạo_Bàn_Cờ
{
    partial class cachchoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cachchoi));
            this.nguyencute = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nguyencute
            // 
            this.nguyencute.BackColor = System.Drawing.Color.Transparent;
            this.nguyencute.Font = new System.Drawing.Font("LNTH-Sofadi One", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nguyencute.ForeColor = System.Drawing.Color.Maroon;
            this.nguyencute.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nguyencute.Location = new System.Drawing.Point(62, 0);
            this.nguyencute.Margin = new System.Windows.Forms.Padding(0, 4, 0, 5);
            this.nguyencute.Name = "nguyencute";
            this.nguyencute.Size = new System.Drawing.Size(631, 108);
            this.nguyencute.TabIndex = 0;
            this.nguyencute.Text = "Hướng dẫn cách chơi";
            this.nguyencute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(62, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 269);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // cachchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nguyencute);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(777, 506);
            this.Name = "cachchoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cachchoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cachchoi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nguyencute;
        private System.Windows.Forms.TextBox textBox1;
    }
}