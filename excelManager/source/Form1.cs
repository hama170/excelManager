using System.Windows.Forms;
using log4net;

namespace excelManager
{
    public partial class Form1 : Form
    {
        private static readonly ILog LOG = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();

            LOG.Info("情報の出力テスト");
        }
    }
}
