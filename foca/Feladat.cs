using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace foca
{
    internal class Feladat
    {

        public static List<Beolvas> list;
        public Feladat() 
        {
            list = new List<Beolvas>();
        }

        public void Beolvas(string file)
        {
            int fordulo = 0;
            int Hgol = 0;
            int Vgol = 0;
            int ElsoFelido = 0;
            int Masodikfel = 0;
            string hazai;
            string vendeg;
        
            foreach (var line in File.ReadAllLines(file, Encoding.UTF8).Skip(1))
            {
                var x = line.Trim().Split(' ');
                fordulo = Convert.ToInt32(x[0]);
                Hgol = Convert.ToInt32(x[1]);
                Vgol = Convert.ToInt32(x[2]);
                ElsoFelido = Convert.ToInt32(x[3]);
                Masodikfel = Convert.ToInt32(x[4]);
                hazai = x[5];
                vendeg = x[6];

                list.Add(new foca.Beolvas(fordulo, Hgol, Vgol, ElsoFelido, Masodikfel, hazai, vendeg));
                
            }
        }
        

    }
}
