using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{


    public partial class MainForm : Form
    {
        // Meng-create instance kelas BMICalculator
        private BMICalculator bmiCalc = new BMICalculator();


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        } 

        private void InitializeGUI()
        {
            this.Text = "Kalkulator Index Masa Tubuh";

            // Pengaturan default untuk sistem pengukuran yang digunakan
            rdbUSUnitInput.Checked = false;
            rdbMetricUnitInput.Checked = true;
            lblHeight.Text = "Tinggi (cm)";
            lblWeight.Text = "Berat (kg)";

            // Clear textbox input user
            txtHeightInput.Text = string.Empty;
            txtWeightInput.Text = string.Empty;
            txtYourNameInput.Text = string.Empty;

            // Clear tampilan label output
            lblBMIOutput.Text = string.Empty;
            lblWeightCategoryOutput.Text = string.Empty;
            lblBMIMessageOutput.Text = string.Empty;
            lblNormalWeightDisplay.Text = string.Empty;
        } 
 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                DisplayResults(); 
            }
        } 

        private void rdbMetricUnitInput_CheckedChanged(object sender, EventArgs e)
        {
            // Jika sistem pengukuran metric dipilih
            if (rdbMetricUnitInput.Checked)
            {
     
                lblHeight.Text = "Tinggi (cm)";
                lblWeight.Text = "Berat (kg)";

                bmiCalc.SetUnit(UnitTypes.Metric);

                lblHeightFt.Visible = false;
                lblHeightInch.Visible = false;
                lblHeightIn.Visible = false;
                txtHeightInches.Visible = false;
            }
        } 

        private void rdbUSUnitInput_CheckedChanged(object sender, EventArgs e)
        {
          
            if (rdbUSUnitInput.Checked)
            {
                lblHeight.Text = "Tinggi (ft)";
                lblWeight.Text = "Berat (lbs)";

                bmiCalc.SetUnit(UnitTypes.American);

                lblHeightFt.Visible = true;
                lblHeightInch.Visible = true;
                lblHeightIn.Visible = true;
                txtHeightInches.Visible = true;
            }
        } 

        private bool ReadHeight()
        {
            double height = 0;
            double inches = 0;
            double inchesConverted = 0;

            bool ok = double.TryParse(txtHeightInput.Text.Trim(), out height);
            bool ok2 = double.TryParse(txtHeightInches.Text.Trim(), out inches);

           if(bmiCalc.GetUnit() == UnitTypes.American)
            {
               if (ok2 && (inches >= 0)) 
                {
                    inchesConverted = inches / 12;
                }
                else 
                {
                    MessageBox.Show("Nilai tinggi badan invalid (inches)!", "Error!");
                    return false;
                }
            }

          if (ok && (height > 0)) 
            {
                // Cek untuk melihat apakah sistem yang digunakan sistem US
                if (bmiCalc.GetUnit() == UnitTypes.American)
                {
                    bmiCalc.SetHeight((height + inchesConverted)* 12.00); 
                }
                else // Memproses tinggi badan dalam sistem metric
                {
                    bmiCalc.SetHeight(height/100.0); // cm  --> m
                }
            }
            else 
            {
                MessageBox.Show("Nilai tinggi badan invalid!","Error!");
                return false;
            }

            return ok;
        }
        private bool ReadInputBMI()
        {           
            
            if (rdbMetricUnitInput.Checked)
            {
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
            else 
            { 
                bmiCalc.SetUnit(UnitTypes.American);
            }

            ReadName();

            return ReadHeight() && ReadWeight();
        } 
     
        private void ReadName()
        {
            // Jika textbox user input bernilai null atau kosong
            if (string.IsNullOrEmpty(txtYourNameInput.Text.Trim()))
            {
                // Set ke nama default
                bmiCalc.SetName("No name");
            }
            else
            {
                bmiCalc.SetName(txtYourNameInput.Text.Trim());
            }
        } 
     
        private bool ReadWeight()
        {
            double outValue = 0;

            bool ok = double.TryParse(txtWeightInput.Text.Trim(), out outValue);

            if (ok && (outValue > 0)) 
            {
                bmiCalc.SetWeight(outValue);
            }
            else 
            {
                MessageBox.Show("Nilai berat badan invalid!", "Error!");
                return false;
            }

            return ok;
        } 

        private void DisplayResults()
        {
            // Menghitng dan menampilkan hasil BMI 
            lblBMIOutput.Text = bmiCalc.CalculateBMI().ToString("f2");

            // Menghitung dan menampilkan kategori berat badan
            lblWeightCategoryOutput.Text = bmiCalc.BMIWeightCategory().ToString();

            lblBMIMessageOutput.Text = "Angka BMI normal berada di kisaran 18.50 hingga 24.9 ";

            grpResults.Text = "Hasil perhitungan BMI untuk " + bmiCalc.GetName();

            // Jika user memilih sistem pengukuran US
            // Menghitung berat badan ideal dan menampilkan dalam sistem US
            if(bmiCalc.GetUnit() == UnitTypes.American)
            {
                lblNormalWeightDisplay.Text = "Berat badan normal Anda berada di rentang " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " hingga " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " lbs";
            }
            else // Menghitung dan menamilkan berat badan ideal dalam sistem metric
            {
                lblNormalWeightDisplay.Text = "Berat badan normal Anda berada di rentang " + bmiCalc.CalculateWeight(18.50).ToString("f2") + " hingga " + bmiCalc.CalculateWeight(24.9).ToString("f2") + " kg";
            }
        }

        private void txtYourNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 