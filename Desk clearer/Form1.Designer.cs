namespace Desk_clearer
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
            this.btnExcute = new System.Windows.Forms.Button();
            this.ltbInclude = new System.Windows.Forms.ListBox();
            this.ltbExclude = new System.Windows.Forms.ListBox();
            this.lblInclude = new System.Windows.Forms.Label();
            this.lblExclude = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExclude = new System.Windows.Forms.Button();
            this.btnInclude = new System.Windows.Forms.Button();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtMainPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.fbdDefaultDir = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdDefaultDir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnExcute
            // 
            this.btnExcute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcute.Location = new System.Drawing.Point(223, 168);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(75, 21);
            this.btnExcute.TabIndex = 0;
            this.btnExcute.Text = "Clean";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // ltbInclude
            // 
            this.ltbInclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltbInclude.FormattingEnabled = true;
            this.ltbInclude.ItemHeight = 12;
            this.ltbInclude.Location = new System.Drawing.Point(48, 28);
            this.ltbInclude.Name = "ltbInclude";
            this.ltbInclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbInclude.Size = new System.Drawing.Size(97, 124);
            this.ltbInclude.TabIndex = 1;
            // 
            // ltbExclude
            // 
            this.ltbExclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ltbExclude.FormattingEnabled = true;
            this.ltbExclude.ItemHeight = 12;
            this.ltbExclude.Location = new System.Drawing.Point(211, 28);
            this.ltbExclude.Name = "ltbExclude";
            this.ltbExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbExclude.Size = new System.Drawing.Size(97, 124);
            this.ltbExclude.TabIndex = 2;
            // 
            // lblInclude
            // 
            this.lblInclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInclude.AutoSize = true;
            this.lblInclude.Location = new System.Drawing.Point(46, 9);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(107, 12);
            this.lblInclude.TabIndex = 3;
            this.lblInclude.Text = "Include Extension";
            // 
            // lblExclude
            // 
            this.lblExclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExclude.AutoSize = true;
            this.lblExclude.Location = new System.Drawing.Point(209, 9);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(107, 12);
            this.lblExclude.TabIndex = 4;
            this.lblExclude.Text = "Exclude Extension";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(70, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExclude.Location = new System.Drawing.Point(151, 61);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(54, 21);
            this.btnExclude.TabIndex = 7;
            this.btnExclude.Text = "=>";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // btnInclude
            // 
            this.btnInclude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInclude.Location = new System.Drawing.Point(151, 88);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(54, 21);
            this.btnInclude.TabIndex = 8;
            this.btnInclude.Text = "<=";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
            // 
            // rtbInformation
            // 
            this.rtbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInformation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbInformation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInformation.Location = new System.Drawing.Point(13, 218);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.ReadOnly = true;
            this.rtbInformation.Size = new System.Drawing.Size(331, 89);
            this.rtbInformation.TabIndex = 9;
            this.rtbInformation.Text = "";
            this.rtbInformation.TextChanged += new System.EventHandler(this.rtbInformation_TextChanged);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAll.Location = new System.Drawing.Point(109, 312);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(132, 21);
            this.btnViewAll.TabIndex = 10;
            this.btnViewAll.Text = "查看指定路径文件";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // txtMainPath
            // 
            this.txtMainPath.Location = new System.Drawing.Point(13, 350);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.Size = new System.Drawing.Size(238, 21);
            this.txtMainPath.TabIndex = 11;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(257, 350);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 21);
            this.btnSelectFile.TabIndex = 12;
            this.btnSelectFile.Text = "Select";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // ofdDefaultDir
            // 
            this.ofdDefaultDir.FileName = "ofdDefaultDir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtMainPath);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.rtbInformation);
            this.Controls.Add(this.btnInclude);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblExclude);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.ltbExclude);
            this.Controls.Add(this.ltbInclude);
            this.Controls.Add(this.btnExcute);
            this.Name = "Form1";
            this.Text = "Gross File Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.ListBox ltbInclude;
        private System.Windows.Forms.ListBox ltbExclude;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtMainPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.FolderBrowserDialog fbdDefaultDir;
        private System.Windows.Forms.OpenFileDialog ofdDefaultDir;
    }
}

