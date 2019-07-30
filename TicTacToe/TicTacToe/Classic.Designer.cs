namespace TicTacToe
{
    partial class Classic
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
            this.Reset_StartBtn = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset_StartBtn
            // 
            this.Reset_StartBtn.Location = new System.Drawing.Point(13, 13);
            this.Reset_StartBtn.Name = "Reset_StartBtn";
            this.Reset_StartBtn.Size = new System.Drawing.Size(99, 43);
            this.Reset_StartBtn.TabIndex = 0;
            this.Reset_StartBtn.Text = "I\'m Ready!";
            this.Reset_StartBtn.UseVisualStyleBackColor = true;
            this.Reset_StartBtn.Click += new System.EventHandler(this.Set_StartBtn);
            // 
            // a1
            // 
            this.a1.Enabled = false;
            this.a1.Location = new System.Drawing.Point(13, 62);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(128, 86);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.BtnClicker);
            // 
            // a2
            // 
            this.a2.Enabled = false;
            this.a2.Location = new System.Drawing.Point(147, 62);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(128, 86);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.BtnClicker);
            // 
            // a3
            // 
            this.a3.Enabled = false;
            this.a3.Location = new System.Drawing.Point(281, 62);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(128, 86);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.BtnClicker);
            // 
            // b3
            // 
            this.b3.Enabled = false;
            this.b3.Location = new System.Drawing.Point(281, 154);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(128, 86);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.BtnClicker);
            // 
            // b2
            // 
            this.b2.Enabled = false;
            this.b2.Location = new System.Drawing.Point(147, 154);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(128, 86);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.BtnClicker);
            // 
            // b1
            // 
            this.b1.Enabled = false;
            this.b1.Location = new System.Drawing.Point(13, 154);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(128, 86);
            this.b1.TabIndex = 4;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.BtnClicker);
            // 
            // c3
            // 
            this.c3.Enabled = false;
            this.c3.Location = new System.Drawing.Point(281, 246);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(128, 86);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.BtnClicker);
            // 
            // c2
            // 
            this.c2.Enabled = false;
            this.c2.Location = new System.Drawing.Point(147, 246);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(128, 86);
            this.c2.TabIndex = 8;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.BtnClicker);
            // 
            // c1
            // 
            this.c1.Enabled = false;
            this.c1.Location = new System.Drawing.Point(13, 246);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(128, 86);
            this.c1.TabIndex = 7;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.BtnClicker);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player X is First";
            // 
            // Classic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(426, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.Reset_StartBtn);
            this.Name = "Classic";
            this.Text = "Classic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Classic_FormClosed);
            this.Load += new System.EventHandler(this.Classic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
    }
}