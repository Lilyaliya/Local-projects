using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создание_управления_сетью_гостиниц
{
    class OpenClose
    {
        public OpenClose(Manager manager, Form1 form1)
        {
           form1.Hide();
            manager.Show();
        }

        public OpenClose(Administrator administrator, Form1 form1, DB.Componentes componentes)
        {
            form1.Hide();
            administrator.Admin.Text=componentes.Name+" "+componentes.Surname+" "+componentes.Otchestvo;
            administrator.HostelAd.Text = componentes.host;
            administrator.Show();
        }

        public OpenClose(EditionInsertion editionInsertion)
        {
            new EditionInsertion();
        }
    }
}
