using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CpcDosCPlus
{
    class CpcDosCPlusFenetre : CpcDosCPlusObjet
    {
        public CpcDosCPlusFenetre(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "fenetre"; } }

        public string Titre
        {
            get
            {
                Attributes.TryGetValue(".titre", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".titre"))
                {
                    Attributes.Remove(".titre");
                }
                else
                {
                    Attributes[".titre"] = value;
                }
            }
        }
        public string Px
        {
            get
            {
                Attributes.TryGetValue(".px", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".px"))
                {
                    Attributes.Remove(".px");
                }
                else
                {
                    Attributes[".px"] = value;
                }
            }
        }
        public string Py
        {
            get
            {
                Attributes.TryGetValue(".py", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".py"))
                {
                    Attributes.Remove(".py");
                }
                else
                {
                    Attributes[".py"] = value;
                }
            }
        }
        public string Tx
        {
            get
            {
                Attributes.TryGetValue(".tx", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".tx"))
                {
                    Attributes.Remove(".tx");
                }
                else
                {
                    Attributes[".tx"] = value;
                }
            }
        }
        public string Ty
        {
            get
            {
                Attributes.TryGetValue(".ty", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".ty"))
                {
                    Attributes.Remove(".ty");
                }
                else
                {
                    Attributes[".ty"] = value;
                }
            }
        }
        public string Opacite
        {
            get
            {
                Attributes.TryGetValue(".Opacite", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Opacite"))
                {
                    Attributes.Remove(".Opacite");
                }
                else
                {
                    Attributes[".Opacite"] = value;
                }
            }
        }
        public string Parametres
        {
            get
            {
                Attributes.TryGetValue(".Parametres", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Parametres"))
                {
                    Attributes.Remove(".Parametres");
                }
                else
                {
                    Attributes[".Parametres"] = value;
                }
            }
        }
        public string CouleurFenetre
        {
            get
            {
                Attributes.TryGetValue(".CouleurFenetre", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".CouleurFenetre"))
                {
                    Attributes.Remove(".CouleurFenetre");
                }
                else
                {
                    Attributes[".CouleurFenetre"] = value;
                }
            }
        }
        public string CouleurTitre
        {
            get
            {
                Attributes.TryGetValue(".CouleurTitre", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".CouleurTitre"))
                {
                    Attributes.Remove(".CouleurTitre");
                }
                else
                {
                    Attributes[".CouleurTitre"] = value;
                }
            }
        }
        public string CouleurFond
        {
            get
            {
                Attributes.TryGetValue(".CouleurFond", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".CouleurFond"))
                {
                    Attributes.Remove(".CouleurFond");
                }
                else
                {
                    Attributes[".CouleurFond"] = value;
                }
            }
        }
        public string Icone
        {
            get
            {
                Attributes.TryGetValue(".Icone", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Icone"))
                {
                    Attributes.Remove(".Icone");
                }
                else
                {
                    Attributes[".Icone"] = value;
                }
            }
        }
        public string ImgTitre
        {
            get
            {
                Attributes.TryGetValue(".ImgTitre", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".ImgTitre"))
                {
                    Attributes.Remove(".ImgTitre");
                }
                else
                {
                    Attributes[".ImgTitre"] = value;
                }
            }
        }
        public string Event
        {
            get
            {
                Attributes.TryGetValue(".event", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".event"))
                {
                    Attributes.Remove(".event");
                }
                else
                {
                    Attributes[".event"] = value;
                }
            }
        }
    }
}
