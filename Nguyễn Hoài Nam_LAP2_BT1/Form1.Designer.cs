namespace Nguyễn_Hoài_Nam_LAP2_BT1
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
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumber2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumber2.Location = new System.Drawing.Point(40, 188);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(53, 13);
            this.lblNumber2.TabIndex = 0;
            this.lblNumber2.Text = "Number 2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(124, 128);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(180, 20);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAdd.Location = new System.Drawing.Point(124, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(124, 297);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(180, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(124, 181);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(180, 20);
            this.txtNumber2.TabIndex = 7;
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber2_KeyPress);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAnswer.Location = new System.Drawing.Point(40, 304);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Answer";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumber1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumber1.Location = new System.Drawing.Point(40, 135);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(53, 13);
            this.lblNumber1.TabIndex = 9;
            this.lblNumber1.Text = "Number 1";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSub.Location = new System.Drawing.Point(175, 252);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(23, 23);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMul.Location = new System.Drawing.Point(224, 252);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(23, 23);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDiv.Location = new System.Drawing.Point(271, 252);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(23, 23);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThongTin.Location = new System.Drawing.Point(390, 128);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(232, 96);
            this.lblThongTin.TabIndex = 13;
            this.lblThongTin.Text = "Họ tên: Nguyễn Hoài Nam\r\nMSSV: 2380601398\r\nLớp: 23DTHE1\r\n\r\n";
            // 
            // lblName
            // 
            this.lblName.AllowDrop = true;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(183, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(229, 55);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Máy Tính";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 378);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02-Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblName;
    }
}

