using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace TestSqlCommon
{
    public partial class Form1 : Form
    {
        #region Fields
        DbConnection connection;
        DbCommand command;
        DataTable table = new DataTable();
        #endregion Fields
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = table;
        }

        private void RdoMsAccess_CheckedChanged(object sender, EventArgs e)
        {
            String connection_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\\DB\\DbTest.accdb;";
            String command_text = "SELECT * FROM Staffs";
            this.connection = new OleDbConnection(connection_string);
            this.command = this.connection.CreateCommand();
            this.command.CommandText = command_text;
        }

        private void RdoSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            String connection_string = "Server=.;Database=DbTest;Integrated Security=true;";
            String command_text = "SELECT * FROM Staffs;";
            this.connection = new SqlConnection(connection_string);
            this.command = this.connection.CreateCommand();
            this.command.CommandText = command_text;
        }

        private async void BtnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.OpenAsync();
                DbDataReader reader = await command.ExecuteReaderAsync();
                table.Clear();
                table.Load(reader);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
