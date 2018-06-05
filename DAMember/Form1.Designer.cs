namespace DAMember
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonPreFill = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxProvinceCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.textBoxSpouseLstName = new System.Windows.Forms.TextBox();
            this.textBoxSpouseFstName = new System.Windows.Forms.TextBox();
            this.textBoxMemberLstName = new System.Windows.Forms.TextBox();
            this.textBoxMemberFstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMemberFstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMemberLstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSpouseFstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSpouseLstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPostCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFee = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberFstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberLstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSpouseFstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSpouseLstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(345, 404);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 51;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(234, 404);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 50;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonPreFill
            // 
            this.buttonPreFill.Location = new System.Drawing.Point(118, 404);
            this.buttonPreFill.Name = "buttonPreFill";
            this.buttonPreFill.Size = new System.Drawing.Size(75, 23);
            this.buttonPreFill.TabIndex = 49;
            this.buttonPreFill.Text = "Pre-Fill";
            this.buttonPreFill.UseVisualStyleBackColor = true;
            this.buttonPreFill.Click += new System.EventHandler(this.buttonPreFill_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Fee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Home Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Province Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Street Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Spouse\'s Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Spouse\'s First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Member\'s Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Member\'s First Name";
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(207, 358);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(232, 20);
            this.textBoxFee.TabIndex = 37;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(207, 332);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(232, 20);
            this.textBoxEmail.TabIndex = 36;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(207, 306);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(232, 20);
            this.textBoxPhone.TabIndex = 35;
            // 
            // textBoxProvinceCode
            // 
            this.textBoxProvinceCode.Location = new System.Drawing.Point(207, 254);
            this.textBoxProvinceCode.Name = "textBoxProvinceCode";
            this.textBoxProvinceCode.Size = new System.Drawing.Size(232, 20);
            this.textBoxProvinceCode.TabIndex = 34;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(207, 228);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(232, 20);
            this.textBoxCity.TabIndex = 33;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(207, 280);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(232, 20);
            this.textBoxPostalCode.TabIndex = 32;
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(207, 202);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(232, 20);
            this.textBoxStreetAddress.TabIndex = 31;
            // 
            // textBoxSpouseLstName
            // 
            this.textBoxSpouseLstName.Location = new System.Drawing.Point(207, 176);
            this.textBoxSpouseLstName.Name = "textBoxSpouseLstName";
            this.textBoxSpouseLstName.Size = new System.Drawing.Size(232, 20);
            this.textBoxSpouseLstName.TabIndex = 30;
            // 
            // textBoxSpouseFstName
            // 
            this.textBoxSpouseFstName.Location = new System.Drawing.Point(207, 150);
            this.textBoxSpouseFstName.Name = "textBoxSpouseFstName";
            this.textBoxSpouseFstName.Size = new System.Drawing.Size(232, 20);
            this.textBoxSpouseFstName.TabIndex = 29;
            // 
            // textBoxMemberLstName
            // 
            this.textBoxMemberLstName.Location = new System.Drawing.Point(207, 124);
            this.textBoxMemberLstName.Name = "textBoxMemberLstName";
            this.textBoxMemberLstName.Size = new System.Drawing.Size(232, 20);
            this.textBoxMemberLstName.TabIndex = 28;
            // 
            // textBoxMemberFstName
            // 
            this.textBoxMemberFstName.Location = new System.Drawing.Point(207, 98);
            this.textBoxMemberFstName.Name = "textBoxMemberFstName";
            this.textBoxMemberFstName.Size = new System.Drawing.Size(232, 20);
            this.textBoxMemberFstName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member Maintenance";
            // 
            // errorMemberFstName
            // 
            this.errorMemberFstName.ContainerControl = this;
            // 
            // errorMemberLstName
            // 
            this.errorMemberLstName.ContainerControl = this;
            // 
            // errorSpouseFstName
            // 
            this.errorSpouseFstName.ContainerControl = this;
            // 
            // errorSpouseLstName
            // 
            this.errorSpouseLstName.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorProvCode
            // 
            this.errorProvCode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvCode.ContainerControl = this;
            // 
            // errorPostCode
            // 
            this.errorPostCode.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorFee
            // 
            this.errorFee.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 484);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonPreFill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxProvinceCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxStreetAddress);
            this.Controls.Add(this.textBoxSpouseLstName);
            this.Controls.Add(this.textBoxSpouseFstName);
            this.Controls.Add(this.textBoxMemberLstName);
            this.Controls.Add(this.textBoxMemberFstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberFstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMemberLstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSpouseFstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSpouseLstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonPreFill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxProvinceCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.TextBox textBoxSpouseLstName;
        private System.Windows.Forms.TextBox textBoxSpouseFstName;
        private System.Windows.Forms.TextBox textBoxMemberLstName;
        private System.Windows.Forms.TextBox textBoxMemberFstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorMemberFstName;
        private System.Windows.Forms.ErrorProvider errorMemberLstName;
        private System.Windows.Forms.ErrorProvider errorSpouseFstName;
        private System.Windows.Forms.ErrorProvider errorSpouseLstName;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorCity;
        private System.Windows.Forms.ErrorProvider errorProvCode;
        private System.Windows.Forms.ErrorProvider errorPostCode;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorFee;
    }
}

