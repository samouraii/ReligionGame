using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace ReligionGame
{
   abstract class religions
    {
        public string religion1 = "Islaism";
        public string religion2 = "Judaisme";
        public string religion3 = "Christianisme";
        public static int nombre_d_habitant_religion1 = 200;
        public static int nombre_d_habitant_religion2 = 200;
        public static int nombre_d_habitant_religion3 = 200;
        public int nombre_de_ville_coquerit_de_la_religion1 = 1;
        public int nombre_de_ville_coquerit_de_la_religion2 = 1;
        public int nombre_de_ville_coquerit_de_la_religion3 = 1;
        public int fidele_christianisme = 10;
        public int fidele_islaism = 10;
        public int fidele_judaisme = 10;
        public int or_de_la_religion_1 = 1000;
        public int or_de_la_religion_2 = 1000;
        public int or_de_la_religion_3 = 1000;
        public int nombre_soldat_de_la_Religion_1 = (int) (nombre_d_habitant_religion1 / 3);
        public int nombre_soldat_de_la_Religion_2 = (int) (nombre_d_habitant_religion2 / 3);
        public int nombre_soldat_de_la_Religion_3 = (int) (nombre_d_habitant_religion3 / 3);

        public int Nombre_soldat_de_la_Religion_1
        {
            get
            {
                return nombre_soldat_de_la_Religion_1;
            }

            set
            {
                nombre_soldat_de_la_Religion_1 = value;
            }
        }
    }
}
