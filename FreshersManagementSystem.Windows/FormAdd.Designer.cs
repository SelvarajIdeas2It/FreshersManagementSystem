namespace FreshersManagementSystem.Windows
{
    partial class FormAdd
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmailId = new System.Windows.Forms.TextBox();
            this.textBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxQualification = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lalbleId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHeader.Location = new System.Drawing.Point(414, 11);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(0, 28);
            this.labelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(238, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(238, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMAIL ID    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(238, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "MOBILE NUMBER  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(238, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "DATE OF BIRTH   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(238, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "QUALIFICATION    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(238, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADDRESS      ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(530, 86);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 33);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxName_Validating);
            // 
            // textBoxEmailId
            // 
            this.textBoxEmailId.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailId.Location = new System.Drawing.Point(530, 143);
            this.textBoxEmailId.Name = "textBoxEmailId";
            this.textBoxEmailId.Size = new System.Drawing.Size(296, 33);
            this.textBoxEmailId.TabIndex = 8;
            this.textBoxEmailId.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmailId_Validating);
            // 
            // textBoxMobileNumber
            // 
            this.textBoxMobileNumber.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxMobileNumber.Location = new System.Drawing.Point(530, 204);
            this.textBoxMobileNumber.Name = "textBoxMobileNumber";
            this.textBoxMobileNumber.Size = new System.Drawing.Size(296, 33);
            this.textBoxMobileNumber.TabIndex = 9;
            this.textBoxMobileNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMobileNumber_Validating);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxAddress.Location = new System.Drawing.Point(530, 380);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(296, 60);
            this.richTextBoxAddress.TabIndex = 10;
            this.richTextBoxAddress.Text = "";
            this.richTextBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.RichTextBoxAddress_Validating);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDOB.Location = new System.Drawing.Point(530, 262);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(296, 33);
            this.dateTimePickerDOB.TabIndex = 11;
            this.dateTimePickerDOB.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePickerDOB_Validating);
            // 
            // comboBoxQualification
            // 
            this.comboBoxQualification.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxQualification.FormattingEnabled = true;
            this.comboBoxQualification.Items.AddRange(new object[] {
            "BE",
            "ME",
            "B Tech",
            "M Tech",
            "MBA",
            "BBA",
            "MCA",
            "BCA",
            "BSc"});
            this.comboBoxQualification.Location = new System.Drawing.Point(530, 319);
            this.comboBoxQualification.Name = "comboBoxQualification";
            this.comboBoxQualification.Size = new System.Drawing.Size(296, 33);
            this.comboBoxQualification.TabIndex = 12;
            this.comboBoxQualification.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxQualification_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(463, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lalbleId
            // 
            this.lalbleId.AutoSize = true;
            this.lalbleId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lalbleId.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lalbleId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lalbleId.Location = new System.Drawing.Point(618, 12);
            this.lalbleId.Name = "lalbleId";
            this.lalbleId.Size = new System.Drawing.Size(0, 28);
            this.lalbleId.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(706, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 28);
            this.labelName.TabIndex = 15;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1080, 586);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lalbleId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxQualification);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.textBoxMobileNumber);
            this.Controls.Add(this.textBoxEmailId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHeader);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHeader;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxEmailId;
        private TextBox textBoxMobileNumber;
        private RichTextBox richTextBoxAddress;
        private DateTimePicker dateTimePickerDOB;
        private ComboBox comboBoxQualification;
        private Button button1;
        private Label lalbleId;
        private Label labelName;
    }
}