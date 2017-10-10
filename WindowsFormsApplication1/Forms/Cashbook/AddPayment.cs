using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Cashbook
{
    public partial class AddPayment : MetroFramework.Forms.MetroForm
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void PaymentsDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmPaymentMethod.SelectedIndex == -1 || cmPaymentPartyName.SelectedIndex == -1 || String.IsNullOrEmpty(txtPaymentAmount.Text))
            {
                MessageBox.Show("please fill all textboxes first");

            }
            else
            {
                try
                {

                    DataTable dt = new DataTable();

                    SqlConnection conn = DBConn.GetInstance();
                    SqlDataAdapter dad;
                    if (cmPaymentMethod.SelectedItem.Equals("Cash")) 
                    {
                       dad  = new SqlDataAdapter("Insert INTO CashBook(Date,Narration,ReferenceNo,PaymentMethod,PId,Cash,Type) values (@3,@4,@5,@6,@7,@8,@9)", conn);

                    }
                    else{

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,Narration,ReferenceNo,PaymentMethod,PId,Bank,Type) values (@3,@4,@5,@6,@7,@8,@9)", conn);

                    }



                    dad.SelectCommand.Parameters.AddWithValue("@3", PaymentsDatePicker.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@4", PaymentsNarration.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@5", PaymentsReferenceNumber.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@6", cmPaymentMethod.SelectedItem);
                    dad.SelectCommand.Parameters.AddWithValue("@7", cmPaymentPartyName.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@8", txtPaymentAmount.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@9", "Payments");


                    dad.Fill(dt);
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            cmPaymentPartyName.DataSource = new DAO().GetParties();
            cmPaymentPartyName.DisplayMember = "Name";
            cmPaymentPartyName.ValueMember = "Party-ID";
            cmPaymentPartyName.SelectedIndex = -1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
