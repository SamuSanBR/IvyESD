using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;


namespace IvyESD
{
    public partial class Scan : Form
    {

        String str;
        SqlConnection myConn = new SqlConnection("Server=VAL1WLAPGXK2XT2\\SQLEXPRESS;Integrated security=SSPI;database=IvyESD;Trust Server Certificate=true");
        public Scan()
        {
            InitializeComponent();

        }


        private void txtInputCode_KeyDown(object sender, KeyEventArgs e)
        {
            //define o padrão de inserção para somente números
            string pattern = "^[0-9]+$";
            if (e.KeyCode == Keys.Enter)
            {   
                //checa se a entrada contém somente números
                if (Regex.IsMatch(txtInputCode.Text, pattern) == true)
                {
                    MessageBox.Show("Entrou");
                    gbSelect.Visible = true;
                    txtInputCode.Enabled = false;
                    txtCode.Text = txtInputCode.Text;
                    gbInfo.Visible = true;
                    Connection();
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                    txtInputCode.Text = "";
                }
            }

        }

        private void Connection()
        {
            str = "SELECT * FROM dbo.USERS where Id = ";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Criou a conn", "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}