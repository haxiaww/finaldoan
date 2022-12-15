
namespace dictionary_winform
{
    partial class main
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtviet = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlog = new System.Windows.Forms.Button();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btnclosegr = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnspeech = new System.Windows.Forms.Button();
            this.btnescape = new System.Windows.Forms.Button();
            this.btnxoatrang = new System.Windows.Forms.Button();
            this.btnql = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txteng = new System.Windows.Forms.ComboBox();
            this.grbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Indigo;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(633, 102);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(94, 29);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.bttn_search_Click);
            // 
            // txtviet
            // 
            this.txtviet.BackColor = System.Drawing.Color.Lavender;
            this.txtviet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtviet.ForeColor = System.Drawing.Color.Indigo;
            this.txtviet.Location = new System.Drawing.Point(177, 151);
            this.txtviet.Name = "txtviet";
            this.txtviet.Size = new System.Drawing.Size(417, 82);
            this.txtviet.TabIndex = 2;
            this.txtviet.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ điển Anh Việt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(75, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ cần tìm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nghĩa:";
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.Indigo;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(633, 204);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(94, 29);
            this.btnlog.TabIndex = 6;
            this.btnlog.Text = "Đăng nhập";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnql_Click);
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.listbox);
            this.grbox.Controls.Add(this.btnclosegr);
            this.grbox.Controls.Add(this.btnupdate);
            this.grbox.Controls.Add(this.btnxoa);
            this.grbox.Controls.Add(this.btnadd);
            this.grbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbox.ForeColor = System.Drawing.Color.Black;
            this.grbox.Location = new System.Drawing.Point(75, 287);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(642, 187);
            this.grbox.TabIndex = 7;
            this.grbox.TabStop = false;
            this.grbox.Text = "Quản lí";
            this.grbox.Visible = false;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 23;
            this.listbox.Location = new System.Drawing.Point(263, 27);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(352, 142);
            this.listbox.Sorted = true;
            this.listbox.TabIndex = 4;
            this.listbox.Click += new System.EventHandler(this.listbox_Click);
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // btnclosegr
            // 
            this.btnclosegr.BackColor = System.Drawing.Color.Indigo;
            this.btnclosegr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclosegr.ForeColor = System.Drawing.Color.White;
            this.btnclosegr.Location = new System.Drawing.Point(147, 111);
            this.btnclosegr.Name = "btnclosegr";
            this.btnclosegr.Size = new System.Drawing.Size(94, 63);
            this.btnclosegr.TabIndex = 3;
            this.btnclosegr.Text = "Đóng";
            this.btnclosegr.UseVisualStyleBackColor = false;
            this.btnclosegr.Click += new System.EventHandler(this.btnclosegr_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Indigo;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(147, 33);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 63);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Indigo;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(23, 111);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 63);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Indigo;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(23, 33);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 63);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnspeech
            // 
            this.btnspeech.BackColor = System.Drawing.Color.Indigo;
            this.btnspeech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspeech.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnspeech.ForeColor = System.Drawing.Color.White;
            this.btnspeech.Location = new System.Drawing.Point(633, 153);
            this.btnspeech.Name = "btnspeech";
            this.btnspeech.Size = new System.Drawing.Size(94, 29);
            this.btnspeech.TabIndex = 8;
            this.btnspeech.Text = "Phát âm";
            this.btnspeech.UseVisualStyleBackColor = false;
            this.btnspeech.Click += new System.EventHandler(this.btnspeech_Click);
            // 
            // btnescape
            // 
            this.btnescape.BackColor = System.Drawing.Color.Thistle;
            this.btnescape.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnescape.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnescape.ForeColor = System.Drawing.Color.Indigo;
            this.btnescape.Location = new System.Drawing.Point(458, 251);
            this.btnescape.Name = "btnescape";
            this.btnescape.Size = new System.Drawing.Size(94, 29);
            this.btnescape.TabIndex = 9;
            this.btnescape.Text = "Thoát";
            this.btnescape.UseVisualStyleBackColor = false;
            this.btnescape.Click += new System.EventHandler(this.btnescape_Click);
            // 
            // btnxoatrang
            // 
            this.btnxoatrang.BackColor = System.Drawing.Color.Thistle;
            this.btnxoatrang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoatrang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnxoatrang.Location = new System.Drawing.Point(336, 251);
            this.btnxoatrang.Name = "btnxoatrang";
            this.btnxoatrang.Size = new System.Drawing.Size(94, 29);
            this.btnxoatrang.TabIndex = 10;
            this.btnxoatrang.Text = "Nhập lại";
            this.btnxoatrang.UseVisualStyleBackColor = false;
            this.btnxoatrang.Click += new System.EventHandler(this.btnxoatrang_Click);
            // 
            // btnql
            // 
            this.btnql.BackColor = System.Drawing.Color.Thistle;
            this.btnql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnql.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnql.ForeColor = System.Drawing.Color.Indigo;
            this.btnql.Location = new System.Drawing.Point(214, 251);
            this.btnql.Name = "btnql";
            this.btnql.Size = new System.Drawing.Size(94, 29);
            this.btnql.TabIndex = 11;
            this.btnql.Text = "Quản lí";
            this.btnql.UseVisualStyleBackColor = false;
            this.btnql.Click += new System.EventHandler(this.btnql_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 85);
            this.panel1.TabIndex = 12;
            // 
            // txteng
            // 
            this.txteng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txteng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txteng.BackColor = System.Drawing.Color.Lavender;
            this.txteng.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txteng.ForeColor = System.Drawing.Color.Indigo;
            this.txteng.FormattingEnabled = true;
            this.txteng.Items.AddRange(new object[] {
            "wanderer",
            "hello"});
            this.txteng.Location = new System.Drawing.Point(179, 102);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(415, 28);
            this.txteng.TabIndex = 13;
            this.txteng.Click += new System.EventHandler(this.txteng_Click);
            // 
            // main
            // 
            this.AcceptButton = this.btnsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btnescape;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.btnql);
            this.Controls.Add(this.btnxoatrang);
            this.Controls.Add(this.btnescape);
            this.Controls.Add(this.btnspeech);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtviet);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển";
            this.Load += new System.EventHandler(this.main_Load);
            this.grbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.RichTextBox txtviet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btnclosegr;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnspeech;
        private System.Windows.Forms.Button btnescape;
        private System.Windows.Forms.Button btnxoatrang;
        public System.Windows.Forms.Button btnql;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txteng;
    }
}

