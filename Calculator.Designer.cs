namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vypocitej = new System.Windows.Forms.Button();
            this.rbtnPrimaUmernost = new System.Windows.Forms.RadioButton();
            this.rbtnNeprimaUmernost = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(29, 42);
            this.txtX.MaxLength = 5;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(192, 42);
            this.txtY.MaxLength = 5;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(29, 79);
            this.txtZ.MaxLength = 5;
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 20);
            this.txtZ.TabIndex = 2;
            this.txtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "...............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "................";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(196, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "?????";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Zadejte hodnoty:";
            // 
            // vypocitej
            // 
            this.vypocitej.Location = new System.Drawing.Point(171, 9);
            this.vypocitej.Name = "vypocitej";
            this.vypocitej.Size = new System.Drawing.Size(75, 23);
            this.vypocitej.TabIndex = 9;
            this.vypocitej.Text = "Vypočítat";
            this.vypocitej.UseVisualStyleBackColor = true;
            this.vypocitej.Click += new System.EventHandler(this.vypocitej_Click);
            // 
            // rbtnPrimaUmernost
            // 
            this.rbtnPrimaUmernost.AutoSize = true;
            this.rbtnPrimaUmernost.Checked = true;
            this.rbtnPrimaUmernost.Location = new System.Drawing.Point(3, 6);
            this.rbtnPrimaUmernost.Name = "rbtnPrimaUmernost";
            this.rbtnPrimaUmernost.Size = new System.Drawing.Size(100, 17);
            this.rbtnPrimaUmernost.TabIndex = 10;
            this.rbtnPrimaUmernost.TabStop = true;
            this.rbtnPrimaUmernost.Text = "Přímá úměrnost";
            this.rbtnPrimaUmernost.UseVisualStyleBackColor = true;
            // 
            // rbtnNeprimaUmernost
            // 
            this.rbtnNeprimaUmernost.AutoSize = true;
            this.rbtnNeprimaUmernost.Location = new System.Drawing.Point(109, 6);
            this.rbtnNeprimaUmernost.Name = "rbtnNeprimaUmernost";
            this.rbtnNeprimaUmernost.Size = new System.Drawing.Size(113, 17);
            this.rbtnNeprimaUmernost.TabIndex = 11;
            this.rbtnNeprimaUmernost.Text = "Nepřímá úměrnost";
            this.rbtnNeprimaUmernost.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnNeprimaUmernost);
            this.panel1.Controls.Add(this.rbtnPrimaUmernost);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 30);
            this.panel1.TabIndex = 12;
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.Image = global::Calculator.Properties.Resources.help_icon;
            this.btnHelp.Location = new System.Drawing.Point(267, 9);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 24);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 153);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vypocitej);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Trojčlenka";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button vypocitej;
        private System.Windows.Forms.RadioButton rbtnPrimaUmernost;
        private System.Windows.Forms.RadioButton rbtnNeprimaUmernost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHelp;
    }
}

