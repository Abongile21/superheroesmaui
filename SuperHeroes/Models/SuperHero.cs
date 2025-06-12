using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SuperHero 
    {
        public bool HasSuperPower { get; set; }
        
        public string HeroPhoto { get; set; }
        public string HeroName { get; set; }
        public string AlterEgo { get; set; }
        public string Description { get; set; }

        private int powerStrength;

        public int PowerStrength
        {
            get { return powerStrength; }
            set
            {
                if (value > 0)
                {
                    powerStrength = value;
                }
                else
                    powerStrength = 0;
            }
        }

      /*  public int PowerStrength
        {
            get { return powerStrength; }
            set {  if (value > 0)
                {
                    powerStrength = value;
                }
                else
                    powerStrength = 0;
            
            }
        }
      */


        /*public bool GetSuperPower()
        {
            return hasSuperPower;
        }*/

        public SuperHero(string superHeroName, string alterEgo, string description,bool hasSuperPower, int powerStrength , string heroPhoto)
        {
            PowerStrength = powerStrength;
            HasSuperPower = hasSuperPower;
            HeroName = superHeroName;
            Description = description;
            AlterEgo = alterEgo;
            HeroPhoto = heroPhoto;
        }


        public override string ToString()
        {

            return base.ToString();
        }
    }
}
