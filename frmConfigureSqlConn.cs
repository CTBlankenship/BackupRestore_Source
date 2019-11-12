using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NC.Util.SqlSrv.BackupRestore
{
    public partial class frmConfigureSqlConn : Form
    {
        public string ConnectionString = String.Empty;

        public frmConfigureSqlConn()
        {
            InitializeComponent();
        }

        private void cmdGetSqlServers_Click(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable dtServers = instance.GetDataSources();
            if (dtServers.Rows.Count > 0)
            {
                foreach (DataRow dr in dtServers.Rows)
                {
                    string serverInstanceName = String.Empty;
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
        }
    }
}
