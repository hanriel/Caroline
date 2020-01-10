using System.Windows.Forms;
using Caroline.Forms;
using System.Drawing;

namespace Caroline
{
    public partial class CoreLine : Form
    {


        public CoreLine()
        {
            InitializeComponent();
        }

        private void b_VI_Click(object sender, System.EventArgs e)
        {
            CoreLineVi f_VI = new CoreLineVi();
            f_VI.Show();
        }
    }
}
