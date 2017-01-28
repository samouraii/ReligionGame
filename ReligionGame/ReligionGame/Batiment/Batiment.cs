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
    abstract class Batiment
    {
        public event EventHandler construction;

        public string nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public int coût
        {
            get
            {
                return coût;
            }
            set
            {
                coût = value;
            }
        }
        public int attente
        {
            get
            {
                return attente;
            }
            set
            {
                attente = value;
            }
        }
        public class Batiment_religieux
        {
            
            public int niveau
            {
                get
                {
                    return niveau;
                }
                set
                {
                    niveau = value;
                }
            }
            public string religion
            {
                get
                {
                    return religion;
                }
                set
                {
                    religion = value;
                }
            }
            public int OrGénéré
            {
                get
                {
                    return OrGénéré;
                }
                set
                {
                    OrGénéré = niveau*niveau*20;
                }
            }
        }
      
    }
}
