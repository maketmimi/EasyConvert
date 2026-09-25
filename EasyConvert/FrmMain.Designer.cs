namespace EasyConvert
{
    partial class FrmMain
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
            this.PnlSourceImage = new System.Windows.Forms.Panel();
            this.BtnBrowseSourceImage = new System.Windows.Forms.Button();
            this.TxtSourceImageName = new System.Windows.Forms.TextBox();
            this.PbSourceImagePreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTargetImageFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtResultSavePath = new System.Windows.Forms.TextBox();
            this.BtnBrowseResultSaveFolder = new System.Windows.Forms.Button();
            this.BtnShowResultImage = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.LbConvertStatus = new System.Windows.Forms.Label();
            this.PnlSourceImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSourceImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSourceImage
            // 
            this.PnlSourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSourceImage.BackColor = System.Drawing.Color.Transparent;
            this.PnlSourceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSourceImage.Controls.Add(this.BtnBrowseSourceImage);
            this.PnlSourceImage.Controls.Add(this.TxtSourceImageName);
            this.PnlSourceImage.Controls.Add(this.PbSourceImagePreview);
            this.PnlSourceImage.Location = new System.Drawing.Point(12, 12);
            this.PnlSourceImage.Name = "PnlSourceImage";
            this.PnlSourceImage.Size = new System.Drawing.Size(491, 219);
            this.PnlSourceImage.TabIndex = 0;
            // 
            // BtnBrowseSourceImage
            // 
            this.BtnBrowseSourceImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBrowseSourceImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBrowseSourceImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBrowseSourceImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnBrowseSourceImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnBrowseSourceImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseSourceImage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseSourceImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtnBrowseSourceImage.Location = new System.Drawing.Point(185, 177);
            this.BtnBrowseSourceImage.Name = "BtnBrowseSourceImage";
            this.BtnBrowseSourceImage.Size = new System.Drawing.Size(119, 35);
            this.BtnBrowseSourceImage.TabIndex = 0;
            this.BtnBrowseSourceImage.Text = "Browse Image";
            this.BtnBrowseSourceImage.UseVisualStyleBackColor = false;
            // 
            // TxtSourceImageName
            // 
            this.TxtSourceImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSourceImageName.BackColor = System.Drawing.Color.White;
            this.TxtSourceImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSourceImageName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSourceImageName.Location = new System.Drawing.Point(3, 149);
            this.TxtSourceImageName.Name = "TxtSourceImageName";
            this.TxtSourceImageName.ReadOnly = true;
            this.TxtSourceImageName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtSourceImageName.Size = new System.Drawing.Size(483, 22);
            this.TxtSourceImageName.TabIndex = 1;
            this.TxtSourceImageName.Text = "Please select an image to convert";
            this.TxtSourceImageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSourceImageName.WordWrap = false;
            // 
            // PbSourceImagePreview
            // 
            this.PbSourceImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSourceImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSourceImagePreview.Location = new System.Drawing.Point(138, 13);
            this.PbSourceImagePreview.Name = "PbSourceImagePreview";
            this.PbSourceImagePreview.Size = new System.Drawing.Size(213, 130);
            this.PbSourceImagePreview.TabIndex = 0;
            this.PbSourceImagePreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(7, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convert To:";
            // 
            // CbTargetImageFormat
            // 
            this.CbTargetImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbTargetImageFormat.BackColor = System.Drawing.Color.White;
            this.CbTargetImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTargetImageFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTargetImageFormat.FormattingEnabled = true;
            this.CbTargetImageFormat.Location = new System.Drawing.Point(132, 238);
            this.CbTargetImageFormat.Name = "CbTargetImageFormat";
            this.CbTargetImageFormat.Size = new System.Drawing.Size(91, 29);
            this.CbTargetImageFormat.Sorted = true;
            this.CbTargetImageFormat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(7, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save To:";
            // 
            // TxtResultSavePath
            // 
            this.TxtResultSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtResultSavePath.BackColor = System.Drawing.Color.White;
            this.TxtResultSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtResultSavePath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultSavePath.ForeColor = System.Drawing.Color.Black;
            this.TxtResultSavePath.Location = new System.Drawing.Point(132, 280);
            this.TxtResultSavePath.Name = "TxtResultSavePath";
            this.TxtResultSavePath.ReadOnly = true;
            this.TxtResultSavePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtResultSavePath.Size = new System.Drawing.Size(327, 29);
            this.TxtResultSavePath.TabIndex = 3;
            this.TxtResultSavePath.Text = "N/A";
            this.TxtResultSavePath.WordWrap = false;
            // 
            // BtnBrowseResultSaveFolder
            // 
            this.BtnBrowseResultSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseResultSaveFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBrowseResultSaveFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBrowseResultSaveFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnBrowseResultSaveFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnBrowseResultSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseResultSaveFolder.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseResultSaveFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtnBrowseResultSaveFolder.Location = new System.Drawing.Point(465, 280);
            this.BtnBrowseResultSaveFolder.Name = "BtnBrowseResultSaveFolder";
            this.BtnBrowseResultSaveFolder.Size = new System.Drawing.Size(38, 29);
            this.BtnBrowseResultSaveFolder.TabIndex = 2;
            this.BtnBrowseResultSaveFolder.Text = "...";
            this.BtnBrowseResultSaveFolder.UseVisualStyleBackColor = false;
            // 
            // BtnShowResultImage
            // 
            this.BtnShowResultImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnShowResultImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnShowResultImage.Enabled = false;
            this.BtnShowResultImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnShowResultImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnShowResultImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnShowResultImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowResultImage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowResultImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtnShowResultImage.Location = new System.Drawing.Point(384, 318);
            this.BtnShowResultImage.Name = "BtnShowResultImage";
            this.BtnShowResultImage.Size = new System.Drawing.Size(119, 35);
            this.BtnShowResultImage.TabIndex = 3;
            this.BtnShowResultImage.Text = "Show Result";
            this.BtnShowResultImage.UseVisualStyleBackColor = false;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnConvert.Enabled = false;
            this.BtnConvert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvert.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtnConvert.Location = new System.Drawing.Point(12, 318);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(91, 35);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = false;
            // 
            // LbConvertStatus
            // 
            this.LbConvertStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbConvertStatus.AutoSize = true;
            this.LbConvertStatus.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConvertStatus.ForeColor = System.Drawing.Color.Black;
            this.LbConvertStatus.Location = new System.Drawing.Point(109, 322);
            this.LbConvertStatus.Name = "LbConvertStatus";
            this.LbConvertStatus.Size = new System.Drawing.Size(0, 27);
            this.LbConvertStatus.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.LbConvertStatus);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnShowResultImage);
            this.Controls.Add(this.BtnBrowseResultSaveFolder);
            this.Controls.Add(this.TxtResultSavePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbTargetImageFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlSourceImage);
            this.MinimumSize = new System.Drawing.Size(531, 399);
            this.Name = "FrmMain";
            this.Text = "EasyConvert";
            this.PnlSourceImage.ResumeLayout(false);
            this.PnlSourceImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSourceImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlSourceImage;
        private System.Windows.Forms.PictureBox PbSourceImagePreview;
        private System.Windows.Forms.TextBox TxtSourceImageName;
        private System.Windows.Forms.Button BtnBrowseSourceImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbTargetImageFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtResultSavePath;
        private System.Windows.Forms.Button BtnBrowseResultSaveFolder;
        private System.Windows.Forms.Button BtnShowResultImage;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Label LbConvertStatus;
    }
}

