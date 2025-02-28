namespace RTFPad
{
    partial class aboutForm
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
            this.title = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.authorMail = new System.Windows.Forms.LinkLabel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.authorMailAlt = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(96, 9);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(187, 67);
            this.title.TabIndex = 0;
            this.title.Text = "RTFPad";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(38, 94);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(94, 20);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Created by: ";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(38, 129);
            this.mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(61, 20);
            this.mailLabel.TabIndex = 2;
            this.mailLabel.Text = "E-mail: ";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Location = new System.Drawing.Point(142, 94);
            this.authorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(129, 20);
            this.authorName.TabIndex = 3;
            this.authorName.Text = "Matija Lovreković";
            // 
            // authorMail
            // 
            this.authorMail.AutoSize = true;
            this.authorMail.Location = new System.Drawing.Point(142, 129);
            this.authorMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorMail.Name = "authorMail";
            this.authorMail.Size = new System.Drawing.Size(133, 20);
            this.authorMail.TabIndex = 4;
            this.authorMail.TabStop = true;
            this.authorMail.Text = "mlovrekov@tvz.hr";
            this.authorMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorMail_LinkClicked);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(133, 255);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 35);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // authorMailAlt
            // 
            this.authorMailAlt.AutoSize = true;
            this.authorMailAlt.Location = new System.Drawing.Point(142, 164);
            this.authorMailAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorMailAlt.Name = "authorMailAlt";
            this.authorMailAlt.Size = new System.Drawing.Size(180, 20);
            this.authorMailAlt.TabIndex = 6;
            this.authorMailAlt.TabStop = true;
            this.authorMailAlt.Text = "MrPlow442@yahoo.com";
            this.authorMailAlt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorMailAlt_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enhancements + Bug Fixes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jeff Chapman";
            // 
            // aboutForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(399, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorMailAlt);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.authorMail);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.LinkLabel authorMail;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.LinkLabel authorMailAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}