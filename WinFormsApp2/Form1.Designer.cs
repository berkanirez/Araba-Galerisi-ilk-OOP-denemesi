namespace WinFormsApp2
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
            bttnEkle = new Button();
            lblMarka = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            lblModel = new Label();
            txtRenk = new TextBox();
            lblRenk = new Label();
            bttnListele = new Button();
            txtArabalar = new TextBox();
            dataAraba = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataAraba).BeginInit();
            SuspendLayout();
            // 
            // bttnEkle
            // 
            bttnEkle.Location = new Point(303, 193);
            bttnEkle.Name = "bttnEkle";
            bttnEkle.Size = new Size(253, 29);
            bttnEkle.TabIndex = 0;
            bttnEkle.Text = "Ekle";
            bttnEkle.UseVisualStyleBackColor = true;
            bttnEkle.Click += bttnEkle_Click;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(219, 58);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(50, 20);
            lblMarka.TabIndex = 1;
            lblMarka.Text = "Marka";
            lblMarka.Click += label1_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(303, 55);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(253, 27);
            txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(303, 99);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(253, 27);
            txtModel.TabIndex = 4;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(219, 102);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model\r\n";
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(303, 147);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(253, 27);
            txtRenk.TabIndex = 6;
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(219, 150);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(41, 20);
            lblRenk.TabIndex = 5;
            lblRenk.Text = "Renk";
            // 
            // bttnListele
            // 
            bttnListele.Location = new Point(219, 251);
            bttnListele.Name = "bttnListele";
            bttnListele.Size = new Size(334, 29);
            bttnListele.TabIndex = 7;
            bttnListele.Text = "Listele";
            bttnListele.UseVisualStyleBackColor = true;
            bttnListele.Click += bttnListele_Click;
            // 
            // txtArabalar
            // 
            txtArabalar.Location = new Point(219, 286);
            txtArabalar.Multiline = true;
            txtArabalar.Name = "txtArabalar";
            txtArabalar.Size = new Size(334, 152);
            txtArabalar.TabIndex = 8;
            // 
            // dataAraba
            // 
            dataAraba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAraba.Location = new Point(219, 461);
            dataAraba.Name = "dataAraba";
            dataAraba.RowHeadersWidth = 51;
            dataAraba.Size = new Size(334, 172);
            dataAraba.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 697);
            Controls.Add(dataAraba);
            Controls.Add(txtArabalar);
            Controls.Add(bttnListele);
            Controls.Add(txtRenk);
            Controls.Add(lblRenk);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtMarka);
            Controls.Add(lblMarka);
            Controls.Add(bttnEkle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataAraba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnEkle;
        private Label lblMarka;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtRenk;
        private Label lblRenk;
        private Button bttnListele;
        private TextBox txtArabalar;
        private DataGridView dataAraba;
    }
}
