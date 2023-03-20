using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;


namespace IvyESD
{
    public partial class Scan : Form
    {
        String Id, Name, Test;
        SqlDataReader rdr;
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
                    gbSelect.Visible = true;
                    txtInputCode.Enabled = false;
                    txtCode.Text = txtInputCode.Text;
                    gbInfo.Visible = true;
                    Connection();
                    LookUpForUserInDB();

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
                try
            {
                myConn.Open();
                //MessageBox.Show("Connected", "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseConn()
        {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
                else
                {
                MessageBox.Show("Connection already closed", "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LookUpForUserInDB()
        {
            str = " SELECT Name, Test FROM dbo.USERS where Id = @inputcode ";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            myCommand.Parameters.AddWithValue("@inputcode", txtInputCode.Text);

            myCommand.ExecuteNonQuery();
            rdr = myCommand.ExecuteReader();
            while (rdr.Read())
            {
                Name = rdr["Name"].ToString();
                Test = rdr["Test"].ToString();
            }
            Id = txtInputCode.Text;
            txtName.Text = Name;
            txtTest.Text = Test;
            CloseConn();
        }

        private void InsertLogInDB()
        {
            str = "INSERT INTO dbo.LOG (UserId, Test_Date, Test) VALUES (@id, @date, @test)";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            myCommand.Parameters.AddWithValue("@id", Id);
            myCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            myCommand.Parameters.AddWithValue("@test", Test);
            myCommand.ExecuteNonQuery();
            MessageBox.Show("Registro salvo com sucesso", "IvyESD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void radbtnCalcanheira_Click(object sender, EventArgs e)
        {
            if (Test.ToString() != "Calcanheira")
            {
                DialogResult GoingRogue = MessageBox.Show("O teste obrigatório para esse usuário é diferente do informado. Deseja continuar?", "IvyESD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(GoingRogue == DialogResult.Yes)
                {
                    MessageBox.Show("MODO F LIGADO", "ROGUE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    radbtnCalcanheira.Enabled = false;
                    radbtnCalcanheiraPulseira.Enabled = false;
                    Test = "Calcanheira";
                    Connection();
                    InsertLogInDB();
                    CloseConn();
                    ResetScreen();
                }
                else
                {
                    MessageBox.Show("BOM MENINO", "PESSOA DE BEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radbtnCalcanheira.Checked = false;
                    radbtnCalcanheiraPulseira.Checked = false;
                }
            }
            else
            {
                radbtnCalcanheira.Enabled = false;
                radbtnCalcanheiraPulseira.Enabled = false;
                Connection();
                InsertLogInDB();
                CloseConn();
                ResetScreen();
            }
        }

        private void radbtnCalcanheiraPulseira_Click(object sender, EventArgs e)
        {
            if (Test.ToString() != "Calcanheira/Pulseira")
            {
                DialogResult GoingRogue = MessageBox.Show("O teste obrigatório para esse usuário é diferente do informado. Deseja continuar?", "IvyESD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (GoingRogue == DialogResult.Yes)
                {
                    MessageBox.Show("MODO F LIGADO", "ROGUE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    radbtnCalcanheiraPulseira.Enabled = false;
                    radbtnCalcanheira.Enabled = false;
                    radbtnCalcanheira.Enabled = false;
                    radbtnCalcanheiraPulseira.Enabled = false;
                    Test = "Calcanheira/Pulseira";
                    Connection();
                    InsertLogInDB();
                    CloseConn();
                    ResetScreen();
                }
                else
                {
                    MessageBox.Show("BOM MENINO", "PESSOA DE BEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radbtnCalcanheira.Checked = false;
                    radbtnCalcanheiraPulseira.Checked = false;
                }
            }
            else
            {
                radbtnCalcanheira.Enabled = false;
                radbtnCalcanheiraPulseira.Enabled = false;
                Connection();
                InsertLogInDB();
                CloseConn();
                ResetScreen();
            }
        }

        private void ResetScreen()
        {
            txtInputCode.Text = "";
            txtInputCode.Enabled = true;
            txtInputCode.Focus();

            radbtnCalcanheira.Checked = false;
            radbtnCalcanheiraPulseira.Checked = false;
            radbtnCalcanheira.Enabled = true;
            radbtnCalcanheiraPulseira.Enabled = true;

            txtCode.Text = "";
            txtName.Text = "";
            txtTest.Text = "";

            gbInfo.Visible = false;
            gbSelect.Visible = false;
        }

        
    }
}