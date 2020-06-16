namespace XlsxToPic
{
    partial class PicConverter
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
            this.lbl_footer1 = new System.Windows.Forms.Label();
            this.tbl_filelist = new System.Windows.Forms.DataGridView();
            this.col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.list_gen = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_filelist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generated Folder List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_footer1
            // 
            this.lbl_footer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_footer1.AutoSize = true;
            this.lbl_footer1.Location = new System.Drawing.Point(114, 618);
            this.lbl_footer1.Name = "lbl_footer1";
            this.lbl_footer1.Size = new System.Drawing.Size(142, 13);
            this.lbl_footer1.TabIndex = 4;
            this.lbl_footer1.Text = "Excel file list to be converted";
            this.lbl_footer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_filelist
            // 
            this.tbl_filelist.AllowUserToAddRows = false;
            this.tbl_filelist.AllowUserToOrderColumns = true;
            this.tbl_filelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_filelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_no,
            this.col_filename});
            this.tbl_filelist.Location = new System.Drawing.Point(3, 122);
            this.tbl_filelist.Name = "tbl_filelist";
            this.tbl_filelist.RowHeadersVisible = false;
            this.tbl_filelist.Size = new System.Drawing.Size(364, 485);
            this.tbl_filelist.TabIndex = 3;
            // 
            // col_no
            // 
            this.col_no.HeaderText = "No";
            this.col_no.Name = "col_no";
            this.col_no.ReadOnly = true;
            this.col_no.Width = 50;
            // 
            // col_filename
            // 
            this.col_filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_filename.HeaderText = "FileName";
            this.col_filename.Name = "col_filename";
            this.col_filename.ReadOnly = true;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(373, 92);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(364, 23);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Generate";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(3, 92);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(364, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load Excel Files";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(33, 18);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(304, 52);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "First, you have to select xlsx files to decode.\r\nYou can see your seleted files h" +
    "ere.\r\n\r\nSecond, after loaded files you have to click \"Generate\" button.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_load, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_convert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_filelist, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_footer1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.list_gen, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_description, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.78992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.21008F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 637);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // list_gen
            // 
            this.list_gen.FormattingEnabled = true;
            this.list_gen.Location = new System.Drawing.Point(373, 122);
            this.list_gen.Name = "list_gen";
            this.list_gen.Size = new System.Drawing.Size(364, 485);
            this.list_gen.TabIndex = 5;
            // 
            // PicConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(780, 700);
            this.MinimumSize = new System.Drawing.Size(780, 700);
            this.Name = "PicConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_filelist)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_footer1;
        private System.Windows.Forms.DataGridView tbl_filelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_filename;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox list_gen;
    }
}

