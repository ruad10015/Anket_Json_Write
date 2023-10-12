namespace Anket_Json
{
    partial class Form1
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
            this.groupBoxAnket = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.mskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxAnket.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnket
            // 
            this.groupBoxAnket.BackColor = System.Drawing.Color.White;
            this.groupBoxAnket.Controls.Add(this.btnClear);
            this.groupBoxAnket.Controls.Add(this.txtEmail);
            this.groupBoxAnket.Controls.Add(this.dtpBirthDate);
            this.groupBoxAnket.Controls.Add(this.mskTxtPhone);
            this.groupBoxAnket.Controls.Add(this.txtSurname);
            this.groupBoxAnket.Controls.Add(this.txtName);
            this.groupBoxAnket.Controls.Add(this.label5);
            this.groupBoxAnket.Controls.Add(this.label4);
            this.groupBoxAnket.Controls.Add(this.label3);
            this.groupBoxAnket.Controls.Add(this.label2);
            this.groupBoxAnket.Controls.Add(this.label1);
            this.groupBoxAnket.Controls.Add(this.btnAdd);
            this.groupBoxAnket.Controls.Add(this.btnChange);
            this.groupBoxAnket.Location = new System.Drawing.Point(12, 34);
            this.groupBoxAnket.Name = "groupBoxAnket";
            this.groupBoxAnket.Size = new System.Drawing.Size(521, 538);
            this.groupBoxAnket.TabIndex = 0;
            this.groupBoxAnket.TabStop = false;
            this.groupBoxAnket.Text = "Anket";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(6, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 53);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(195, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 39);
            this.txtEmail.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthDate.Location = new System.Drawing.Point(195, 367);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(282, 39);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2023, 10, 10, 0, 24, 0, 0);
            // 
            // mskTxtPhone
            // 
            this.mskTxtPhone.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mskTxtPhone.Location = new System.Drawing.Point(195, 293);
            this.mskTxtPhone.Mask = "000000000000";
            this.mskTxtPhone.Name = "mskTxtPhone";
            this.mskTxtPhone.Size = new System.Drawing.Size(284, 34);
            this.mskTxtPhone.TabIndex = 4;
            this.mskTxtPhone.ValidatingType = typeof(int);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurname.Location = new System.Drawing.Point(195, 148);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(284, 39);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(195, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 39);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birth Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name : ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(382, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Black;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChange.Location = new System.Drawing.Point(195, 431);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 53);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 40;
            this.listBox.Location = new System.Drawing.Point(558, 34);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(392, 484);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(558, 530);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(392, 42);
            this.txtFileName.TabIndex = 7;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(558, 578);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(178, 50);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(761, 578);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(962, 672);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBoxAnket);
            this.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket Page";
            this.groupBoxAnket.ResumeLayout(false);
            this.groupBoxAnket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnket;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox mskTxtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClear;
    }
}

