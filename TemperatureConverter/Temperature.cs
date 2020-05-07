using System;

namespace TemperatureConverter
{
    class Temperature
    {

        //instance variable
        private double dblFahrenheit, dblCelsius, dblKelvin;

        //constructor
        public Temperature(char scale, double temperature)
        {
            switch(scale)
            {
                case 'F':
                    dblFahrenheit = temperature;
                    dblCelsius = FahrenheitToCelsius();
                    dblKelvin = FarenheitToKelvin();
                    break;

                case 'C':
                    dblCelsius = temperature;
                    dblFahrenheit = CelsiusToFahrenheit();
                    dblKelvin = CelsiusToKelvin();
                    break;

                case 'K':
                    dblKelvin = temperature;
                    dblFahrenheit = KelvinToFarenheit();
                    dblCelsius = KelvinToCelsius();
                    break;

                default:
                    dblFahrenheit = 0;
                    dblCelsius = 0;
                    dblKelvin = 0;
                    break;

            }//end switch
        }//end constructor

        //Class Methods

        public double FahrenheitToCelsius()
        {
            dblCelsius = (dblFahrenheit - 32) * 5 / 9;
            return dblCelsius;
        }//end FahrenheitToCelsius

        public double FarenheitToKelvin()
        {
            dblKelvin = (dblFahrenheit - 32) * 5 / 9 + 273.15;
            return dblKelvin;
        }//end FarenheitToKelvin

        public double CelsiusToFahrenheit()
        {
            dblFahrenheit = dblCelsius * 1.8 + 32;
            return dblFahrenheit;
        }//end CelsiusToFahrenheit

        public double CelsiusToKelvin()
        {
            dblKelvin = dblCelsius + 273.15;
            return dblKelvin;
        }//end dblKelvin = CelsiusToKelvin

        public double KelvinToFarenheit()
        {
            dblFahrenheit = (dblKelvin - 273.15) * 1.8 + 32;
            return dblFahrenheit;
        }//end KelvinToFarenheit

        public double KelvinToCelsius()
        {
            dblCelsius = dblKelvin - 273.15;
            return dblCelsius;
        }//end KelvinToCelsius


        //Properties

        public double Fahrenheit
        {
            get
            {
                return dblFahrenheit;
            }
            set
            {
                dblFahrenheit = value;
            }
        }//end Fahrenheit

        public double Celsius
        {
            get
            {
                return dblCelsius;
            }
            set
            {
                dblCelsius = value;
            }
        }//end Celsius

        public double Kelvin
        {
            get
            {
                return dblKelvin;
            }
            set
            {
                dblKelvin = value;
            }
        }//end Kelvin
    }//end class
}//end namespace
