namespace volleyball_problem
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
            this.BtnHitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.RichTextBox();
            this.TxtHasil = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHitung
            // 
            this.BtnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHitung.Location = new System.Drawing.Point(281, 94);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(92, 48);
            this.BtnHitung.TabIndex = 1;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.Location = new System.Drawing.Point(12, 74);
            this.Txt1.MaxLength = 2;
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 96);
            this.Txt1.TabIndex = 3;
            this.Txt1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // Txt2
            // 
            this.Txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt2.Location = new System.Drawing.Point(154, 71);
            this.Txt2.MaxLength = 2;
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 96);
            this.Txt2.TabIndex = 3;
            this.Txt2.Text = "";
            // 
            // TxtHasil
            // 
            this.TxtHasil.Enabled = false;
            this.TxtHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHasil.Location = new System.Drawing.Point(400, 71);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(247, 96);
            this.TxtHasil.TabIndex = 4;
            this.TxtHasil.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score Combination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 228);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHitung);
            this.Name = "Form1";
            this.Text = "Volleyball Score Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Txt2;
        private System.Windows.Forms.RichTextBox TxtHasil;
        private System.Windows.Forms.Label label3;
    }
}

