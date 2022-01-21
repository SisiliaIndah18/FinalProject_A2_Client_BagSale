
namespace ClientBagSale
{
    partial class Register
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
            this.btHapus = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.dtRegister = new System.Windows.Forms.DataGridView();
            this.btClear = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(613, 188);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 35);
            this.btHapus.TabIndex = 27;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(613, 137);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 35);
            this.btUpdate.TabIndex = 26;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "Admin",
            "Buyer"});
            this.comboBoxKategori.Location = new System.Drawing.Point(328, 218);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(223, 24);
            this.comboBoxKategori.TabIndex = 25;
            // 
            // dtRegister
            // 
            this.dtRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegister.Location = new System.Drawing.Point(115, 291);
            this.dtRegister.Name = "dtRegister";
            this.dtRegister.RowHeadersWidth = 51;
            this.dtRegister.RowTemplate.Height = 24;
            this.dtRegister.Size = new System.Drawing.Size(573, 140);
            this.dtRegister.TabIndex = 24;
            this.dtRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegister_CellClick);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(613, 240);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 35);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(613, 72);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 35);
            this.btSimpan.TabIndex = 22;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(383, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(305, 22);
            this.textBoxID.TabIndex = 21;
            this.textBoxID.Text = "TB ini hanya sebagai penyimpanan ID sementara ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(328, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(223, 22);
            this.textBoxPassword.TabIndex = 20;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(328, 85);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(223, 22);
            this.textBoxUsername.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.dtRegister);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.DataGridView dtRegister;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}