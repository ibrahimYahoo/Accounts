namespace WindowsFormsApplication1.Forms
{
    partial class CashBook
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
            this.gvRecieptsCashBook = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.gvCashBookPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecieptsCashBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBookPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRecieptsCashBook
            // 
            this.gvRecieptsCashBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecieptsCashBook.Location = new System.Drawing.Point(24, 218);
            this.gvRecieptsCashBook.Name = "gvRecieptsCashBook";
            this.gvRecieptsCashBook.Size = new System.Drawing.Size(581, 495);
            this.gvRecieptsCashBook.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Recipets";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(701, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Payments";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(119, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(145, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Add A Reciept";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(790, 60);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(145, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Add A payment";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(1150, 22);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 40);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Back";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(453, 52);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(108, 36);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Refresh";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(1022, 51);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(108, 36);
            this.metroButton5.TabIndex = 8;
            this.metroButton5.Text = "Refresh";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // gvCashBookPayments
            // 
            this.gvCashBookPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCashBookPayments.Location = new System.Drawing.Point(681, 218);
            this.gvCashBookPayments.Name = "gvCashBookPayments";
            this.gvCashBookPayments.Size = new System.Drawing.Size(565, 495);
            this.gvCashBookPayments.TabIndex = 9;
            this.gvCashBookPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCashBookPayments_CellContentClick);
            // 
            // CashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 686);
            this.Controls.Add(this.gvCashBookPayments);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gvRecieptsCashBook);
            this.Name = "CashBook";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 5);
            this.Text = "CashBook";
            this.Load += new System.EventHandler(this.CashBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecieptsCashBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBookPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRecieptsCashBook;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DataGridView gvCashBookPayments;
    }
}