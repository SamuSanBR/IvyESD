using Microsoft.VisualBasic;
using System.Text;
using System.Text.RegularExpressions;

namespace IvyESD
{
    public partial class Scan : Form
    {

        public Scan()
        {
            InitializeComponent();


        }

        private void txtInputCode_KeyDown(object sender, KeyEventArgs e)
        {
            string pattern = "^[0-9]+$";
            if (e.KeyCode == Keys.Enter)
            {
                if (Regex.IsMatch(txtInputCode.Text, pattern) == true)
                {
                    MessageBox.Show("Entrou");
                    gbSelect.Visible = true;
                    txtInputCode.Enabled = false;
                    txtCode.Text = txtInputCode.Text;
                    gbInfo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                    txtInputCode.Text = "";
                }
            }

        }
    }
}