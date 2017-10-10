namespace WindowsFormsApplication1.Forms.Cashbook
{
    partial class AddPayment
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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmPaymentPartyName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.PaymentsReferenceNumber = new MetroFramework.Controls.MetroTextBox();
            this.PaymentsNarration = new System.Windows.Forms.RichTextBox();
            this.PaymentsDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(32, 453);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 46);
            this.metroButton3.TabIndex = 29;
            this.metroButton3.Text = "New Reciept";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(292, 453);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 46);
            this.metroButton2.TabIndex = 28;
            this.metroButton2.Text = "Close";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(167, 453);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 46);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "Add Reciept";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtPaymentAmount
            // 
            // 
            // 
            // 
            this.txtPaymentAmount.CustomButton.Image = null;
            this.txtPaymentAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPaymentAmount.CustomButton.Name = "";
            this.txtPaymentAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentAmount.CustomButton.TabIndex = 1;
            this.txtPaymentAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentAmount.CustomButton.UseSelectable = true;
            this.txtPaymentAmount.CustomButton.Visible = false;
            this.txtPaymentAmount.Lines = new string[0];
            this.txtPaymentAmount.Location = new System.Drawing.Point(167, 391);
            this.txtPaymentAmount.MaxLength = 32767;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.SelectionLength = 0;
            this.txtPaymentAmount.SelectionStart = 0;
            this.txtPaymentAmount.ShortcutsEnabled = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(200, 23);
            this.txtPaymentAmount.TabIndex = 26;
            this.txtPaymentAmount.UseSelectable = true;
            this.txtPaymentAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(32, 395);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Amount";
            // 
            // cmPaymentPartyName
            // 
            this.cmPaymentPartyName.FormattingEnabled = true;
            this.cmPaymentPartyName.ItemHeight = 23;
            this.cmPaymentPartyName.Location = new System.Drawing.Point(167, 316);
            this.cmPaymentPartyName.Name = "cmPaymentPartyName";
            this.cmPaymentPartyName.Size = new System.Drawing.Size(200, 29);
            this.cmPaymentPartyName.TabIndex = 24;
            this.cmPaymentPartyName.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(32, 326);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Payment From";
            // 
            // cmPaymentMethod
            // 
            this.cmPaymentMethod.FormattingEnabled = true;
            this.cmPaymentMethod.ItemHeight = 23;
            this.cmPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Online Bank Transfer"});
            this.cmPaymentMethod.Location = new System.Drawing.Point(167, 244);
            this.cmPaymentMethod.Name = "cmPaymentMethod";
            this.cmPaymentMethod.Size = new System.Drawing.Size(200, 29);
            this.cmPaymentMethod.TabIndex = 22;
            this.cmPaymentMethod.UseSelectable = true;
            // 
            // PaymentsReferenceNumber
            // 
            // 
            // 
            // 
            this.PaymentsReferenceNumber.CustomButton.Image = null;
            this.PaymentsReferenceNumber.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.PaymentsReferenceNumber.CustomButton.Name = "";
            this.PaymentsReferenceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaymentsReferenceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PaymentsReferenceNumber.CustomButton.TabIndex = 1;
            this.PaymentsReferenceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PaymentsReferenceNumber.CustomButton.UseSelectable = true;
            this.PaymentsReferenceNumber.CustomButton.Visible = false;
            this.PaymentsReferenceNumber.Lines = new string[0];
            this.PaymentsReferenceNumber.Location = new System.Drawing.Point(167, 191);
            this.PaymentsReferenceNumber.MaxLength = 32767;
            this.PaymentsReferenceNumber.Name = "PaymentsReferenceNumber";
            this.PaymentsReferenceNumber.PasswordChar = '\0';
            this.PaymentsReferenceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaymentsReferenceNumber.SelectedText = "";
            this.PaymentsReferenceNumber.SelectionLength = 0;
            this.PaymentsReferenceNumber.SelectionStart = 0;
            this.PaymentsReferenceNumber.ShortcutsEnabled = true;
            this.PaymentsReferenceNumber.Size = new System.Drawing.Size(200, 23);
            this.PaymentsReferenceNumber.TabIndex = 21;
            this.PaymentsReferenceNumber.UseSelectable = true;
            this.PaymentsReferenceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaymentsReferenceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PaymentsNarration
            // 
            this.PaymentsNarration.Location = new System.Drawing.Point(167, 122);
            this.PaymentsNarration.Name = "PaymentsNarration";
            this.PaymentsNarration.Size = new System.Drawing.Size(200, 50);
            this.PaymentsNarration.TabIndex = 20;
            this.PaymentsNarration.Text = "";
            // 
            // PaymentsDatePicker
            // 
            this.PaymentsDatePicker.Location = new System.Drawing.Point(167, 70);
            this.PaymentsDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.PaymentsDatePicker.Name = "PaymentsDatePicker";
            this.PaymentsDatePicker.Size = new System.Drawing.Size(200, 29);
            this.PaymentsDatePicker.TabIndex = 19;
            this.PaymentsDatePicker.ValueChanged += new System.EventHandler(this.PaymentsDatePicker_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Narrations";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Ref No.";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 247);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Payment Method";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Date";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 569);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmPaymentPartyName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmPaymentMethod);
            this.Controls.Add(this.PaymentsReferenceNumber);
            this.Controls.Add(this.PaymentsNarration);
            this.Controls.Add(this.PaymentsDatePicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.Load += new System.EventHandler(this.AddPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtPaymentAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmPaymentPartyName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmPaymentMethod;
        private MetroFramework.Controls.MetroTextBox PaymentsReferenceNumber;
        private System.Windows.Forms.RichTextBox PaymentsNarration;
        private MetroFramework.Controls.MetroDateTime PaymentsDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}