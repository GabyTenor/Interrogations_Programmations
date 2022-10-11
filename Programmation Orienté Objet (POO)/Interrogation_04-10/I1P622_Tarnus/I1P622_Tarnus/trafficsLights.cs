using System;
using System.Collections.Generic;
using System.Text;

namespace I1P622_Tarnus
{
    class trafficsLights
    {
        private string _color;
        private int _number;
        private string _status;
        public trafficsLights(string _color, int _number, string _status)
        {
            this._color = _color;
            this._number = _number;
            this._status = _status;
        }
        public string LightsStatus()
        {
            string statusInfo = "The traffic light " + _number;

            switch (_status)
            {
                case "On":
                    statusInfo = statusInfo + " is on";
                    break;

                case "Off":
                    statusInfo = statusInfo + " is off!!!!!";
                    break;
            }
            
            if(_status != "Off")
            {
                statusInfo = statusInfo + " and is showing the color " + _color;
            }

            return statusInfo;
        }

        public void ChangeColors(int i)
        {     
            switch (i)
            {
                case 0:
                    _color = "Green";
                    break;

                case 1:
                    _color = "Orange";
                    break;

                case 2:
                    _color = "Red";
                    break;
            }           
        }

        public void LightBlink(int j)
        {
            if(j == 0)
            {
                _status = "On";
            }
            else if(j == 1)
            {
                _status = "Off";
            }
        }
    }    
}
