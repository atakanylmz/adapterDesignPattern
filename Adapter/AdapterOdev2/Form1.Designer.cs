namespace AdapterOdev2
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
            this.btnTank = new System.Windows.Forms.Button();
            this.btnRobot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTank
            // 
            this.btnTank.Location = new System.Drawing.Point(37, 92);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(75, 23);
            this.btnTank.TabIndex = 0;
            this.btnTank.Text = "Tank kullan";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            // 
            // btnRobot
            // 
            this.btnRobot.Location = new System.Drawing.Point(151, 92);
            this.btnRobot.Name = "btnRobot";
            this.btnRobot.Size = new System.Drawing.Size(75, 23);
            this.btnRobot.TabIndex = 0;
            this.btnRobot.Text = "Robot kullan";
            this.btnRobot.UseVisualStyleBackColor = true;
            this.btnRobot.Click += new System.EventHandler(this.btnRobot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRobot);
            this.Controls.Add(this.btnTank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Button btnRobot;
    }
}

