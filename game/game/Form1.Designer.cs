namespace game1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMansoor = new System.Windows.Forms.TextBox();
            this.txtSamuel = new System.Windows.Forms.TextBox();
            this.txtComplete = new System.Windows.Forms.TextBox();
            this.txtSuvash = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.52941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47059F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMansoor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSamuel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtComplete, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSuvash, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Suvash";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(162, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mansoor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(162, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Complete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMansoor
            // 
            this.txtMansoor.Location = new System.Drawing.Point(3, 96);
            this.txtMansoor.Multiline = true;
            this.txtMansoor.Name = "txtMansoor";
            this.txtMansoor.Size = new System.Drawing.Size(131, 64);
            this.txtMansoor.TabIndex = 4;
            // 
            // txtSamuel
            // 
            this.txtSamuel.Location = new System.Drawing.Point(162, 3);
            this.txtSamuel.Multiline = true;
            this.txtSamuel.Name = "txtSamuel";
            this.txtSamuel.Size = new System.Drawing.Size(112, 64);
            this.txtSamuel.TabIndex = 5;
            this.txtSamuel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtComplete
            // 
            this.txtComplete.Location = new System.Drawing.Point(162, 189);
            this.txtComplete.Multiline = true;
            this.txtComplete.Name = "txtComplete";
            this.txtComplete.Size = new System.Drawing.Size(112, 54);
            this.txtComplete.TabIndex = 6;
            this.txtComplete.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSuvash
            // 
            this.txtSuvash.Location = new System.Drawing.Point(3, 249);
            this.txtSuvash.Multiline = true;
            this.txtSuvash.Name = "txtSuvash";
            this.txtSuvash.Size = new System.Drawing.Size(131, 63);
            this.txtSuvash.TabIndex = 7;
            this.txtSuvash.TextChanged += new System.EventHandler(this.txtSuvash_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(3, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Samuel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(36, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Lime;
            this.btnexit.Location = new System.Drawing.Point(178, 345);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 33);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(351, 391);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMansoor;
        private System.Windows.Forms.TextBox txtSamuel;
        private System.Windows.Forms.TextBox txtComplete;
        private System.Windows.Forms.TextBox txtSuvash;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnexit;
    }
}

