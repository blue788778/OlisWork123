﻿namespace OlisWork
{
    partial class DataCRUD_form
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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShow.Location = new System.Drawing.Point(279, 32);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(485, 232);
            this.dgvShow.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 12);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "學號";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(43, 177);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "年級";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(108, 51);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 22);
            this.txtStuID.TabIndex = 5;
            this.txtStuID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_StuID_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(108, 220);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(43, 16);
            this.chkMarried.TabIndex = 7;
            this.chkMarried.Text = "Mar";
            this.chkMarried.UseVisualStyleBackColor = true;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboGrade.Location = new System.Drawing.Point(108, 177);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 20);
            this.cboGrade.TabIndex = 8;
            this.cboGrade.Text = "1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(153, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 38);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "編輯";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DataCURD_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvShow);
            this.Name = "DataCURD_form";
            this.Text = "DataCRUD";
            this.Load += new System.EventHandler(this.dataCURD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}