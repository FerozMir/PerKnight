using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Collections;

namespace PostInvoice
{
    public partial class BQPostInvoice : Form
    {
        public BQPostInvoice()
        {
            InitializeComponent();
        }
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        private void BQPostInvoice_Load(object sender, EventArgs e)
        {
            rbtnUnposted.Checked = true;
            ProjectPnl.Visible = false;
            ClientPnl.Visible = false;
            InvPnl.Visible = false;
            DatePnl.Visible = false;
            progressBar1.Visible = false;
            ProjectGRPpnl.Visible = false;
            PrgMngPnl.Visible = false;
            fillG_noFiletr();
      


        }


                   private void fillG_noFiletr()
        {

            try
            {


                if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }

                if (rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,Max(ClientID) as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='Y' and IsDraft=0 group by transactionInvNum order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);

                        DGV_PostInvoice.DataSource = null;
                        DGV_PostInvoice.DataSource = t;
                    }

                }

                if (RdbtnPosted.Checked == true)
                {

                    using (SqlDataAdapter a = new SqlDataAdapter(
"SELECT max(ProjectID) as Project,Max(ClientID) as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
"FROM transactiontable where payid is null and TransactionInvSendBillFlag ='B' and IsDraft=0 group by transactionInvNum order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = null;
                        DGV_PostInvoice.DataSource = t;
                    }

                }


                         this.DGV_PostInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;






            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }





        }


        //Fill Comboxes function

            private void fillcomb()
        {

try
            {



                        // DGV_PostInvoice.DataSource = null;

                               

                if(InvPnl.Visible==true && RdbtnPosted.Checked == true)
                {
                    

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct Transactioninvnum  FROM transactiontable where TransactionInvSendBillFlag='B' and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbInv.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbInv.DisplayMember = "Transactioninvnum";
                        cmbInv.ValueMember = "Transactioninvnum";

                        cmbInv.DataSource = tblShapes;
                    }





                }


                else if (InvPnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct Transactioninvnum  FROM transactiontable where TransactionInvSendBillFlag='Y' and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbInv.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbInv.DisplayMember = "Transactioninvnum";
                        cmbInv.ValueMember = "Transactioninvnum";

                        cmbInv.DataSource = tblShapes;
                    }

                }



                else if(ProjectPnl.Visible==true && RdbtnPosted.Checked == true)
                {


                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct projectid  FROM transactiontable where TransactionInvSendBillFlag='B'and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbproject.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbproject.DisplayMember = "projectid";
                        cmbproject.ValueMember = "projectid";

                        cmbproject.DataSource = tblShapes;
                    }




                }


                else if (ProjectPnl.Visible == true && rbtnUnposted.Checked == true)
                {

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct projectid  FROM transactiontable where TransactionInvSendBillFlag='Y' and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbproject.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbproject.DisplayMember = "projectid";
                        cmbproject.ValueMember = "projectid";

                        cmbproject.DataSource = tblShapes;
                    }
                }



                else if (ClientPnl.Visible == true && RdbtnPosted.Checked == true)
                {
                    
                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct clientid  FROM transactiontable where TransactionInvSendBillFlag='B'and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbclt.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbclt.DisplayMember = "clientid";
                        cmbclt.ValueMember = "clientid";

                        cmbclt.DataSource = tblShapes;
                    }








                }


                //------------------Fill combobox for project groups---------------------
                else if (ProjectGRPpnl.Visible == true && rbtnUnposted.Checked == true)
                {

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct pgid  FROM projectgroup", SqlCon))
                    {

                        pRjGRPCmb.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        pRjGRPCmb.DisplayMember = "pgid";
                        pRjGRPCmb.ValueMember = "pgid";

                        pRjGRPCmb.DataSource = tblShapes;
                    }
                }



                else if (ProjectGRPpnl.Visible == true && RdbtnPosted.Checked == true)
                {

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct pgid  FROM projectgroup", SqlCon))
                    {

                        pRjGRPCmb.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        pRjGRPCmb.DisplayMember = "pgid";
                        pRjGRPCmb.ValueMember = "pgid";

                        pRjGRPCmb.DataSource = tblShapes;
                    }








                }

                //---------------------------Project group end




                //------------------Fill combobox for project Manager---------------------
                else if (PrgMngPnl.Visible == true && rbtnUnposted.Checked == true)
                {

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct employeeid  FROM project", SqlCon))
                    {

                        cmbPrgMng.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbPrgMng.DisplayMember = "employeeid";
                        cmbPrgMng.ValueMember = "employeeid";

                        cmbPrgMng.DataSource = tblShapes;
                    }
                }



                else if (PrgMngPnl.Visible == true && RdbtnPosted.Checked == true)
                {

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct employeeid  FROM project", SqlCon))
                    {

                        cmbPrgMng.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbPrgMng.DisplayMember = "employeeid";
                        cmbPrgMng.ValueMember = "employeeid";

                        cmbPrgMng.DataSource = tblShapes;
                    }








                }

                //---------------------------Project Manager end

                



                else if (ClientPnl.Visible == true && rbtnUnposted.Checked == true)
                {
                   

                    if (SqlCon != null && SqlCon.State == ConnectionState.Closed)
                    {
                        SqlCon.Open();
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT distinct clientid  FROM transactiontable where TransactionInvSendBillFlag='Y'and IsDraft=0 and payid is null", SqlCon))
                    {

                        cmbclt.DataSource = null;
                        SqlDataAdapter dap = new SqlDataAdapter(cmd);
                        DataTable tblShapes = new DataTable();
                        dap.Fill(tblShapes);

                        cmbclt.DisplayMember = "clientid";
                        cmbclt.ValueMember = "clientid";

                        cmbclt.DataSource = tblShapes;
                    }




                }


             
                //this.DGV_PostInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.DGV_PostInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        





        private void Fillgrid()
        {
            try
            {
               // DGV_PostInvoice.DataSource = null;

                               

                if(InvPnl.Visible==true && RdbtnPosted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,Max(ClientID) as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='B' and IsDraft=0 and TransactionInvNum='" + cmbInv.Text + "' group by transactionInvNum order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }

               
                }


                else if (InvPnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,Max(ClientID) as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='Y' and IsDraft=0 and TransactionInvNum='" + cmbInv.Text + "' group by transactionInvNum order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }


                   
                }



                else if(ProjectPnl.Visible==true && RdbtnPosted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT ProjectID as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='B' and IsDraft=0 and projectid ='" + cmbproject.Text + "' group by transactionInvNum,clientid,projectid order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }



                }


                else if (ProjectPnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT ProjectID as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='Y' and IsDraft=0 and projectid ='" + cmbproject.Text + "' group by transactionInvNum,clientid,projectid order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }


                    

                }

                //-------------------Project group-------------
                else if (ProjectGRPpnl.Visible == true && RdbtnPosted.Checked == true)
                {
              

                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT  max(transactiontable.ProjectID) as Project,Max(transactiontable.ClientID) as Client,sum(transactiontable.TransactionInvBillAmt) as InvoiceAmount" +
          ", max(transactiontable.InvoiceDate) as InvoiceDate, transactiontable.TransactionInvNum as InvoiceNumber  FROM Project INNER JOIN(Payment RIGHT JOIN TransactionTable ON Payment.PayID = TransactionTable.PayID) ON Project.ProjectID = TransactionTable.ProjectID WHERE((Project.ProjectID IN(SELECT ProjectGroupDetail.ProjectID" +
          " FROM ProjectGroupDetail  WHERE ProjectGroupDetail.PGID IN('"+ pRjGRPCmb.Text + "')))  AND(TransactionTable.IsDraft = 0 OR TransactionTable.IsDraft Is Null)   AND(TransactionTable.TransactionInvNum) <> '0' and (transactiontable.TransactionInvSendBillFlag='B'))  GROUP BY TransactionTable.TransactionInvNum ORDER BY TransactionTable.TransactionInvNum ", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }



                }


                else if (ProjectGRPpnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
         "SELECT  max(transactiontable.ProjectID) as Project,Max(transactiontable.ClientID) as Client,sum(transactiontable.TransactionInvBillAmt) as InvoiceAmount" +
         ", max(transactiontable.InvoiceDate) as InvoiceDate, transactiontable.TransactionInvNum as InvoiceNumber  FROM Project INNER JOIN(Payment RIGHT JOIN TransactionTable ON Payment.PayID = TransactionTable.PayID) ON Project.ProjectID = TransactionTable.ProjectID WHERE((Project.ProjectID IN(SELECT ProjectGroupDetail.ProjectID" +
         " FROM ProjectGroupDetail  WHERE ProjectGroupDetail.PGID IN('" + pRjGRPCmb.Text + "')))  AND(TransactionTable.IsDraft = 0 OR TransactionTable.IsDraft Is Null)   AND(TransactionTable.TransactionInvNum) <> '0' and (transactiontable.TransactionInvSendBillFlag='Y'))  GROUP BY TransactionTable.TransactionInvNum ORDER BY TransactionTable.TransactionInvNum ", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }




                }

                //---project group end









                //----------------------Project Manager---------
               
                else if (PrgMngPnl.Visible == true && RdbtnPosted.Checked == true)
                {


                    using (SqlDataAdapter a = new SqlDataAdapter(
          "select max(transactiontable.ProjectID) as Project,Max(transactiontable.ClientID) as Client,sum(transactiontable.TransactionInvBillAmt) as InvoiceAmount"+
         ", max(transactiontable.InvoiceDate) as InvoiceDate, transactiontable.TransactionInvNum as InvoiceNumber"+
" FROM Project INNER JOIN(Payment RIGHT JOIN TransactionTable ON Payment.PayID = TransactionTable.PayID) ON Project.ProjectID = TransactionTable.ProjectID WHERE((Project.EmployeeID IN('"+cmbPrgMng.Text + "'))  AND(TransactionTable.IsDraft = 0 OR TransactionTable.IsDraft Is Null)   AND(TransactionTable.TransactionInvNum) <> '0' and (transactiontable.TransactionInvSendBillFlag='B')) GROUP BY TransactionTable.TransactionInvNum; ", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }



                }


                else if (PrgMngPnl.Visible == true && rbtnUnposted.Checked == true)
                {

                    using (SqlDataAdapter a = new SqlDataAdapter(
          "select max(transactiontable.ProjectID) as Project,Max(transactiontable.ClientID) as Client,sum(transactiontable.TransactionInvBillAmt) as InvoiceAmount" +
         ", max(transactiontable.InvoiceDate) as InvoiceDate, transactiontable.TransactionInvNum as InvoiceNumber" +
" FROM Project INNER JOIN(Payment RIGHT JOIN TransactionTable ON Payment.PayID = TransactionTable.PayID) ON Project.ProjectID = TransactionTable.ProjectID WHERE((Project.EmployeeID IN('" + cmbPrgMng.Text + "'))  AND(TransactionTable.IsDraft = 0 OR TransactionTable.IsDraft Is Null)   AND(TransactionTable.TransactionInvNum) <> '0' and (transactiontable.TransactionInvSendBillFlag='Y')) GROUP BY TransactionTable.TransactionInvNum; ", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }




                }

                //---project manager end




                else if (ClientPnl.Visible == true && RdbtnPosted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='B' and IsDraft=0 and clientid ='" + cmbclt.Text + "' group by transactionInvNum,clientid order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }



                }

                else if (ClientPnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='Y' and IsDraft=0 and clientid ='" + cmbclt.Text + "' group by transactionInvNum,clientid order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }


                   

                }


                else if (DatePnl.Visible == true && RdbtnPosted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",InvoiceDate as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='B' and IsDraft=0 and invoicedate between '" + (datefrom.Value.Date) + "' and '" + (dateto.Value.Date) + "' group by transactionInvNum,clientid,invoicedate order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }
                }

                else if (DatePnl.Visible == true && rbtnUnposted.Checked == true)
                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
          "SELECT max(ProjectID) as Project,ClientID as Client,sum(TransactionInvBillAmt) as InvoiceAmount" +
          ",max(InvoiceDate) as InvoiceDate,TransactionInvNum as InvoiceNumber " +
          "FROM transactiontable where payid is null and TransactionInvSendBillFlag ='Y' and IsDraft=0 and  invoicedate between '" + (datefrom.Value.Date) + "' and '" + (dateto.Value.Date) + "' group by transactionInvNum,clientid,invoicedate order by Invoicedate,TransactionInvNum", SqlCon))
                    {
                        DataTable t = new DataTable();
                        a.Fill(t);
                        DGV_PostInvoice.DataSource = t;
                    }
                }


                //this.DGV_PostInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //this.DGV_PostInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PostInv_Click(object sender, EventArgs e)
        {
            try
            {


                string Flag="True";
              
               
   string InvoiceNumber;

                int count = 0;
                int count_ = 0;
                label5.Text = "";

                progressBar1.Visible = true;

                foreach (DataGridViewRow row in DGV_PostInvoice.Rows)

                {
                    if (Convert.ToBoolean(row.Cells["PostCheckBox1"].Value) == true)
                    {
                        count = count + 1;
                    }
                }

                progressBar1.Maximum = count;

                SqlCommand cmd;
                foreach (DataGridViewRow row in DGV_PostInvoice.Rows)

                {



                    if (Convert.ToBoolean(row.Cells["PostCheckBox1"].Value) == true)
                    {
                        count_ = count_ + 1;

                        label5.Text = "In Progress...." + count_ +"/"+ count;

                        label5.Update();
                        System.Threading.Thread.Sleep(500);

                        Flag = "False";
                        progressBar1.Value = count_;

                        
                        InvoiceNumber = row.Cells["InvoiceNumber"].Value.ToString();
                    

                        cmd = new SqlCommand("update transactiontable set TransactionInvSendBillFlag='B' where payid is null and TransactionInvNum='" + InvoiceNumber + "'", SqlCon);
                        cmd.CommandTimeout = 500000;
                       
                        cmd.ExecuteNonQuery();
                   

                    }

                }
            

if(Flag=="False")

                {

                    label5.Text = "Done...." + count_ +"/"+ count;

                    MessageBox.Show("Invoice Posted Successfully");

                    //progressBar1.Value = 0;
                    
                    fillG_noFiletr();
            }

            else
            {
                MessageBox.Show("No invoice is selected for Posting");
                //Fillgrid(string.Empty);
            }

        

        }


            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Visible = false;
            label5.Text = "";
            checkBox1.Checked = false;


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (InvPnl.Visible == true)
            {

            if (cmbInv.Text != "") 
                Fillgrid();
            }

            if (ClientPnl.Visible == true)
            {

                if (cmbclt.Text != "")
                    Fillgrid();
            }

            if (ProjectPnl.Visible == true)
            {

                if (cmbproject.Text != "")
                    Fillgrid();
            }


            if (DatePnl.Visible == true)
            {

                //if (ProjectTxtbx.Text != "")
                    Fillgrid();
            }


            if (ProjectGRPpnl.Visible == true)
            {

                //if (ProjectTxtbx.Text != "")
                Fillgrid();
            }

            //--------------Project Manager------
            if (PrgMngPnl.Visible == true)
            {

                //if (ProjectTxtbx.Text != "")
                Fillgrid();
            }

            //-----------

            checkBox1.Checked = false;

        }

        private void btn_CancelSearch_Click(object sender, EventArgs e)
        {
            fillG_noFiletr();
            checkBox1.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToString(comboBox1.SelectedItem)=="Project")
            {
                ClientPnl.Visible = false;
                InvPnl.Visible = false;
                DatePnl.Visible = false;
                ProjectPnl.Visible = true;
                ProjectGRPpnl.Visible = false;
                PrgMngPnl.Visible = false;
                ProjectPnl.Location = new Point(240, 1);
                fillG_noFiletr();
                fillcomb();
                

            }

           

            if (Convert.ToString(comboBox1.SelectedItem) == "Client")
            {
                ProjectPnl.Visible = false;
                InvPnl.Visible = false;
                DatePnl.Visible = false;
                ClientPnl.Visible = true;
                ProjectGRPpnl.Visible = false;
                PrgMngPnl.Visible = false;
                ClientPnl.Location = new Point(240, 1);

                fillG_noFiletr();
                fillcomb();


            }
            if (Convert.ToString(comboBox1.SelectedItem) == "Invoice Number")
            {

                ProjectPnl.Visible = false;
                ClientPnl.Visible = false;
                DatePnl.Visible = false;
                InvPnl.Visible = true;
                ProjectGRPpnl.Visible = false;
                PrgMngPnl.Visible = false;
                InvPnl.Location = new Point(240, 15);

                fillG_noFiletr();
                fillcomb();


            }

            if (Convert.ToString(comboBox1.SelectedItem) == "Date")
            {

                ProjectPnl.Visible = false;
                ClientPnl.Visible = false;
                InvPnl.Visible = false;
                DatePnl.Visible = true;
                ProjectGRPpnl.Visible = false;
                PrgMngPnl.Visible = false;
                DatePnl.Location = new Point(240, 1);

                fillG_noFiletr();
                fillcomb();


            }



            if (Convert.ToString(comboBox1.SelectedItem) == "Project Group")
            {
                ClientPnl.Visible = false;
                InvPnl.Visible = false;
                DatePnl.Visible = false;
                ProjectPnl.Visible = false;
                ProjectGRPpnl.Visible = true;
                PrgMngPnl.Visible = false;
                ProjectGRPpnl.Location = new Point(240, 1);
                fillG_noFiletr();
                fillcomb();


            }

            if (Convert.ToString(comboBox1.SelectedItem) == "Project Manager")
            {
                ClientPnl.Visible = false;
                InvPnl.Visible = false;
                DatePnl.Visible = false;
                ProjectPnl.Visible = false;
                ProjectGRPpnl.Visible = false;
                PrgMngPnl.Visible = true;
                PrgMngPnl.Location = new Point(240, 1);
                fillG_noFiletr();
                fillcomb();


            }







        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_InvoiceNumber_TextChanged(object sender, EventArgs e)
        {
//           


        }

        private void lstbxInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_InvoiceNumber.Text = lstbxInv.SelectedItem.ToString();
        }

        private void rbtnUnposted_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnUnposted.Checked==true)
            {

                RdbtnPosted.Checked = false;

                btn_PostInv.Visible = true;

                btnunposted.Visible = false;

                btnunposted.Location = new Point(903, 632);
                fillG_noFiletr();

            }

            checkBox1.Checked = false;


        }

        private void RdbtnPosted_CheckedChanged(object sender, EventArgs e)
        {

if(RdbtnPosted.Checked==true)
            {

                rbtnUnposted.Checked = false;
                btn_PostInv.Visible = false;
                btnunposted.Visible = true;

                fillG_noFiletr();


            }

            checkBox1.Checked = false;


        }

        private void btnunposted_Click(object sender, EventArgs e)
        {

            try
            {


                string Flag = "True";


                string InvoiceNumber;

                int count = 0;
                int count_ = 0;
                progressBar1.Value = 0;
                progressBar1.Visible = true;



                foreach (DataGridViewRow row in DGV_PostInvoice.Rows)

                {
                    if (Convert.ToBoolean(row.Cells["PostCheckBox1"].Value) == true)
                    {
                        count = count + 1;
                    }
                }

                progressBar1.Maximum = count;



                SqlCommand cmd;
                foreach (DataGridViewRow row in DGV_PostInvoice.Rows)

                {



                    if (Convert.ToBoolean(row.Cells["PostCheckBox1"].Value) == true)
                    {

                        count_ = count_ + 1;

                        label5.Text = "In Progress...." + count_ + "/" + count;

                        label5.Update();
                        System.Threading.Thread.Sleep(500);

                        progressBar1.Value = count_;

                        Flag = "False";
                        InvoiceNumber = row.Cells["InvoiceNumber"].Value.ToString();
                        cmd = new SqlCommand("update transactiontable set TransactionInvSendBillFlag='Y' where payid is null and TransactionInvNum='" + InvoiceNumber + "'", SqlCon);
                        cmd.CommandTimeout = 500000;
                        cmd.ExecuteNonQuery();

                    }

                }


                if (Flag == "False")

                {

                    label5.Text = "Done...." + count_ + "/" + count;
                    MessageBox.Show("Invoice Unposted Successfully");
                    fillG_noFiletr();
                }

                else
                {
                    MessageBox.Show("No invoice is selected for Unposting");
                    //Fillgrid(string.Empty);
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            progressBar1.Visible = false;
            label5.Text = "";
            checkBox1.Checked = false;


        }

          


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            Boolean x=true;

            foreach (DataGridViewRow row in this.DGV_PostInvoice.Rows)
            {

                if (checkBox1.Checked)
                {

                  row.Cells[0].Value = true;  

                }
                else

                {

                    
                 row.Cells[0].Value = false;


                    //x = false;
                }




            }



            //if (x)
            //{

            //    checkBox1.Text = "Unselect All";
            //}

            //else

            //{
            //    checkBox1.Text = "Select All";

            //}



        }
    }
}
