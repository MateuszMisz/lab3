namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodaj = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.zapis_do_csv = new System.Windows.Forms.Button();
            this.odczyt_z_csv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(360, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(606, 56);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(112, 34);
            this.dodaj.TabIndex = 1;
            this.dodaj.Text = "dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(606, 165);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(112, 34);
            this.usun.TabIndex = 2;
            this.usun.Text = "usun";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // zapis_do_csv
            // 
            this.zapis_do_csv.Location = new System.Drawing.Point(147, 350);
            this.zapis_do_csv.Name = "zapis_do_csv";
            this.zapis_do_csv.Size = new System.Drawing.Size(186, 34);
            this.zapis_do_csv.TabIndex = 3;
            this.zapis_do_csv.Text = "zapis do csv";
            this.zapis_do_csv.UseVisualStyleBackColor = true;
            this.zapis_do_csv.Click += new System.EventHandler(this.zapis_do_csv_Click);
            // 
            // odczyt_z_csv
            // 
            this.odczyt_z_csv.Location = new System.Drawing.Point(546, 350);
            this.odczyt_z_csv.Name = "odczyt_z_csv";
            this.odczyt_z_csv.Size = new System.Drawing.Size(211, 34);
            this.odczyt_z_csv.TabIndex = 4;
            this.odczyt_z_csv.Text = "odczyt z csv";
            this.odczyt_z_csv.UseVisualStyleBackColor = true;
            this.odczyt_z_csv.Click += new System.EventHandler(this.odczyt_z_csv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odczyt_z_csv);
            this.Controls.Add(this.zapis_do_csv);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridView1;
        private Button dodaj;
        private Button usun;
        private Button zapis_do_csv;
        private Button odczyt_z_csv;
    }
}