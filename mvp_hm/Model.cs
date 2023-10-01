using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mvp_hm
{
    internal class Model : Imodel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Search { get; set; }

        public void AddInfo()
        {

        }

        public void DeleteInfo()
        {
            throw new NotImplementedException();
        }

        public void SearchInfo()
        {
            throw new NotImplementedException();
        }

        public void ShowAllInfo()
        {
            throw new NotImplementedException();
        }
    }
}
