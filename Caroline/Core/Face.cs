using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caroline.Core
{
    class Face
    {
        private int id;

        public enum State { PASSION = 0, SERENITY = 1, INDIFFERENCE = 2, FEEBLENESS = 3, THANKS = 4, FAULT = 5, PERTURBATION = 6, };
        

        public void Fase(object i)
        {
            StateData(i);
            
        }

        public string StateData(object id)
        {
            switch ((int)id)
            {
                case 0:
                    return "";
                case 1:
                    return "";
                case 2:
                    return "";
                case 3:
                    return "";
                case 4:
                    return "";
                case 5:
                    return "";
                case 6:
                    return "";
                case 7:
                    return "";
                case 8:
                    return "";
                case 9:
                    return "";
                case 10:
                    return "";
                case 11:
                    return "";
                case 12:
                    return "";
            }
            return "NULL";
        }
    }
}
