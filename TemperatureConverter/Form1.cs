using System;
using System.Windows.Forms;

//Satsuki Yamamoto
//Programming 1
//Temperature Converter
//2/6/2018

namespace TemperatureConverter
{
    public partial class FormTemp : Form
    {
        char charScale;
        string strOutput = "Fahrenheit(F°)\t\tCelsius(C°)\t\tKelvin(K°)\n\n";
        
        public FormTemp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end Exit

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxTemp.Text = "";
            rchTxtBoxTemp.Text = "";
            txtBxTemp.Focus();
            strOutput = "Fahrenheit(F°)\t\tCelsius(C°)\t\tKelvin(K°)\n\n";
            radBtnUnseen.Checked = true;
            
        }//end Clear

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                //Variables
                string strTemperature;
                double dblTemperature;

                strTemperature = txtBxTemp.Text;
                dblTemperature = Convert.ToDouble(strTemperature);

                //Instantiate
                Temperature thetemperature = new Temperature(charScale, dblTemperature);

                //Display
                strOutput += thetemperature.Fahrenheit.ToString("n2") + "°F" + "\t\t\t" +
                    thetemperature.Celsius.ToString("n2") + "°C" + "\t\t\t" +
                    thetemperature.Kelvin.ToString("n2") + "°K" + "\n";

                rchTxtBoxTemp.Text = strOutput;
                
            }//end try

            catch (FormatException)
            {
                MessageBox.Show("You must enter a number", "Error");
                txtBxTemp.SelectAll();
                txtBxTemp.Focus();

            }//end catch  
        }//end calculation


        //Selecting radio button

        private void radBtnFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            charScale = 'F';
            txtBxTemp.SelectAll();
            txtBxTemp.Focus();
        }//end Fahrenheit

        private void radBtnCelsius_CheckedChanged(object sender, EventArgs e)
        {
            charScale = 'C';
            txtBxTemp.SelectAll();
            txtBxTemp.Focus();
        }//end Celsius

        private void radBtnKelvin_CheckedChanged(object sender, EventArgs e)
        {
            charScale = 'K';
            txtBxTemp.SelectAll();
            txtBxTemp.Focus();
        }//end Kelvin
    }//end class
}//end namespace
