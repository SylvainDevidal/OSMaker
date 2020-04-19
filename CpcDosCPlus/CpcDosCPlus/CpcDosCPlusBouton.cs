using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CpcDosCPlus
{
    class CpcDosCPlusBouton : CpcDosCPlusObjet
    {
        public CpcDosCPlusBouton(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "bouton"; } }

        public string Handle
        {
            get
            {
                Attributes.TryGetValue(".handle", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".handle"))
                {
                    Attributes.Remove(".handle");
                }
                else
                {
                    Attributes[".handle"] = value;
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
        public string Texte
        {
            get
            {
                Attributes.TryGetValue(".texte", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".texte"))
                {
                    Attributes.Remove(".texte");
                }
                else
                {
                    Attributes[".texte"] = value;
                }
            }
        }
        public string Image
        {
            get
            {
                Attributes.TryGetValue(".image", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".image"))
                {
                    Attributes.Remove(".image");
                }
                else
                {
                    Attributes[".image"] = value;
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
