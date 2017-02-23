using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminaVentana
{

    class Casilla{

        public bool levantada;
        public int num;
        public bool bomba;

        //Constructor

        public Casilla(){
            levantada = false;
            num = 0;
            bomba = false;
        }

        //Hacer get y set

        public override string ToString()
        {
            if(!levantada){
                return "";
            }else if(bomba){
                return "B";
            }else{
                return "" + num;
            }
        }

    }
}
