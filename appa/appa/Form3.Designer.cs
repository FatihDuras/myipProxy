namespace appa
{
    partial class Form3
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
            this.btn_kulguncelle = new System.Windows.Forms.Button();
            this.btn_ksil = new System.Windows.Forms.Button();
            this.kulkaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtkulpin = new System.Windows.Forms.TextBox();
            this.txtkulad = new System.Windows.Forms.TextBox();
            this.txtkıd = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kulguncelle
            // 
            this.btn_kulguncelle.Location = new System.Drawing.Point(107, 275);
            this.btn_kulguncelle.Name = "btn_kulguncelle";
            this.btn_kulguncelle.Size = new System.Drawing.Size(128, 23);
            this.btn_kulguncelle.TabIndex = 23;
            this.btn_kulguncelle.Text = "Kullanıcı Güncelle";
            this.btn_kulguncelle.UseVisualStyleBackColor = true;
            this.btn_kulguncelle.Click += new System.EventHandler(this.btn_kulguncelle_Click);
            // 
            // btn_ksil
            // 
            this.btn_ksil.Location = new System.Drawing.Point(107, 231);
            this.btn_ksil.Name = "btn_ksil";
            this.btn_ksil.Size = new System.Drawing.Size(128, 23);
            this.btn_ksil.TabIndex = 22;
            this.btn_ksil.Text = "Kullanıcı Sil";
            this.btn_ksil.UseVisualStyleBackColor = true;
            this.btn_ksil.Click += new System.EventHandler(this.btn_ksil_Click);
            // 
            // kulkaydet
            // 
            this.kulkaydet.Location = new System.Drawing.Point(107, 192);
            this.kulkaydet.Name = "kulkaydet";
            this.kulkaydet.Size = new System.Drawing.Size(128, 23);
            this.kulkaydet.TabIndex = 21;
            this.kulkaydet.Text = "Kullanıcı Ekle";
            this.kulkaydet.UseVisualStyleBackColor = true;
            this.kulkaydet.Click += new System.EventHandler(this.kulkaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kayıt Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pin Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(461, 262);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtkulpin
            // 
            this.txtkulpin.Location = new System.Drawing.Point(107, 106);
            this.txtkulpin.Name = "txtkulpin";
            this.txtkulpin.Size = new System.Drawing.Size(100, 23);
            this.txtkulpin.TabIndex = 14;
            // 
            // txtkulad
            // 
            this.txtkulad.Location = new System.Drawing.Point(107, 68);
            this.txtkulad.Name = "txtkulad";
            this.txtkulad.Size = new System.Drawing.Size(100, 23);
            this.txtkulad.TabIndex = 13;
            // 
            // txtkıd
            // 
            this.txtkıd.Enabled = false;
            this.txtkıd.Location = new System.Drawing.Point(107, 29);
            this.txtkıd.Name = "txtkıd";
            this.txtkıd.Size = new System.Drawing.Size(100, 23);
            this.txtkıd.TabIndex = 12;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(107, 320);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(133, 23);
            this.btn_temizle.TabIndex = 24;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kulguncelle);
            this.Controls.Add(this.btn_ksil);
            this.Controls.Add(this.kulkaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkulpin);
            this.Controls.Add(this.txtkulad);
            this.Controls.Add(this.txtkıd);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_kulguncelle;
        private Button btn_ksil;
        private Button kulkaydet;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private TextBox txtkulpin;
        private TextBox txtkulad;
        private TextBox txtkıd;
        private Button btn_temizle;
    }
}