namespace meczKoszykowki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1PointTeam1 = new System.Windows.Forms.Button();
            this.btn1PointTeam2 = new System.Windows.Forms.Button();
            this.lblResultTeam1 = new System.Windows.Forms.Label();
            this.lblResultTeam2 = new System.Windows.Forms.Label();
            this.btn2PointsTeam1 = new System.Windows.Forms.Button();
            this.btn2PointsTeam2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1PointTeam1
            // 
            this.btn1PointTeam1.Location = new System.Drawing.Point(40, 88);
            this.btn1PointTeam1.Name = "btn1PointTeam1";
            this.btn1PointTeam1.Size = new System.Drawing.Size(75, 23);
            this.btn1PointTeam1.TabIndex = 0;
            this.btn1PointTeam1.Text = "+1";
            this.btn1PointTeam1.UseVisualStyleBackColor = true;
            this.btn1PointTeam1.Click += new System.EventHandler(this.btn1PointTeam1_Click);
            // 
            // btn1PointTeam2
            // 
            this.btn1PointTeam2.Location = new System.Drawing.Point(467, 88);
            this.btn1PointTeam2.Name = "btn1PointTeam2";
            this.btn1PointTeam2.Size = new System.Drawing.Size(75, 23);
            this.btn1PointTeam2.TabIndex = 1;
            this.btn1PointTeam2.Text = "+1";
            this.btn1PointTeam2.UseVisualStyleBackColor = true;
            this.btn1PointTeam2.Click += new System.EventHandler(this.btn1PointTeam2_Click);
            // 
            // lblResultTeam1
            // 
            this.lblResultTeam1.AutoSize = true;
            this.lblResultTeam1.Location = new System.Drawing.Point(229, 98);
            this.lblResultTeam1.Name = "lblResultTeam1";
            this.lblResultTeam1.Size = new System.Drawing.Size(35, 13);
            this.lblResultTeam1.TabIndex = 2;
            this.lblResultTeam1.Text = "label1";
            // 
            // lblResultTeam2
            // 
            this.lblResultTeam2.AutoSize = true;
            this.lblResultTeam2.Location = new System.Drawing.Point(338, 98);
            this.lblResultTeam2.Name = "lblResultTeam2";
            this.lblResultTeam2.Size = new System.Drawing.Size(35, 13);
            this.lblResultTeam2.TabIndex = 3;
            this.lblResultTeam2.Text = "label2";
            // 
            // btn2PointsTeam1
            // 
            this.btn2PointsTeam1.Location = new System.Drawing.Point(40, 143);
            this.btn2PointsTeam1.Name = "btn2PointsTeam1";
            this.btn2PointsTeam1.Size = new System.Drawing.Size(75, 23);
            this.btn2PointsTeam1.TabIndex = 4;
            this.btn2PointsTeam1.Text = "+2";
            this.btn2PointsTeam1.UseVisualStyleBackColor = true;
            this.btn2PointsTeam1.Click += new System.EventHandler(this.btn2PointsTeam1_Click);
            // 
            // btn2PointsTeam2
            // 
            this.btn2PointsTeam2.Location = new System.Drawing.Point(467, 143);
            this.btn2PointsTeam2.Name = "btn2PointsTeam2";
            this.btn2PointsTeam2.Size = new System.Drawing.Size(75, 23);
            this.btn2PointsTeam2.TabIndex = 5;
            this.btn2PointsTeam2.Text = "+2";
            this.btn2PointsTeam2.UseVisualStyleBackColor = true;
            this.btn2PointsTeam2.Click += new System.EventHandler(this.btn2PointsTeam2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wynik dla druzyny 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wynik dla druzyny 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2PointsTeam2);
            this.Controls.Add(this.btn2PointsTeam1);
            this.Controls.Add(this.lblResultTeam2);
            this.Controls.Add(this.lblResultTeam1);
            this.Controls.Add(this.btn1PointTeam2);
            this.Controls.Add(this.btn1PointTeam1);
            this.Name = "Form1";
            this.Text = "Mecz koszykowki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1PointTeam1;
        private System.Windows.Forms.Button btn1PointTeam2;
        private System.Windows.Forms.Label lblResultTeam1;
        private System.Windows.Forms.Label lblResultTeam2;
        private System.Windows.Forms.Button btn2PointsTeam1;
        private System.Windows.Forms.Button btn2PointsTeam2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

