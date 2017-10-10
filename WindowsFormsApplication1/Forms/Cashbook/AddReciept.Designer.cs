namespace WindowsFormsApplication1.Forms.Cashbook
{
    partial class AddReciept
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RecieptDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.RecieptNarration = new System.Windows.Forms.RichTextBox();
            this.RecieptReferenceNumber = new MetroFramework.Controls.MetroTextBox();
            this.cmRecieptPayment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmPartyName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtRecieptAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 256);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Method";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Ref No.";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Narrations";
            // 
            // RecieptDatePicker
            // 
            this.RecieptDatePicker.Location = new System.Drawing.Point(144, 79);
            this.RecieptDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.RecieptDatePicker.Name = "RecieptDatePicker";
            this.RecieptDatePicker.Size = new System.Drawing.Size(200, 29);
            this.RecieptDatePicker.TabIndex = 4;
            // 
            // RecieptNarration
            // 
            this.RecieptNarration.Location = new System.Drawing.Point(144, 131);
            this.RecieptNarration.Name = "RecieptNarration";
            this.RecieptNarration.Size = new System.Drawing.Size(200, 50);
            this.RecieptNarration.TabIndex = 5;
            this.RecieptNarration.Text = "";
            // 
            // RecieptReferenceNumber
            // 
            // 
            // 
            // 
            this.RecieptReferenceNumber.CustomButton.Image = null;
            this.RecieptReferenceNumber.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.RecieptReferenceNumber.CustomButton.Name = "";
            this.RecieptReferenceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RecieptReferenceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RecieptReferenceNumber.CustomButton.TabIndex = 1;
            this.RecieptReferenceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RecieptReferenceNumber.CustomButton.UseSelectable = true;
            this.RecieptReferenceNumber.CustomButton.Visible = false;
            this.RecieptReferenceNumber.Lines = new string[0];
            this.RecieptReferenceNumber.Location = new System.Drawing.Point(144, 200);
            this.RecieptReferenceNumber.MaxLength = 32767;
            this.RecieptReferenceNumber.Name = "RecieptReferenceNumber";
            this.RecieptReferenceNumber.PasswordChar = '\0';
            this.RecieptReferenceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RecieptReferenceNumber.SelectedText = "";
            this.RecieptReferenceNumber.SelectionLength = 0;
            this.RecieptReferenceNumber.SelectionStart = 0;
            this.RecieptReferenceNumber.ShortcutsEnabled = true;
            this.RecieptReferenceNumber.Size = new System.Drawing.Size(200, 23);
            this.RecieptReferenceNumber.TabIndex = 6;
            this.RecieptReferenceNumber.UseSelectable = true;
            this.RecieptReferenceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RecieptReferenceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RecieptReferenceNumber.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // cmRecieptPayment
            // 
            this.cmRecieptPayment.FormattingEnabled = true;
            this.cmRecieptPayment.ItemHeight = 23;
            this.cmRecieptPayment.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Online Bank Transfer"});
            this.cmRecieptPayment.Location = new System.Drawing.Point(144, 253);
            this.cmRecieptPayment.Name = "cmRecieptPayment";
            this.cmRecieptPayment.Size = new System.Drawing.Size(200, 29);
            this.cmRecieptPayment.TabIndex = 7;
            this.cmRecieptPayment.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 335);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Payment From";
            // 
            // cmPartyName
            // 
            this.cmPartyName.FormattingEnabled = true;
            this.cmPartyName.ItemHeight = 23;
            this.cmPartyName.Location = new System.Drawing.Point(144, 325);
            this.cmPartyName.Name = "cmPartyName";
            this.cmPartyName.Size = new System.Drawing.Size(200, 29);
            this.cmPartyName.TabIndex = 9;
            this.cmPartyName.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 404);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Amount";
            // 
            // txtRecieptAmount
            // 
            // 
            // 
            // 
            this.txtRecieptAmount.CustomButton.Image = null;
            this.txtRecieptAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtRecieptAmount.CustomButton.Name = "";
            this.txtRecieptAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRecieptAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecieptAmount.CustomButton.TabIndex = 1;
            this.txtRecieptAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecieptAmount.CustomButton.UseSelectable = true;
            this.txtRecieptAmount.CustomButton.Visible = false;
            this.txtRecieptAmount.Lines = new string[0];
            this.txtRecieptAmount.Location = new System.Drawing.Point(144, 400);
            this.txtRecieptAmount.MaxLength = 32767;
            this.txtRecieptAmount.Name = "txtRecieptAmount";
            this.txtRecieptAmount.PasswordChar = '\0';
            this.txtRecieptAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecieptAmount.SelectedText = "";
            this.txtRecieptAmount.SelectionLength = 0;
            this.txtRecieptAmount.SelectionStart = 0;
            this.txtRecieptAmount.ShortcutsEnabled = true;
            this.txtRecieptAmount.Size = new System.Drawing.Size(200, 23);
            this.txtRecieptAmount.TabIndex = 11;
            this.txtRecieptAmount.UseSelectable = true;
            this.txtRecieptAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecieptAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(144, 462);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 46);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Add Reciept";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(278, 462);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 46);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(29, 462);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 46);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "New Reciept";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // AddReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 531);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtRecieptAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmPartyName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmRecieptPayment);
            this.Controls.Add(this.RecieptReferenceNumber);
            this.Controls.Add(this.RecieptNarration);
            this.Controls.Add(this.RecieptDatePicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddReciept";
            this.Text = "AddReciept";
            this.Load += new System.EventHandler(this.AddReciept_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime RecieptDatePicker;
        private System.Windows.Forms.RichTextBox RecieptNarration;
        private MetroFramework.Controls.MetroTextBox RecieptReferenceNumber;
        private MetroFramework.Controls.MetroComboBox cmRecieptPayment;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmPartyName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtRecieptAmount;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}