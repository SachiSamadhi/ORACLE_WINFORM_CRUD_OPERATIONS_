using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;


namespace NewCRUDoperation
{
    public partial class Form1 : Form
    {

        OracleConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = "User Id=system;Password=ACSK#9594$wan;" +
                  "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
                  "(CONNECT_DATA=(SID=ORCL)));" +
                  "Connection Timeout=60;";
            con = new OracleConnection(conStr);
            Select();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertCRUD = con.CreateCommand();
            insertCRUD.CommandText = "INSERT INTO CRUDTABLE VALUES(\'" +
                ID.Text.ToString() + "\',\'" +
                NAME.Text.ToString() + "\',\'" +
                GENDER.Text.ToString() + "\',\'" +
                AGE.Text.ToString() + "\')";
            insertCRUD.CommandType = CommandType.Text;
            int rows = insertCRUD.ExecuteNonQuery();
            if (rows > 0) { MessageBox.Show("Data Inserted Successfully!"); }
            con.Close();


        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand deleteCRUD = con.CreateCommand();
            deleteCRUD.CommandText = "DELETE FROM CRUDTABLE WHERE ID = " + ID.Text.ToString();
            deleteCRUD.CommandType = CommandType.Text;
            int rows = deleteCRUD.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("DATA DELETED SUCCESSFULLY1");

            }
            else
            {
                MessageBox.Show("DATA NOT FOUND");
            }
            con.Close();

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand updateCRUD = con.CreateCommand();
            updateCRUD.CommandText = "UPDATE CRUDTABLE SET ID = " +
           ID.Text.ToString() +
            ",NAME = \'" + NAME.Text.ToString() + "\',GENDER =\'" +
           GENDER.Text.ToString() + "\',AGE =\'" + AGE.Text.ToString() + "\'WHERE ID = " + ID.Text.ToString();
            updateCRUD.CommandType = CommandType.Text;
            int rows = updateCRUD.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Data UPDATED Successfully!");
            }
            else
            {
                MessageBox.Show("Data Not Found to update");
            }
            con.Close();
        }

        private void SELECTION_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand selectCRUD = con.CreateCommand();
            selectCRUD.CommandText = "SELECT * FROM CRUDTABLE";
            selectCRUD.CommandType = CommandType.Text;
            OracleDataReader empDR = selectCRUD.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
