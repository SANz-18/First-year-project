namespace Project
{
    partial class frmCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomer_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Customer = new System.Windows.Forms.ComboBox();
            this.btnCustomer_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomer_NIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer_Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnCback = new System.Windows.Forms.Button();
            this.btnCus_Dlt = new System.Windows.Forms.Button();
            this.btnC_update = new System.Windows.Forms.Button();
            this.btnC_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnC_clear);
            this.groupBox1.Controls.Add(this.txtCustomer_No);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_Customer);
            this.groupBox1.Controls.Add(this.btnCustomer_Add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCustomer_Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomer_NIC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomer_Lname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomer_Fname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 382);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer details";
            // 
            // txtCustomer_No
            // 
            this.txtCustomer_No.Location = new System.Drawing.Point(128, 84);
            this.txtCustomer_No.Name = "txtCustomer_No";
            this.txtCustomer_No.Size = new System.Drawing.Size(131, 22);
            this.txtCustomer_No.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer No";
            // 
            // comboBox_Customer
            // 
            this.comboBox_Customer.FormattingEnabled = true;
            this.comboBox_Customer.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_Customer.Location = new System.Drawing.Point(128, 199);
            this.comboBox_Customer.Name = "comboBox_Customer";
            this.comboBox_Customer.Size = new System.Drawing.Size(131, 23);
            this.comboBox_Customer.TabIndex = 12;
            // 
            // btnCustomer_Add
            // 
            this.btnCustomer_Add.BackColor = System.Drawing.Color.Pink;
            this.btnCustomer_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer_Add.ForeColor = System.Drawing.Color.Maroon;
            this.btnCustomer_Add.Location = new System.Drawing.Point(184, 345);
            this.btnCustomer_Add.Name = "btnCustomer_Add";
            this.btnCustomer_Add.Size = new System.Drawing.Size(75, 31);
            this.btnCustomer_Add.TabIndex = 11;
            this.btnCustomer_Add.Text = "Add";
            this.btnCustomer_Add.UseVisualStyleBackColor = false;
            this.btnCustomer_Add.Click += new System.EventHandler(this.btnCustomer_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // txtCustomer_Address
            // 
            this.txtCustomer_Address.Location = new System.Drawing.Point(128, 275);
            this.txtCustomer_Address.Name = "txtCustomer_Address";
            this.txtCustomer_Address.Size = new System.Drawing.Size(131, 22);
            this.txtCustomer_Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // txtCustomer_NIC
            // 
            this.txtCustomer_NIC.Location = new System.Drawing.Point(128, 235);
            this.txtCustomer_NIC.Name = "txtCustomer_NIC";
            this.txtCustomer_NIC.Size = new System.Drawing.Size(131, 22);
            this.txtCustomer_NIC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIC";
            // 
            // txtCustomer_Lname
            // 
            this.txtCustomer_Lname.Location = new System.Drawing.Point(128, 159);
            this.txtCustomer_Lname.Name = "txtCustomer_Lname";
            this.txtCustomer_Lname.Size = new System.Drawing.Size(131, 22);
            this.txtCustomer_Lname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtCustomer_Fname
            // 
            this.txtCustomer_Fname.Location = new System.Drawing.Point(128, 123);
            this.txtCustomer_Fname.Name = "txtCustomer_Fname";
            this.txtCustomer_Fname.Size = new System.Drawing.Size(131, 22);
            this.txtCustomer_Fname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(295, 34);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(598, 222);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnCback
            // 
            this.btnCback.BackColor = System.Drawing.Color.Pink;
            this.btnCback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCback.ForeColor = System.Drawing.Color.Maroon;
            this.btnCback.Location = new System.Drawing.Point(822, 379);
            this.btnCback.Name = "btnCback";
            this.btnCback.Size = new System.Drawing.Size(75, 31);
            this.btnCback.TabIndex = 12;
            this.btnCback.Text = "Back";
            this.btnCback.UseVisualStyleBackColor = false;
            this.btnCback.Click += new System.EventHandler(this.btnCback_Click);
            // 
            // btnCus_Dlt
            // 
            this.btnCus_Dlt.BackColor = System.Drawing.Color.Pink;
            this.btnCus_Dlt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCus_Dlt.ForeColor = System.Drawing.Color.Maroon;
            this.btnCus_Dlt.Location = new System.Drawing.Point(295, 379);
            this.btnCus_Dlt.Name = "btnCus_Dlt";
            this.btnCus_Dlt.Size = new System.Drawing.Size(75, 31);
            this.btnCus_Dlt.TabIndex = 15;
            this.btnCus_Dlt.Text = "Delete";
            this.btnCus_Dlt.UseVisualStyleBackColor = false;
            this.btnCus_Dlt.Click += new System.EventHandler(this.btnCus_Dlt_Click);
            // 
            // btnC_update
            // 
            this.btnC_update.BackColor = System.Drawing.Color.Pink;
            this.btnC_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_update.ForeColor = System.Drawing.Color.Maroon;
            this.btnC_update.Location = new System.Drawing.Point(376, 378);
            this.btnC_update.Name = "btnC_update";
            this.btnC_update.Size = new System.Drawing.Size(75, 31);
            this.btnC_update.TabIndex = 16;
            this.btnC_update.Text = "Update";
            this.btnC_update.UseVisualStyleBackColor = false;
            this.btnC_update.Click += new System.EventHandler(this.btnC_update_Click);
            // 
            // btnC_clear
            // 
            this.btnC_clear.BackColor = System.Drawing.Color.Pink;
            this.btnC_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_clear.ForeColor = System.Drawing.Color.Maroon;
            this.btnC_clear.Location = new System.Drawing.Point(9, 344);
            this.btnC_clear.Name = "btnC_clear";
            this.btnC_clear.Size = new System.Drawing.Size(75, 31);
            this.btnC_clear.TabIndex = 15;
            this.btnC_clear.Text = "Clear";
            this.btnC_clear.UseVisualStyleBackColor = false;
            this.btnC_clear.Click += new System.EventHandler(this.btnC_clear_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(909, 421);
            this.Controls.Add(this.btnC_update);
            this.Controls.Add(this.btnCus_Dlt);
            this.Controls.Add(this.btnCback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomer_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomer_NIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer_Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCback;
        private System.Windows.Forms.TextBox txtCustomer_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Customer;
        private System.Windows.Forms.Button btnCus_Dlt;
        private System.Windows.Forms.Button btnC_update;
        private System.Windows.Forms.Button btnC_clear;
    }
}