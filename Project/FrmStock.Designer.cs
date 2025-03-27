namespace Project
{
    partial class FrmStock
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnItem_Add = new System.Windows.Forms.Button();
            this.txtItem_Exdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItem_Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItem_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnSback = new System.Windows.Forms.Button();
            this.btnStock_Dlt = new System.Windows.Forms.Button();
            this.btnS_update = new System.Windows.Forms.Button();
            this.btnSClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSClear);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnItem_Add);
            this.groupBox1.Controls.Add(this.txtItem_Exdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtItem_Quantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtItem_Num);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtItem_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 382);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock details";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(132, 221);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(131, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // btnItem_Add
            // 
            this.btnItem_Add.BackColor = System.Drawing.Color.Pink;
            this.btnItem_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem_Add.ForeColor = System.Drawing.Color.Maroon;
            this.btnItem_Add.Location = new System.Drawing.Point(188, 345);
            this.btnItem_Add.Name = "btnItem_Add";
            this.btnItem_Add.Size = new System.Drawing.Size(75, 31);
            this.btnItem_Add.TabIndex = 11;
            this.btnItem_Add.Text = "Add";
            this.btnItem_Add.UseVisualStyleBackColor = false;
            this.btnItem_Add.Click += new System.EventHandler(this.btnItem_Add_Click);
            // 
            // txtItem_Exdate
            // 
            this.txtItem_Exdate.Location = new System.Drawing.Point(132, 177);
            this.txtItem_Exdate.Name = "txtItem_Exdate";
            this.txtItem_Exdate.Size = new System.Drawing.Size(131, 22);
            this.txtItem_Exdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expire Date";
            // 
            // txtItem_Quantity
            // 
            this.txtItem_Quantity.Location = new System.Drawing.Point(132, 137);
            this.txtItem_Quantity.Name = "txtItem_Quantity";
            this.txtItem_Quantity.Size = new System.Drawing.Size(131, 22);
            this.txtItem_Quantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // txtItem_Num
            // 
            this.txtItem_Num.Location = new System.Drawing.Point(132, 58);
            this.txtItem_Num.Name = "txtItem_Num";
            this.txtItem_Num.Size = new System.Drawing.Size(131, 22);
            this.txtItem_Num.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Number";
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.Location = new System.Drawing.Point(132, 99);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.Size = new System.Drawing.Size(131, 22);
            this.txtItem_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(284, 12);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(539, 311);
            this.dgvItem.TabIndex = 4;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // btnSback
            // 
            this.btnSback.BackColor = System.Drawing.Color.Pink;
            this.btnSback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSback.ForeColor = System.Drawing.Color.Maroon;
            this.btnSback.Location = new System.Drawing.Point(748, 363);
            this.btnSback.Name = "btnSback";
            this.btnSback.Size = new System.Drawing.Size(75, 31);
            this.btnSback.TabIndex = 13;
            this.btnSback.Text = "Back";
            this.btnSback.UseVisualStyleBackColor = false;
            this.btnSback.Click += new System.EventHandler(this.btnSback_Click);
            // 
            // btnStock_Dlt
            // 
            this.btnStock_Dlt.BackColor = System.Drawing.Color.Pink;
            this.btnStock_Dlt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock_Dlt.ForeColor = System.Drawing.Color.Maroon;
            this.btnStock_Dlt.Location = new System.Drawing.Point(284, 357);
            this.btnStock_Dlt.Name = "btnStock_Dlt";
            this.btnStock_Dlt.Size = new System.Drawing.Size(75, 31);
            this.btnStock_Dlt.TabIndex = 14;
            this.btnStock_Dlt.Text = "Delete";
            this.btnStock_Dlt.UseVisualStyleBackColor = false;
            this.btnStock_Dlt.Click += new System.EventHandler(this.btnStock_Dlt_Click);
            // 
            // btnS_update
            // 
            this.btnS_update.BackColor = System.Drawing.Color.Pink;
            this.btnS_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS_update.ForeColor = System.Drawing.Color.Maroon;
            this.btnS_update.Location = new System.Drawing.Point(394, 357);
            this.btnS_update.Name = "btnS_update";
            this.btnS_update.Size = new System.Drawing.Size(75, 31);
            this.btnS_update.TabIndex = 15;
            this.btnS_update.Text = "Update";
            this.btnS_update.UseVisualStyleBackColor = false;
            this.btnS_update.Click += new System.EventHandler(this.btnS_update_Click);
            // 
            // btnSClear
            // 
            this.btnSClear.BackColor = System.Drawing.Color.Pink;
            this.btnSClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnSClear.Location = new System.Drawing.Point(6, 345);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(75, 31);
            this.btnSClear.TabIndex = 14;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = false;
            this.btnSClear.Click += new System.EventHandler(this.btnSClear_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(835, 403);
            this.Controls.Add(this.btnS_update);
            this.Controls.Add(this.btnStock_Dlt);
            this.Controls.Add(this.btnSback);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItem);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnItem_Add;
        private System.Windows.Forms.TextBox txtItem_Exdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItem_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItem_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnSback;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStock_Dlt;
        private System.Windows.Forms.Button btnS_update;
        private System.Windows.Forms.Button btnSClear;
    }
}