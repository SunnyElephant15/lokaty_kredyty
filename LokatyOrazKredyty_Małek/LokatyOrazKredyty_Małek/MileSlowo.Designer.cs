namespace LokatyOrazKredyty_Małek
{
    partial class MileSlowo
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
            this.label1 = new System.Windows.Forms.Label();
            this.KmbtnOczywiscie = new System.Windows.Forms.Button();
            this.KMbtnNie = new System.Windows.Forms.Button();
            this.KMlblTak = new System.Windows.Forms.Label();
            this.KMlblNie = new System.Windows.Forms.Label();
            this.KMbtnPowrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czy Twoj dzien przebiega dobrze?";
            // 
            // KmbtnOczywiscie
            // 
            this.KmbtnOczywiscie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmbtnOczywiscie.Location = new System.Drawing.Point(239, 253);
            this.KmbtnOczywiscie.Name = "KmbtnOczywiscie";
            this.KmbtnOczywiscie.Size = new System.Drawing.Size(291, 128);
            this.KmbtnOczywiscie.TabIndex = 1;
            this.KmbtnOczywiscie.Text = "Oczywiscie!";
            this.KmbtnOczywiscie.UseVisualStyleBackColor = true;
            this.KmbtnOczywiscie.Click += new System.EventHandler(this.KmbtnOczywiscie_Click);
            // 
            // KMbtnNie
            // 
            this.KMbtnNie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMbtnNie.Location = new System.Drawing.Point(817, 253);
            this.KMbtnNie.Name = "KMbtnNie";
            this.KMbtnNie.Size = new System.Drawing.Size(291, 128);
            this.KMbtnNie.TabIndex = 2;
            this.KMbtnNie.Text = "Nie za bardzo...";
            this.KMbtnNie.UseVisualStyleBackColor = true;
            this.KMbtnNie.Click += new System.EventHandler(this.KMbtnNie_Click);
            // 
            // KMlblTak
            // 
            this.KMlblTak.AutoSize = true;
            this.KMlblTak.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMlblTak.Location = new System.Drawing.Point(79, 483);
            this.KMlblTak.Name = "KMlblTak";
            this.KMlblTak.Size = new System.Drawing.Size(332, 31);
            this.KMlblTak.TabIndex = 3;
            this.KMlblTak.Text = "Swietnie! Oby tak dalej! :D";
            this.KMlblTak.Visible = false;
            // 
            // KMlblNie
            // 
            this.KMlblNie.AutoSize = true;
            this.KMlblNie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMlblNie.Location = new System.Drawing.Point(545, 483);
            this.KMlblNie.Name = "KMlblNie";
            this.KMlblNie.Size = new System.Drawing.Size(771, 31);
            this.KMlblNie.TabIndex = 4;
            this.KMlblNie.Text = "Nie przejmuj sie! Po kazdej burzy przychodzi sloneczny dzien! :D";
            this.KMlblNie.Visible = false;
            // 
            // KMbtnPowrot
            // 
            this.KMbtnPowrot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KMbtnPowrot.Location = new System.Drawing.Point(629, 421);
            this.KMbtnPowrot.Name = "KMbtnPowrot";
            this.KMbtnPowrot.Size = new System.Drawing.Size(118, 36);
            this.KMbtnPowrot.TabIndex = 5;
            this.KMbtnPowrot.Text = "Powrot";
            this.KMbtnPowrot.UseVisualStyleBackColor = true;
            this.KMbtnPowrot.Click += new System.EventHandler(this.KMbtnPowrot_Click);
            // 
            // MileSlowo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1369, 622);
            this.Controls.Add(this.KMbtnPowrot);
            this.Controls.Add(this.KMlblNie);
            this.Controls.Add(this.KMlblTak);
            this.Controls.Add(this.KMbtnNie);
            this.Controls.Add(this.KmbtnOczywiscie);
            this.Controls.Add(this.label1);
            this.Name = "MileSlowo";
            this.Text = "MileSlowo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KmbtnOczywiscie;
        private System.Windows.Forms.Button KMbtnNie;
        private System.Windows.Forms.Label KMlblTak;
        private System.Windows.Forms.Label KMlblNie;
        private System.Windows.Forms.Button KMbtnPowrot;
    }
}