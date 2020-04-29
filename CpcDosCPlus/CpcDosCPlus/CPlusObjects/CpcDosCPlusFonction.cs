using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CpcDosCPlus
{
    class CpcDosCPlusFonction : CpcDosCPlusObjet
    {
        public CpcDosCPlusFonction(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "fonction"; } }

        public string Code
        {
            get
            {
                Attributes.TryGetValue(".code", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".code"))
                {
                    Attributes.Remove(".code");
                }
                else
                {
                    Attributes[".code"] = value;
                }
            }
        }
    }
}
