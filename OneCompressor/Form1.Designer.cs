namespace OneCompressor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.status = new MaterialSkin.Controls.MaterialLabel();
            this.device = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.romVersion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.deviceCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fileTable = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_b = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(152, 90);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(117, 36);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "Romu Sıkıştır";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(297, 90);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(174, 36);
            this.materialRaisedButton2.TabIndex = 10;
            this.materialRaisedButton2.Text = "Sıkıştırılmış Romu Aç";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // progress
            // 
            this.progress.Depth = 0;
            this.progress.Location = new System.Drawing.Point(16, 579);
            this.progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(455, 5);
            this.progress.TabIndex = 9;
            // 
            // status
            // 
            this.status.Depth = 0;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status.Font = new System.Drawing.Font("Roboto", 11F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status.Location = new System.Drawing.Point(16, 600);
            this.status.MouseState = MaterialSkin.MouseState.HOVER;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(453, 31);
            this.status.TabIndex = 5;
            this.status.Text = "İşlem Bekleniyor.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // device
            // 
            this.device.Depth = 0;
            this.device.Hint = "";
            this.device.Location = new System.Drawing.Point(182, 412);
            this.device.MaxLength = 32767;
            this.device.MouseState = MaterialSkin.MouseState.HOVER;
            this.device.Name = "device";
            this.device.PasswordChar = '\0';
            this.device.SelectedText = "";
            this.device.SelectionLength = 0;
            this.device.SelectionStart = 0;
            this.device.Size = new System.Drawing.Size(288, 23);
            this.device.TabIndex = 1;
            this.device.TabStop = false;
            this.device.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 412);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 23);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Cihaz İsmi: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 494);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 23);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Rom İsmi: ";
            // 
            // rom
            // 
            this.rom.Depth = 0;
            this.rom.Hint = "";
            this.rom.Location = new System.Drawing.Point(182, 494);
            this.rom.MaxLength = 32767;
            this.rom.MouseState = MaterialSkin.MouseState.HOVER;
            this.rom.Name = "rom";
            this.rom.PasswordChar = '\0';
            this.rom.SelectedText = "";
            this.rom.SelectionLength = 0;
            this.rom.SelectionStart = 0;
            this.rom.Size = new System.Drawing.Size(288, 23);
            this.rom.TabIndex = 3;
            this.rom.TabStop = false;
            this.rom.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(15, 536);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 23);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Rom Versiyonu: ";
            // 
            // romVersion
            // 
            this.romVersion.Depth = 0;
            this.romVersion.Hint = "";
            this.romVersion.Location = new System.Drawing.Point(182, 536);
            this.romVersion.MaxLength = 32767;
            this.romVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.romVersion.Name = "romVersion";
            this.romVersion.PasswordChar = '\0';
            this.romVersion.SelectedText = "";
            this.romVersion.SelectionLength = 0;
            this.romVersion.SelectionStart = 0;
            this.romVersion.Size = new System.Drawing.Size(289, 23);
            this.romVersion.TabIndex = 4;
            this.romVersion.TabStop = false;
            this.romVersion.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(15, 453);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(147, 23);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Cihaz Kod Adı: ";
            // 
            // deviceCode
            // 
            this.deviceCode.Depth = 0;
            this.deviceCode.Hint = "";
            this.deviceCode.Location = new System.Drawing.Point(182, 453);
            this.deviceCode.MaxLength = 32767;
            this.deviceCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.deviceCode.Name = "deviceCode";
            this.deviceCode.PasswordChar = '\0';
            this.deviceCode.SelectedText = "";
            this.deviceCode.SelectionLength = 0;
            this.deviceCode.SelectionStart = 0;
            this.deviceCode.Size = new System.Drawing.Size(287, 23);
            this.deviceCode.TabIndex = 2;
            this.deviceCode.TabStop = false;
            this.deviceCode.UseSystemPasswordChar = false;
            // 
            // fileTable
            // 
            this.fileTable.AllowUserToAddRows = false;
            this.fileTable.AllowUserToResizeRows = false;
            this.fileTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filepath,
            this.file,
            this.a_b});
            this.fileTable.Location = new System.Drawing.Point(15, 142);
            this.fileTable.Name = "fileTable";
            this.fileTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.fileTable.Size = new System.Drawing.Size(455, 243);
            this.fileTable.TabIndex = 17;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(12, 90);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(123, 36);
            this.materialRaisedButton3.TabIndex = 18;
            this.materialRaisedButton3.Text = "Dosyaları Seç";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // filepath
            // 
            this.filepath.HeaderText = "";
            this.filepath.Name = "filepath";
            this.filepath.Visible = false;
            // 
            // file
            // 
            this.file.HeaderText = "Dosya";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // a_b
            // 
            this.a_b.FalseValue = "0";
            this.a_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.a_b.HeaderText = "A/B";
            this.a_b.Name = "a_b";
            this.a_b.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_b.TrueValue = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 645);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.fileTable);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.deviceCode);
            this.Controls.Add(this.romVersion);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.rom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.device);
            this.Controls.Add(this.status);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneCompressor - onelabs.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialProgressBar progress;
        private MaterialSkin.Controls.MaterialLabel status;
        private MaterialSkin.Controls.MaterialSingleLineTextField device;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField rom;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField romVersion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField deviceCode;
        private System.Windows.Forms.DataGridView fileTable;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewCheckBoxColumn a_b;
    }
}

