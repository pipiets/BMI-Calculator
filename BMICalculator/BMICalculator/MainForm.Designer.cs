namespace BMICalculator
{
    partial class MainForm
    {

        private void InitializeComponent()
        {
            this.lblYourName = new System.Windows.Forms.Label();
            this.txtYourNameInput = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rdbUSUnitInput = new System.Windows.Forms.RadioButton();
            this.rdbMetricUnitInput = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalWeightDisplay = new System.Windows.Forms.Label();
            this.lblBMIMessageOutput = new System.Windows.Forms.Label();
            this.lblWeightCategoryOutput = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblBMIOutput = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.txtHeightInches = new System.Windows.Forms.TextBox();
            this.lblHeightIn = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.lblHeightFt = new System.Windows.Forms.Label();
            this.lblHeightInch = new System.Windows.Forms.Label();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(28, 21);
            this.lblYourName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(66, 13);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Nama Anda:";
            // 
            // txtYourNameInput
            // 
            this.txtYourNameInput.Location = new System.Drawing.Point(94, 18);
            this.txtYourNameInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtYourNameInput.Name = "txtYourNameInput";
            this.txtYourNameInput.Size = new System.Drawing.Size(243, 20);
            this.txtYourNameInput.TabIndex = 1;
            this.txtYourNameInput.TextChanged += new System.EventHandler(this.txtYourNameInput_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(8, 63);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(39, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Tinggi:";
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(68, 87);
            this.txtWeightInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(43, 20);
            this.txtWeightInput.TabIndex = 6;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rdbUSUnitInput);
            this.grpUnit.Controls.Add(this.rdbMetricUnitInput);
            this.grpUnit.Location = new System.Drawing.Point(215, 49);
            this.grpUnit.Margin = new System.Windows.Forms.Padding(1);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Padding = new System.Windows.Forms.Padding(1);
            this.grpUnit.Size = new System.Drawing.Size(188, 67);
            this.grpUnit.TabIndex = 2;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rdbUSUnitInput
            // 
            this.rdbUSUnitInput.AutoSize = true;
            this.rdbUSUnitInput.Checked = true;
            this.rdbUSUnitInput.Location = new System.Drawing.Point(8, 45);
            this.rdbUSUnitInput.Margin = new System.Windows.Forms.Padding(1);
            this.rdbUSUnitInput.Name = "rdbUSUnitInput";
            this.rdbUSUnitInput.Size = new System.Drawing.Size(108, 17);
            this.rdbUSUnitInput.TabIndex = 3;
            this.rdbUSUnitInput.TabStop = true;
            this.rdbUSUnitInput.Text = "US Unit (foot, lbs)";
            this.rdbUSUnitInput.UseVisualStyleBackColor = true;
            this.rdbUSUnitInput.CheckedChanged += new System.EventHandler(this.rdbUSUnitInput_CheckedChanged);
            // 
            // rdbMetricUnitInput
            // 
            this.rdbMetricUnitInput.AutoSize = true;
            this.rdbMetricUnitInput.Location = new System.Drawing.Point(8, 19);
            this.rdbMetricUnitInput.Margin = new System.Windows.Forms.Padding(1);
            this.rdbMetricUnitInput.Name = "rdbMetricUnitInput";
            this.rdbMetricUnitInput.Size = new System.Drawing.Size(114, 17);
            this.rdbMetricUnitInput.TabIndex = 2;
            this.rdbMetricUnitInput.Text = "Metric Unit (kg cm)";
            this.rdbMetricUnitInput.UseVisualStyleBackColor = true;
            this.rdbMetricUnitInput.CheckedChanged += new System.EventHandler(this.rdbMetricUnitInput_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(149, 127);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 46);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Hitung BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblNormalWeightDisplay);
            this.grpResults.Controls.Add(this.lblBMIMessageOutput);
            this.grpResults.Controls.Add(this.lblWeightCategoryOutput);
            this.grpResults.Controls.Add(this.lblWeightCategory);
            this.grpResults.Controls.Add(this.lblBMIOutput);
            this.grpResults.Controls.Add(this.lblYourBMI);
            this.grpResults.Location = new System.Drawing.Point(18, 175);
            this.grpResults.Margin = new System.Windows.Forms.Padding(1);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(1);
            this.grpResults.Size = new System.Drawing.Size(417, 156);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Hasil";
            // 
            // lblNormalWeightDisplay
            // 
            this.lblNormalWeightDisplay.AutoSize = true;
            this.lblNormalWeightDisplay.ForeColor = System.Drawing.Color.Green;
            this.lblNormalWeightDisplay.Location = new System.Drawing.Point(10, 117);
            this.lblNormalWeightDisplay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNormalWeightDisplay.Name = "lblNormalWeightDisplay";
            this.lblNormalWeightDisplay.Size = new System.Drawing.Size(155, 13);
            this.lblNormalWeightDisplay.TabIndex = 5;
            this.lblNormalWeightDisplay.Text = "Berat badan ideal anda adalah:";
            // 
            // lblBMIMessageOutput
            // 
            this.lblBMIMessageOutput.AutoSize = true;
            this.lblBMIMessageOutput.Location = new System.Drawing.Point(30, 88);
            this.lblBMIMessageOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBMIMessageOutput.Name = "lblBMIMessageOutput";
            this.lblBMIMessageOutput.Size = new System.Drawing.Size(252, 13);
            this.lblBMIMessageOutput.TabIndex = 4;
            this.lblBMIMessageOutput.Text = "BMI normal berada di kisaran angka 18.50 dan 24.9";
            // 
            // lblWeightCategoryOutput
            // 
            this.lblWeightCategoryOutput.AutoSize = true;
            this.lblWeightCategoryOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategoryOutput.Location = new System.Drawing.Point(108, 58);
            this.lblWeightCategoryOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeightCategoryOutput.Name = "lblWeightCategoryOutput";
            this.lblWeightCategoryOutput.Size = new System.Drawing.Size(138, 15);
            this.lblWeightCategoryOutput.TabIndex = 3;
            this.lblWeightCategoryOutput.Text = "Kategori Berat Badan Anda";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.Location = new System.Drawing.Point(5, 58);
            this.lblWeightCategory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(99, 13);
            this.lblWeightCategory.TabIndex = 2;
            this.lblWeightCategory.Text = "Kategori Berat Bdn:";
            // 
            // lblBMIOutput
            // 
            this.lblBMIOutput.AutoSize = true;
            this.lblBMIOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIOutput.Location = new System.Drawing.Point(108, 33);
            this.lblBMIOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBMIOutput.Name = "lblBMIOutput";
            this.lblBMIOutput.Size = new System.Drawing.Size(69, 15);
            this.lblBMIOutput.TabIndex = 1;
            this.lblBMIOutput.Text = "Output BMI  ";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(47, 33);
            this.lblYourBMI.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(57, 13);
            this.lblYourBMI.TabIndex = 0;
            this.lblYourBMI.Text = "BMI Anda:";
            // 
            // txtHeightInches
            // 
            this.txtHeightInches.Location = new System.Drawing.Point(126, 60);
            this.txtHeightInches.Margin = new System.Windows.Forms.Padding(1);
            this.txtHeightInches.Name = "txtHeightInches";
            this.txtHeightInches.Size = new System.Drawing.Size(30, 20);
            this.txtHeightInches.TabIndex = 5;
            // 
            // lblHeightIn
            // 
            this.lblHeightIn.AutoSize = true;
            this.lblHeightIn.Location = new System.Drawing.Point(156, 61);
            this.lblHeightIn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeightIn.Name = "lblHeightIn";
            this.lblHeightIn.Size = new System.Drawing.Size(0, 13);
            this.lblHeightIn.TabIndex = 11;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(10, 92);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(35, 13);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Berat:";
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(68, 60);
            this.txtHeightInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(43, 20);
            this.txtHeightInput.TabIndex = 4;
            // 
            // lblHeightFt
            // 
            this.lblHeightFt.AutoSize = true;
            this.lblHeightFt.Location = new System.Drawing.Point(113, 62);
            this.lblHeightFt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeightFt.Name = "lblHeightFt";
            this.lblHeightFt.Size = new System.Drawing.Size(13, 13);
            this.lblHeightFt.TabIndex = 9;
            this.lblHeightFt.Text = "ft";
            // 
            // lblHeightInch
            // 
            this.lblHeightInch.AutoSize = true;
            this.lblHeightInch.Location = new System.Drawing.Point(160, 62);
            this.lblHeightInch.Name = "lblHeightInch";
            this.lblHeightInch.Size = new System.Drawing.Size(38, 13);
            this.lblHeightInch.TabIndex = 13;
            this.lblHeightInch.Text = "inches";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 341);
            this.Controls.Add(this.lblHeightInch);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeightIn);
            this.Controls.Add(this.txtHeightInches);
            this.Controls.Add(this.lblHeightFt);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.txtWeightInput);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtYourNameInput);
            this.Controls.Add(this.lblYourName);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "Body Mass Index";
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.TextBox txtYourNameInput;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rdbUSUnitInput;
        private System.Windows.Forms.RadioButton rdbMetricUnitInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblBMIMessageOutput;
        private System.Windows.Forms.Label lblWeightCategoryOutput;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblBMIOutput;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.TextBox txtHeightInches;
        private System.Windows.Forms.Label lblHeightIn;
        private System.Windows.Forms.Label lblNormalWeightDisplay;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Label lblHeightFt;
        private System.Windows.Forms.Label lblHeightInch;
    }
}

