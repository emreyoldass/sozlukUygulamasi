using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary.Entites
{
    public class kutuphane
    {
        //Propertylerimiz
        public Guid ID { get; set; }
        public string enKarsilik { get; set; }
        public string trKarsilik { get; set; }
        public string aciklama { get; set; }
        public string örnekKullanim { get; set; }

        //ToString metotunu override etmemizin sebebi ListBoxta görüntüleneceği zaman namespace ismi gözükecektir ToString override ederek bunu çözüyoruz.
        public override string ToString()
        {
            return $"{enKarsilik} - {trKarsilik}";
        }
    }
}
