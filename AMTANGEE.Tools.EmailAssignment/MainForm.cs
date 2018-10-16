using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMTANGEE.Tools.EmailAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool isConnected = false;
        private void btnDoAssignment_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            edtSQLServer.Enabled = false;
            edtSQLUser.Enabled = false;
            edtSQLPassword.Enabled = false;
            edtSQLDatabase.Enabled = false;
            chkUseIntegratedSecurity.Enabled = false;
            btnDoAssignment.Enabled = false;

            if (!isConnected)
            {
                label2.Text = "Datenbankverbindung wird hergestellt...";
                Application.DoEvents();
                System.Data.SqlClient.SqlConnectionStringBuilder scb = new System.Data.SqlClient.SqlConnectionStringBuilder();

                scb.DataSource = edtSQLServer.Text;
                scb.PersistSecurityInfo = false;
                scb.InitialCatalog = edtSQLDatabase.Text;
                scb.IntegratedSecurity = chkUseIntegratedSecurity.Checked;
                scb.UserID = edtSQLUser.Text;
                scb.Password = edtSQLPassword.Text;
                scb.ConnectTimeout = 10;
                try
                {

                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(scb.ConnectionString);
                    
                    con.Open();
                    con.Close();
                    AMTANGEE.DB.Open(scb.ConnectionString);


                    isConnected = true;

                }
                catch(Exception exc)
                {
                    label2.Text = "";
                    label5.Text = "";
                    MessageBox.Show("Fehler beim Verbinden!\r\n\r\n" + exc.Message,"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            if (isConnected)
            {
                label2.Text = "Nachrichten ermitteln...";
                Application.DoEvents();
                AMTANGEE.SDK.Global.DoNotCheckRights = true;
                DataSet ds = AMTANGEE.DB.Select("select GUID from Messages (nolock) where [KIND] = 0 and ISNULL(CONTACT,'00000000-0000-0000-0000-000000000000') not in(select GUID from Contacts (nolock))");

                if (ds != null && ds.Tables.Count > 0)
                {
                    pbMain.Value = 0;
                    pbMain.Maximum = ds.Tables[0].Rows.Count;
                    AMTANGEE.SDK.Messages.Messages.BeginUpdate();
                    label2.Text = "";
                    Application.DoEvents();
                    DateTime dtStart = DateTime.Now;
                    int all = ds.Tables[0].Rows.Count;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        try
                        {
                            AMTANGEE.SDK.Messages.MessageBase m = AMTANGEE.SDK.Messages.MessageBase.Create(new Guid(row[0].ToString()));
                            if (m != null && m.ExistsAndLoaded)
                            {
                                if (m is AMTANGEE.SDK.Messages.Email)
                                {
                                    AMTANGEE.SDK.Messages.Email email = (AMTANGEE.SDK.Messages.Email)m;
                                    email.Contact = null;
                                    
                                    if (email.Direction == AMTANGEE.SDK.Messages.Directions.Inbound)
                                    {
                                        if (email.From.EmailAddress != null)
                                        {
                                            AMTANGEE.SDK.Messages.Email.Recipient.Kinds type = AMTANGEE.SDK.Messages.Email.Recipient.Kinds.Category;
                                            Guid guid = Guid.Empty;
                                            AMTANGEE.SDK.Messages.Email.Recipient.Parse(email.From.EmailAddress, out type, out guid);
                                            if (type == AMTANGEE.SDK.Messages.Email.Recipient.Kinds.ContactOrContactPerson)
                                            {
                                                email.Contact = AMTANGEE.SDK.Contacts.ContactBase.Create(guid);

                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (email.To.Count > 0)
                                        {
                                            AMTANGEE.SDK.Messages.Email.Recipient.Kinds type = AMTANGEE.SDK.Messages.Email.Recipient.Kinds.Category;
                                            Guid guid = Guid.Empty;
                                            AMTANGEE.SDK.Messages.Email.Recipient.Parse(email.To[0].EmailAddress, out type, out guid);
                                            if (type == AMTANGEE.SDK.Messages.Email.Recipient.Kinds.ContactOrContactPerson)
                                            {
                                                email.Contact = AMTANGEE.SDK.Contacts.ContactBase.Create(guid);

                                            }
                                        }
                                    }

                                    email.Save();
                                }
                            }
                        }
                        catch
                        {
                        }
                        pbMain.Value++;
                        TimeSpan tsNow = DateTime.Now - dtStart;
                        long temp = (tsNow.Ticks / pbMain.Value);


                        DateTime dt2 = dtStart.AddTicks(temp * pbMain.Maximum);

                        TimeSpan ts2 = dt2 - DateTime.Now;
                        if (ts2.Ticks > 0)
                            label5.Text = "Ungefähre Restdauer: " + ts2.Hours.ToString().PadLeft(2, '0') + ":" + ts2.Minutes.ToString().PadLeft(2, '0') + ":" + ts2.Seconds.ToString().PadLeft(2, '0');
                        else
                            label5.Text = "Ungefähre Restdauer: unbekannt";


                        label2.Text = pbMain.Value + " / " + all.ToString();
                        Application.DoEvents();
                    }
                }

                label2.Text = "";
                label5.Text = "Fertig";
                pbMain.Value = 0;
                AMTANGEE.SDK.Messages.Messages.EndUpdate();
            }

            edtSQLServer.Enabled = true;
            edtSQLUser.Enabled = !chkUseIntegratedSecurity.Checked;
            edtSQLPassword.Enabled = !chkUseIntegratedSecurity.Checked;
            edtSQLDatabase.Enabled = true;
            chkUseIntegratedSecurity.Enabled = true;
            btnDoAssignment.Enabled = true;
        }

        private void chkUseIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            edtSQLUser.Enabled = !chkUseIntegratedSecurity.Checked;
            edtSQLPassword.Enabled = !chkUseIntegratedSecurity.Checked;
        }
    }
}
