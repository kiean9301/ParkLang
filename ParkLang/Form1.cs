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
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            model.PlateNo = txtPlateNo.Text.Trim();
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
            MessageBox.Show("Save Successfully");

        }
    }
}
