using System;
using System.Collections.Generic;
using System.Text;

namespace I623_TarnusGabriel_24_01
{
    class Gun
    {
        private int _magazine;     
        private string _weapon;

        public Gun(int magazine, string weapon)
        {
            this._magazine = magazine;
            this._weapon = weapon;
        }
        
        public int Magazine
        {
            get { return _magazine; }
            set { _magazine = value; }
        }
        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }


        public string Reload(Character beatrice)
        {
            string information = "";
            
            if(beatrice.Ammuninitions != 0)
            {
                if (_magazine == 30)
                {
                    information = "It is unnecessery to reload your weapon";
                }
                else
                {
                    if (beatrice.Ammuninitions >= 30)
                    {
                        _magazine = 30;

                        beatrice.Ammuninitions -= 30;
                    }
                    else
                    {
                        _magazine = beatrice.Ammuninitions;

                        beatrice.Ammuninitions = 0;
                    }

                    information = "Reload successfull!";
                }
            }
            else
            {
                information = "You don't have ammos to reload your weapon. Pick up some";
            }
            
            return information;
        }

        public string Shoot(ref int kills)
        {
            string information = "";

            Random hit = new Random();
            int resultHit;

            if(_magazine != 0)
            {
                _magazine--;

                information = "You shot!";
                resultHit = hit.Next(1, 10);

                if (resultHit <= 5)
                {
                    information += " Student down! Good Shot!";
                    kills += 1;
                }
            }
            else
            {
                information = "Magazine empty! Reload your weapon to shoot";
            }

            return information;    
        }       
    }
}
