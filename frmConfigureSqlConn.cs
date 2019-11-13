using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NC.Util.SqlSrv.BackupRestore
{
    // ReSharper disable once InconsistentNaming
    public partial class frmConfigureSqlConn : Form
    {
        public string ConnectionString = String.Empty;

        public frmConfigureSqlConn()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void cmdGetSqlServers_Click(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable dtServers = instance.GetDataSources();
            if (dtServers.Rows.Count > 0)
            {
                foreach (DataRow dr in dtServers.Rows)
                {
                    string serverInstanceName;
                    string serverName = dr["ServerName"].ToString();
                    string instanceName = dr["InstanceName"].ToString();
                    if (instanceName == String.Empty)
                    {
                        serverInstanceName = serverName;
                    }
                    else
                    {
                        serverInstanceName = serverName + @"\" + instanceName;
                    }

                    cboAvailableSQLServers.Items.Add(serverInstanceName);
                }
            }
            else
            {
                cboAvailableSQLServers.Items.Add("CTB-MAXIMUS-PC");
            }

            if (cboAvailableSQLServers.Items.Count > 0)
            {
                cboAvailableSQLServers.SelectedIndex = 0;
            }
        }

        private void PopulateComboBoxes()
        {
            cboAuthentication.Items.Add("Windows Authentication");
            cboAuthentication.Items.Add("SQL Server Authentication");
            cboAuthentication.SelectedIndex = 0;
        }

        private void cboAuthentication_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string authentication = cboAuthentication.SelectedItem.ToString();
            if (authentication == "SQL Server Authentication")
            {
                txtLogin.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;
                txtLogin.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }

        private void cmdTestConnection_Click(object sender, EventArgs e)
        {
            string authentication = cboAuthentication.SelectedItem.ToString();
            string connString = "";
            
            if (authentication == "Windows Authentication")
            {
                connString = String.Format("Server={0};Database=master;Trusted_Connection=True", cboAvailableSQLServers.SelectedItem);
            }
            else if(authentication == "SQL Server Authentication")
            {
                connString = String.Format("Server={0};Database=master;User Id={1};Password={2};",cboAvailableSQLServers.SelectedItem, txtLogin.Text, txtPassword.Text);
            }

            txtConnectionString.Text = connString;
            ConnectionString = txtConnectionString.Text;

            try
            {
                // ReSharper disable once UnusedVariable
                using (SqlConnection sqlConn = new SqlConnection(connString))
                {
                    MessageBox.Show(@"SQL Connection succeeded!!!", @"SQL Backup and Restore Utility");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"SQL Connection test failed ... see the connection string below for possible anomalies.", @"SQL Backup and Restore Utility");
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
