using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace LainsaSciTerminal
{
    public static class Icons
    {
        // Cargamos los iconos
        public static Icon icoProg = new Icon(System.IO.File.OpenRead("\\Storage Card\\nav_plain_blue.ico"), 16, 16);
        public static Icon icoPlan = new Icon(System.IO.File.OpenRead("\\Storage Card\\nav_plain_green.ico"), 16, 16);
        public static Icon icoReal = new Icon(System.IO.File.OpenRead("\\Storage Card\\nav_plain_red.ico"), 16, 16);
        public static Icon icoInci = new Icon(System.IO.File.OpenRead("\\Storage Card\\warning.ico"), 16, 16);
    }
}
