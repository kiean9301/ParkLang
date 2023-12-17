namespace ParkLang
{
    partial class ParkLang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkLang));
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.dgCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(87, 25);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(157, 20);
            this.txtPlateNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plate No";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(87, 51);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(157, 20);
            this.txtColor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(87, 77);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(157, 20);
            this.txtIn.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TimeIn";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(87, 103);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(157, 20);
            this.txtOut.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TimeOut";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(87, 131);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(157, 20);
            this.txtCarModel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Car Model";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCustomerId,
            this.PlateNo,
            this.Color,
            this.TimeIn,
            this.TimeOut,
            this.CarModel});
            this.dgvCustomer.Location = new System.Drawing.Point(264, 25);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(512, 327);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // dgCustomerId
            // 
            this.dgCustomerId.DataPropertyName = "CustomerId";
            this.dgCustomerId.HeaderText = "Costumer ID";
            this.dgCustomerId.Name = "dgCustomerId";
            this.dgCustomerId.ReadOnly = true;
            this.dgCustomerId.Visible = false;
            // 
            // PlateNo
            // 
            this.PlateNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlateNo.DataPropertyName = "PlateNo";
            this.PlateNo.HeaderText = "Plate Number";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // TimeIn
            // 
            this.TimeIn.DataPropertyName = "TimeIn";
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            // 
            // TimeOut
            // 
            this.TimeOut.DataPropertyName = "TimeOut";
            this.TimeOut.HeaderText = "TimeOut";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "Car Model";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPlateNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park Lang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
    }
}

