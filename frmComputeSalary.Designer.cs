namespace _08EmployeeApplication
{
    partial class frmComputeSalary
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.tbHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblFirstName_Display = new System.Windows.Forms.Label();
            this.lblFirstNameHere = new System.Windows.Forms.Label();
            this.lblLastNameHere = new System.Windows.Forms.Label();
            this.lblLastName_Display = new System.Windows.Forms.Label();
            this.lblBasicSalaryHere = new System.Windows.Forms.Label();
            this.lblBasicSalary_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 37);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(218, 30);
            this.tbFirstName.TabIndex = 1;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(113, 257);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(239, 51);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute Salary";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(236, 37);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(218, 30);
            this.tbLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(236, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartment.Location = new System.Drawing.Point(12, 98);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(218, 30);
            this.tbDepartment.TabIndex = 6;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(12, 70);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(113, 25);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJobTitle.Location = new System.Drawing.Point(236, 98);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(218, 30);
            this.tbJobTitle.TabIndex = 8;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(236, 70);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(79, 25);
            this.lblJobTitle.TabIndex = 7;
            this.lblJobTitle.Text = "Job title";
            // 
            // tbHourlyRate
            // 
            this.tbHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHourlyRate.Location = new System.Drawing.Point(12, 221);
            this.tbHourlyRate.Name = "tbHourlyRate";
            this.tbHourlyRate.Size = new System.Drawing.Size(218, 30);
            this.tbHourlyRate.TabIndex = 10;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(12, 193);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(129, 25);
            this.lblHourlyRate.TabIndex = 9;
            this.lblHourlyRate.Text = "Rate per hour";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoursWorked.Location = new System.Drawing.Point(236, 221);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(218, 30);
            this.tbHoursWorked.TabIndex = 12;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(236, 193);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(178, 25);
            this.lblHoursWorked.TabIndex = 11;
            this.lblHoursWorked.Text = "Total hours worked";
            // 
            // lblFirstName_Display
            // 
            this.lblFirstName_Display.AutoSize = true;
            this.lblFirstName_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName_Display.Location = new System.Drawing.Point(12, 338);
            this.lblFirstName_Display.Name = "lblFirstName_Display";
            this.lblFirstName_Display.Size = new System.Drawing.Size(114, 25);
            this.lblFirstName_Display.TabIndex = 13;
            this.lblFirstName_Display.Text = "First name: ";
            // 
            // lblFirstNameHere
            // 
            this.lblFirstNameHere.AutoSize = true;
            this.lblFirstNameHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameHere.Location = new System.Drawing.Point(132, 338);
            this.lblFirstNameHere.Name = "lblFirstNameHere";
            this.lblFirstNameHere.Size = new System.Drawing.Size(164, 25);
            this.lblFirstNameHere.TabIndex = 14;
            this.lblFirstNameHere.Text = "<first name here>";
            // 
            // lblLastNameHere
            // 
            this.lblLastNameHere.AutoSize = true;
            this.lblLastNameHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameHere.Location = new System.Drawing.Point(132, 369);
            this.lblLastNameHere.Name = "lblLastNameHere";
            this.lblLastNameHere.Size = new System.Drawing.Size(164, 25);
            this.lblLastNameHere.TabIndex = 16;
            this.lblLastNameHere.Text = "<last name here>";
            // 
            // lblLastName_Display
            // 
            this.lblLastName_Display.AutoSize = true;
            this.lblLastName_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName_Display.Location = new System.Drawing.Point(12, 369);
            this.lblLastName_Display.Name = "lblLastName_Display";
            this.lblLastName_Display.Size = new System.Drawing.Size(114, 25);
            this.lblLastName_Display.TabIndex = 15;
            this.lblLastName_Display.Text = "Last name: ";
            // 
            // lblBasicSalaryHere
            // 
            this.lblBasicSalaryHere.AutoSize = true;
            this.lblBasicSalaryHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalaryHere.Location = new System.Drawing.Point(135, 401);
            this.lblBasicSalaryHere.Name = "lblBasicSalaryHere";
            this.lblBasicSalaryHere.Size = new System.Drawing.Size(61, 25);
            this.lblBasicSalaryHere.TabIndex = 18;
            this.lblBasicSalaryHere.Text = "00.00";
            // 
            // lblBasicSalary_Display
            // 
            this.lblBasicSalary_Display.AutoSize = true;
            this.lblBasicSalary_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSalary_Display.Location = new System.Drawing.Point(12, 401);
            this.lblBasicSalary_Display.Name = "lblBasicSalary_Display";
            this.lblBasicSalary_Display.Size = new System.Drawing.Size(123, 25);
            this.lblBasicSalary_Display.TabIndex = 17;
            this.lblBasicSalary_Display.Text = "Basic salary:";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.lblBasicSalaryHere);
            this.Controls.Add(this.lblBasicSalary_Display);
            this.Controls.Add(this.lblLastNameHere);
            this.Controls.Add(this.lblLastName_Display);
            this.Controls.Add(this.lblFirstNameHere);
            this.Controls.Add(this.lblFirstName_Display);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.tbHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.tbJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox tbHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblFirstName_Display;
        private System.Windows.Forms.Label lblFirstNameHere;
        private System.Windows.Forms.Label lblLastNameHere;
        private System.Windows.Forms.Label lblLastName_Display;
        private System.Windows.Forms.Label lblBasicSalaryHere;
        private System.Windows.Forms.Label lblBasicSalary_Display;
    }
}

