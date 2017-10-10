using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;
using WindowsFormsApplication1.Forms.Cashbook;

namespace WindowsFormsApplication1.Forms
{
    public partial class CashBook : MetroFramework.Forms.MetroForm
    {
        public CashBook()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddReciept addRecObj = new AddReciept();
            addRecObj.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddPayment addPayObj = new AddPayment();
            addPayObj.Show();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mainObj = new Main();
            mainObj.Show();
        }

        private void CashBook_Load(object sender, EventArgs e)
        {
            gvRecieptsCashBook.DataSource = new DAO().getCashBookReciepts();
            gvCashBookPayments.DataSource = new DAO().getCashBookPayments();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            gvRecieptsCashBook.DataSource = new DAO().getCashBookReciepts();

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            gvCashBookPayments.DataSource = new DAO().getCashBookPayments();

        }

        private void gvCashBookPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
