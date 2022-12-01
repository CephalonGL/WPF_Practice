using Task_2_WPF_View;

namespace Task_2_WPF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainListView.Items.Add(new ListViewItem());
        }
    }
}