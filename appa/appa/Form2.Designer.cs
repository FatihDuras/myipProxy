namespace appa
{
    partial class Form2
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
            this.btn_getir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_getir.Location = new System.Drawing.Point(35, 296);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(394, 61);
            this.btn_getir.TabIndex = 1;
            this.btn_getir.Text = "Kaynak Kodunu Getir";
            this.btn_getir.UseVisualStyleBackColor = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 190);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site Linki Gir :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(35, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kaynak Kodounu Kopyala";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(479, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anlık Kullanıcı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(629, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "--";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(479, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 128);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browser\'a  Git";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_getir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_getir;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}