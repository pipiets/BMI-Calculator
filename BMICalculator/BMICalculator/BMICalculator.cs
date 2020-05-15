using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        // instance variables untuk class
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        /// method GetName()
        /// Deskripsi: Mendapatkan nama pengguna dari objek     
        public string GetName()
        {
            return name;
        } 
     
        /// method GetHeight()
        /// Deskripsi: Mendapatkan tinggi pengguna dari objek   
        public double GetHeight()
        {
            return height;
        }

      
        /// method GetWeight()
        /// Deskripsi: Mendapatkan berat badan pengguna dari objek
        public double GetWeight()
        {
            return weight;
        }

        /// method GetUnit()
        /// Deskripsi: method ini menentukan tipe unit pada objek
        public UnitTypes GetUnit()
        {
            return unit;
        }

        /// method SetName(string value)
        public void SetName(string value)
        {
            // Memastikan input user valid
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }


        /// method SetHeight(double value)
        /// Deskripsi: Set tinggi badan pengguna ke tipe data double 
        public void SetHeight(double value)
        {
            if (value > 0)
            {
                height = value;
            }
        } 


        /// method SetWeight(double value)
        public void SetWeight(double value)
        {
            // Berat badan harus lebih besar dari 0
            if (value > 0)
            {
                weight = value;
            }
        } 

        /// method SetUnit(UnitTypes value)
        /// Deskripsi: Set UnitType pada field objek
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        /// method BMIWeightCategory()
        public string BMIWeightCategory()
        {
            // Menghitung BMI
            double bmi = CalculateBMI();

            // Berdasarkan rentang BMI
            // Return kategori
            if(bmi > 40)
            {
                return "Overweight (Obesitas level III)";
            }
            else if (35.0 <= bmi)
            {
                return "Overweight (Obesitas level II)";
            }
            else if (30.0 <= bmi)
            {
                return "Overweight (Obesitas level I)";
            }
            else if (25.0 <= bmi)
            {
                return "Overweight (Pre-obesitas)";
            }
            else if (18.5 <= bmi)
            {
                return "Berat badan normal";
            }
            else 
            {
                return "Underweight";
            }
        } 

        /// method CalculateBMI()
        /// Deskripsi: method in menghitung dan me-return BMI
        public double CalculateBMI()
        {
            double bmi = 0.0;

            // Menghtiung BMI untuk sistem US
            if (unit == UnitTypes.American)
            {
                bmi = 703.0 * weight / (height * height);
            }
            else // Menghitung BMI untuk sistem metric
            {
                bmi = weight / (height * height);
            }

            return bmi;
        } 


        /// method CalculateWeight(double bmi)
        public double CalculateWeight(double bmi)
        {
            double weight = 0.0;

            // Jika menggunakan sistem US
            if (unit == UnitTypes.American)
            {
                weight = bmi * (this.GetHeight() * this.GetHeight()) / 703.0;
            }
            else // Jika menggunakan sistem metric
            {
                weight = bmi * (this.GetHeight() * this.GetHeight());
            }

            return weight;
        } 

    } 
} 
