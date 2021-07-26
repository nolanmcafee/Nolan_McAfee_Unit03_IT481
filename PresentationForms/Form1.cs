using PresentationWebApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationForms
{
    public partial class Form1 : Form
    {
        private PL pl;
        private List<string> table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstResult.View = View.Details;
            lstResult.GridLines = true;
            lstResult.FullRowSelect = true;

            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                lstResult.Clear();

                pl = new PL(txtUsername.Text, txtPassword.Text, cmbTable.Text);

                table = pl.Results();

                ColumnHeader columnHeader1 = new ColumnHeader();
                columnHeader1.Text = cmbTable.Text;
                this.lstResult.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
                this.lstResult.Columns[0].Width = 230;


                foreach (string item in table)
                {
                    lstResult.Items.Add(item);
                }

                this.lstResult.GridLines = true;
                this.lstResult.FullRowSelect = true;
                this.lstResult.View = View.Details;

                this.txtPassword.Clear();
                //this.cmbTable.SelectedValue = "";
            }
            catch
            {
                lstResult.Clear();
                this.txtPassword.Clear();
                MessageBox.Show("There's been an error!");
            }
        }
    }
}
