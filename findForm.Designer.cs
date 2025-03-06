namespace RTFPad
{
    partial class findForm
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
            this.findLabel = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.findDirectionGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxWholeWord = new System.Windows.Forms.CheckBox();
            this.findDirectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(20, 37);
            this.findLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(82, 20);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Fi&nd what:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(112, 32);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(298, 26);
            this.textBoxFind.TabIndex = 1;
            this.textBoxFind.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // checkBoxMatchCase
            // 
            this.checkBoxMatchCase.AutoSize = true;
            this.checkBoxMatchCase.Location = new System.Drawing.Point(24, 132);
            this.checkBoxMatchCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(117, 24);
            this.checkBoxMatchCase.TabIndex = 2;
            this.checkBoxMatchCase.Text = "Match &case";
            this.checkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // findDirectionGroupBox
            // 
            this.findDirectionGroupBox.Controls.Add(this.radioButtonDown);
            this.findDirectionGroupBox.Controls.Add(this.radioButtonUp);
            this.findDirectionGroupBox.Location = new System.Drawing.Point(212, 84);
            this.findDirectionGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findDirectionGroupBox.Name = "findDirectionGroupBox";
            this.findDirectionGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findDirectionGroupBox.Size = new System.Drawing.Size(180, 77);
            this.findDirectionGroupBox.TabIndex = 3;
            this.findDirectionGroupBox.TabStop = false;
            this.findDirectionGroupBox.Text = "Direction";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Checked = true;
            this.radioButtonDown.Location = new System.Drawing.Point(92, 42);
            this.radioButtonDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(75, 24);
            this.radioButtonDown.TabIndex = 1;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "&Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(9, 42);
            this.radioButtonUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(55, 24);
            this.radioButtonUp.TabIndex = 0;
            this.radioButtonUp.Text = "&Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Enabled = false;
            this.buttonFind.Location = new System.Drawing.Point(447, 32);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(112, 35);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "&Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(447, 82);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxWholeWord
            // 
            this.checkBoxWholeWord.AutoSize = true;
            this.checkBoxWholeWord.Location = new System.Drawing.Point(24, 93);
            this.checkBoxWholeWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxWholeWord.Name = "checkBoxWholeWord";
            this.checkBoxWholeWord.Size = new System.Drawing.Size(118, 24);
            this.checkBoxWholeWord.TabIndex = 6;
            this.checkBoxWholeWord.Text = "Whole word";
            this.checkBoxWholeWord.UseVisualStyleBackColor = true;
            // 
            // findForm
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(591, 182);
            this.Controls.Add(this.checkBoxWholeWord);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.findDirectionGroupBox);
            this.Controls.Add(this.checkBoxMatchCase);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.findLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.findDirectionGroupBox.ResumeLayout(false);
            this.findDirectionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.GroupBox findDirectionGroupBox;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxWholeWord;
    }
}