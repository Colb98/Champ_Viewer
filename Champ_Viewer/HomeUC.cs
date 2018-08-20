using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champ_Viewer
{
    public partial class HomeUC : UserControl
    {
        bool expand = false;
        public HomeUC()
        {
            InitializeComponent();
        }

        public void ChangeLayout()
        {
            expand = !expand;
            if (!expand)
                label1.Left = 21;
            else
                label1.Left = 96;
        }
    }
}
