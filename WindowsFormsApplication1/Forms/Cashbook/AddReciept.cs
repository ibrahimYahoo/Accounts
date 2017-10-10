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
    public partial class AddReciept : MetroFramework.Forms.MetroForm
    {
        public AddReciept()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(cmRecieptPayment.SelectedIndex == -1 || cmPartyName.SelectedIndex == -1 || String.IsNullOrEmpty(txtRecieptAmount.Text))
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
                    if (cmRecieptPayment.SelectedItem.Equals("Cash"))
                    {
                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,Narration,ReferenceNo,PaymentMethod,PId,Cash,Type) values (@3,@4,@5,@6,@7,@8,@9)", conn);

                    }
                    else
                    {

                        dad = new SqlDataAdapter("Insert INTO CashBook(Date,Narration,ReferenceNo,PaymentMethod,PId,Bank,Type) values (@3,@4,@5,@6,@7,@8,@9)", conn);

                    }


                    dad.SelectCommand.Parameters.AddWithValue("@3", RecieptDatePicker.Value);
                    dad.SelectCommand.Parameters.AddWithValue("@4", RecieptNarration.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@5", RecieptReferenceNumber.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@6", cmRecieptPayment.SelectedItem);
                    dad.SelectCommand.Parameters.AddWithValue("@7", cmPartyName.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@8", txtRecieptAmount.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@9", "Reciept");


                    dad.Fill(dt);
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }









        }

        private void AddReciept_Load(object sender, EventArgs e)
        {
            cmPartyName.DataSource = new DAO().GetParties();
            cmPartyName.DisplayMember = "Name";
            cmPartyName.ValueMember = "Party-ID";
            cmPartyName.SelectedIndex = -1;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
