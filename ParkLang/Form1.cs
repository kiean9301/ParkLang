using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkLang
{
    public partial class Form1 : Form
    {
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtPlateNo.Text = txtColor.Text = txtIn.Text = txtOut.Text = txtCarModel.Text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            model.CustomerId = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = txtPlateNo;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            model.PlateNo = int.Parse(txtPlateNo.Text);
            model.Color = txtColor.Text.Trim();
            model.TimeIn = txtIn.Text.Trim();
            model.TimeOut = txtOut.Text.Trim();
            model.CarModel = txtCarModel.Text.Trim();
            
            using (dbParkingSystemEntities db = new dbParkingSystemEntities())
            {
                db.Customers.Add(model);
                db.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Save Successfully");

        }
        void LoadData()
        {
            dgvCustomer.AutoGenerateColumns = false;
            using (dbParkingSystemEntities db = new dbParkingSystemEntities())
            {
                dgvCustomer.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                model.CustomerId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["dgCustomerId"].Value);
                using (dbParkingSystemEntities db = new dbParkingSystemEntities())
                {
                    model = db.Customers.Where(x => x.CustomerId == model.CustomerId).FirstOrDefault();

                    txtPlateNo.Text = model.PlateNo.ToString();
                    txtColor.Text = model.Color;
                    txtIn.Text = model.TimeIn;
                    txtOut.Text = model.TimeOut;
                    txtCarModel.Text = model.CarModel;
                }
                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }
    }
}
