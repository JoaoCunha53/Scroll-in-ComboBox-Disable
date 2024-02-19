namespace Scroll_in_ComboBox_Disable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.MouseWheel += MainForm_MouseWheel;
        }

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}