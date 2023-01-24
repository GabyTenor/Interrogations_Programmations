using System;
using System.Collections.Generic;
using System.Text;

namespace I623_TarnusGabriel_24_01
{
    class Character
    {
        private string _name;
        private string _firstName;
        private int _ammunitions;

        public Character(string name, string firstName, int ammunitions)
        {
            this._name = name;
            this._firstName = firstName;
            this._ammunitions = ammunitions;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public int Ammuninitions
        {
            get { return _ammunitions; }
            set { _ammunitions = value; }
        }

        public bool LeftTheGame()
        {
            bool left = true;

            return left;
        }
        public string ViewATH(Gun ar15, int kills)
        {
            string ath = "ATH\n----------------\n" + "Gun : " + ar15.Weapon + "\nAmmos : " + ar15.Magazine + " | " + _ammunitions + "\nKills : " + kills + "\n----------------";

            return ath;
        }
        public string RefillAmmunitions()
        {
            string information = "";

            Random pickupAmmos = new Random();

            int ammosfound = pickupAmmos.Next(1, 31);

            _ammunitions += ammosfound;
            if(_ammunitions > 210)
            {
                _ammunitions = 210;

                information = "You found " + ammosfound + " bullets to put in your magazine, but there was too much to take everything";
            }
            else
            {
                information = "You found " + ammosfound + " bullets to put in your magazine";
            }
            return information;
        }
    }
}
