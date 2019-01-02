namespace WindowsFormsApp12
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int currentmenuPanelWidth;
        private void menuPanel_DoubleClick(object sender, System.EventArgs e)
        {
            if (menuPanel.Width != 10)
            {
                currentmenuPanelWidth = menuPanel.Width;
                menuPanel.Width = 10;
            }
            else
            {
                menuPanel.Width = currentmenuPanelWidth;
            }

        }
    }
}
