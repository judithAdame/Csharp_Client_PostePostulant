using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_PostePostulant
{
    class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public string Langage { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
