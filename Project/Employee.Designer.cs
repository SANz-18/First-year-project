namespace Project
{
    partial class Employee
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
            this.comboBox_Emp = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnE_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemp_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnE_back = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnE_update = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.comboBox_Emp);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNIC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnE_Add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtemp_No);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 382);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee details";
            // 
            // comboBox_Emp
            // 
            this.comboBox_Emp.FormattingEnabled = true;
            this.comboBox_Emp.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_Emp.Location = new System.Drawing.Point(108, 179);
            this.comboBox_Emp.Name = "comboBox_Emp";
            this.comboBox_Emp.Size = new System.Drawing.Size(131, 23);
            this.comboBox_Emp.TabIndex = 16;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(108, 256);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(131, 22);
            this.txt_Address.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(108, 216);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(131, 22);
            this.txtNIC.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "NIC";
            // 
            // btnE_Add
            // 
            this.btnE_Add.BackColor = System.Drawing.Color.Pink;
            this.btnE_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE_Add.ForeColor = System.Drawing.Color.Maroon;
            this.btnE_Add.Location = new System.Drawing.Point(164, 345);
            this.btnE_Add.Name = "btnE_Add";
            this.btnE_Add.Size = new System.Drawing.Size(75, 31);
            this.btnE_Add.TabIndex = 11;
            this.btnE_Add.Text = "Add";
            this.btnE_Add.UseVisualStyleBackColor = false;
            this.btnE_Add.Click += new System.EventHandler(this.btnE_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(108, 140);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(131, 22);
            this.txtLName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(108, 103);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(131, 22);
            this.txtFName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // txtemp_No
            // 
            this.txtemp_No.Location = new System.Drawing.Point(108, 67);
            this.txtemp_No.Name = "txtemp_No";
            this.txtemp_No.Size = new System.Drawing.Size(131, 22);
            this.txtemp_No.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp_No";
            // 
            // btnE_back
            // 
            this.btnE_back.BackColor = System.Drawing.Color.Pink;
            this.btnE_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE_back.ForeColor = System.Drawing.Color.Maroon;
            this.btnE_back.Location = new System.Drawing.Point(831, 354);
            this.btnE_back.Name = "btnE_back";
            this.btnE_back.Size = new System.Drawing.Size(75, 31);
            this.btnE_back.TabIndex = 16;
            this.btnE_back.Text = "Back";
            this.btnE_back.UseVisualStyleBackColor = false;
            this.btnE_back.Click += new System.EventHandler(this.btnE_back_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(270, 3);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(636, 221);
            this.dgvEmployee.TabIndex = 17;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(280, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnE_update
            // 
            this.btnE_update.BackColor = System.Drawing.Color.Pink;
            this.btnE_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE_update.ForeColor = System.Drawing.Color.Maroon;
            this.btnE_update.Location = new System.Drawing.Point(372, 348);
            this.btnE_update.Name = "btnE_update";
            this.btnE_update.Size = new System.Drawing.Size(75, 31);
            this.btnE_update.TabIndex = 18;
            this.btnE_update.Text = "Update";
            this.btnE_update.UseVisualStyleBackColor = false;
            this.btnE_update.Click += new System.EventHandler(this.btnE_update_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Pink;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(10, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(918, 397);
            this.Controls.Add(this.btnE_update);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnE_back);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Employee";
            this.Text = "Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnE_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemp_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnE_back;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ComboBox comboBox_Emp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnE_update;
        private System.Windows.Forms.Button btnClear;
    }
}