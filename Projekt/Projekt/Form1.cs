using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Przyciski
        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Exit();
        }
        //Wyjscie
        private void Exit()
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjsc?", "Wyjscie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExitTool_Click(object sender, System.EventArgs e)
        {
            Exit();
        }
    }
}
