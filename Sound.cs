using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Global;

namespace Sa
{
    public class Sou
    {

        public void zvk()
        {

            SoundPlayer sp = new SoundPlayer(PUK.zvuki);
            
            sp.Load();
            sp.Play();


        }

    }
}
