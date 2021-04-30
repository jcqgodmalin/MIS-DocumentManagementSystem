using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace MISDMS
{
    public partial class Form1 : Form
    {
        //connection properties
        private string s = Properties.Settings.Default.serv;
        private string d = Properties.Settings.Default.db;
        private string u = Properties.Settings.Default.uid;
        private string p = Properties.Settings.Default.Pwd;
        private string ct = Properties.Settings.Default.cattable;
        private string tt = Properties.Settings.Default.typetable;
        private string dt = Properties.Settings.Default.doctable;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void tvMainNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String sel = e.Node.Name;
            if (sel == "exit")
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (sel == "conProp") //Connection Properties
            {
                manDocPanel.Hide();
                WelcomePanel.Hide();
                docPropPanel.Hide();
                addDocPanel.Hide();
                conPropPanel.Show();
                conPropPanel.Parent = scMainWin.Panel2;
                string conStat = "";
                if ((s.Length > 0) && (d.Length > 0) && (dt.Length > 0) && (ct.Length > 0) && (tt.Length > 0))
                {
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        conStat = "Connected";
                    }
                    else
                    {
                        conStat = "Not Connected";
                    }
                }
                else
                {
                    s = "Not Set";
                    d = "Not Set";
                    conStat = "Not Connected";
                }
                
                conPropLabel2.Text = "Server: " + s + "\nDatabase: " + d + "\nConnection Status: " + conStat;
            }
            else if (sel == "welcome") //Main Panel
            {
                manDocPanel.Hide();
                conPropPanel.Hide();
                docPropPanel.Hide();
                addDocPanel.Hide();
                WelcomePanel.Show();
                WelcomePanel.Parent = scMainWin.Panel2;
            }
            else if (sel == "pDoc") //Document Properties
            {
                manDocPanel.Hide();
                addDocPanel.Hide();
                WelcomePanel.Hide();
                conPropPanel.Hide();
                docPropPanel.Show();
                docPropPanel.Parent = scMainWin.Panel2;

                //Load Categories
                if(ct.Length > 0){
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        //query to get the current categories
                        string query = "SELECT cat_desc FROM " + ct;
                        DataTable x = db.getData(query);
                        if (x.Rows.Count > 0)
                        {
                            lstCat.Items.Clear();
                            for (int i = 0; i < x.Rows.Count; i++)
                            {
                                lstCat.Items.Add(x.Rows[i][0]);
                            }
                        }
                        else
                        {
                            //===============================================>
                            //No Category found! Warning
                            //===============================================>
                            MessageBox.Show("No Category found! Please add 1 first.", "No Category Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                }
                else
                {
                    //===============================================>
                    //Category Table not set Warning
                    //===============================================>
                    MessageBox.Show("No Category Table specified.", "No Category Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(sel == "aDoc") //Add Document
            {
                manDocPanel.Hide();
                conPropPanel.Hide();
                docPropPanel.Hide();
                WelcomePanel.Hide();
                addDocPanel.Show();
                addDocPanel.Parent = scMainWin.Panel2;
                rbDateToday.Checked = true;
                cbAddSem.SelectedIndex = 0;
                
                //List all the categories
                if (ct.Length > 0)
                {
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        //query to get the current categories
                        string query = "SELECT cat_desc FROM " + ct;
                        DataTable x = db.getData(query);
                        if (x.Rows.Count > 0)
                        {
                            cbAddCat.Items.Clear();
                            for (int i = 0; i < x.Rows.Count; i++)
                            {
                                cbAddCat.Items.Add(x.Rows[i][0]);
                            }
                            cbAddCat.SelectedIndex = 0;
                        }
                        else
                        {
                            //===============================================>
                            //No Category found! Warning
                            //===============================================>
                            MessageBox.Show("No Category found! Please add 1 first.", "No Category Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            else if (sel == "mDoc") //Modify
            {
                conPropPanel.Hide();
                docPropPanel.Hide();
                WelcomePanel.Hide();
                addDocPanel.Hide();
                manDocPanel.Show();
                manDocPanel.Parent = scMainWin.Panel2;
                if((s.Length > 0) && (d.Length > 0) && (dt.Length > 0) && (ct.Length > 0) && (tt.Length > 0))
                {
                    //display all documents in data grid view
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        string query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id";
                        DataTable x = db.getData(query);
                        dgvDocs.DataSource = x.AsDataView();
                        lblNumOfRows.Text = "Showing " + x.Rows.Count + " documents record.";
                    }
                    cbSearchBy.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Connection properties has not been set yet!", "Could not connect to a server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }
        private void btnCheckCon_Click(object sender, EventArgs e)
        {
            string server = tbServ.Text;
            string uid = tbUID.Text;
            string pwd = tbPass.Text;
            if ((server.Length > 0) && (uid.Length > 0) && (pwd.Length > 0))
            {
                Connection con = new Connection(server, uid, pwd);
                if (con.checkConnection())
                {
                    cbDBList.Items.Clear();
                    gbDatabase.Enabled = true;
                    DataTable x = con.getDatabases();
                    for (int i = 0; i < x.Rows.Count; i++)
                    {
                        cbDBList.Items.Add(x.Rows[i][0].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required!", "Enter required information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cbDBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string server = tbServ.Text;
            string uid = tbUID.Text;
            string pwd = tbPass.Text;
            string db = cbDBList.SelectedItem.ToString();
            Connection con = new Connection(server, uid, pwd, db);
            if (con.checkConnection())
            {
                //Clear the boxes
                cbDoc.Items.Clear();
                cbCats.Items.Clear();
                cbTypes.Items.Clear();

                DataTable x = con.getTables();
                for (int i = 0; i < x.Rows.Count; i++)
                {
                    cbDoc.Items.Add(x.Rows[i][0].ToString());
                    cbCats.Items.Add(x.Rows[i][0].ToString());
                    cbTypes.Items.Add(x.Rows[i][0].ToString());
                }
            }
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string server = tbServ.Text;
            string uid = tbUID.Text;
            string pwd = tbPass.Text;
            if ((server.Length > 0) && (uid.Length > 0) && (pwd.Length > 0))
            {
                string db = cbDBList.SelectedItem.ToString();
                string doctable;
                string cattable;
                string typetable;
            
                if (cbDoc.SelectedItem == null)
                {
                    doctable = "";
                }
                else
                {
                    doctable = cbDoc.SelectedItem.ToString();
                }
                if (cbCats.SelectedItem == null)
                {
                    cattable = "";
                }
                else
                {
                    cattable = cbCats.SelectedItem.ToString();
                }
                if (cbTypes.SelectedItem == null)
                {
                    typetable = "";
                }
                else
                {
                    typetable = cbTypes.SelectedItem.ToString();
                }

                if (MessageBox.Show("Changes will take effect after you run the application again. Exit?", "Setting Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Properties.Settings.Default.serv = server;
                    Properties.Settings.Default.uid = uid;
                    Properties.Settings.Default.Pwd = pwd;
                    Properties.Settings.Default.db = db;
                    if (doctable.Length != 0)
                    {
                        Properties.Settings.Default.doctable = doctable;
                    }
                    if (cattable.Length != 0)
                    {
                        Properties.Settings.Default.cattable = cattable;
                    }
                    if (typetable.Length != 0)
                    {
                        Properties.Settings.Default.typetable = typetable;
                    }
                    //Save
                    Properties.Settings.Default.Save();
                    //Terminate the program execution
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required!","Enter required information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void timrClockStats_Tick(object sender, EventArgs e)
        {
            tslDate.Text = "Date: " + DateTime.Now.ToString();
        }
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            string catName = tbAddCat.Text;
            if(catName.Length > 0){
                Connection con = new Connection(s, u, p, d);
                if (con.checkConnection())
                {
                    DatabaseOps db = new DatabaseOps(con.getConnection());
                    if (db.checkDuplicate(ct, "cat_desc", catName))
                    {
                        //===============================================>
                        //Category name already exists! Exclamation
                        //===============================================>
                        MessageBox.Show("Category name exists!", "Category Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string[] tc = new String[] { "cat_desc" };
                        string[] parm = new String[] { "desc" };
                        object[] vals = new object[] { catName };
                        if (db.insertData(ct, tc, parm, vals))
                        {
                            //===============================================>
                            //Category added Successfully! Information
                            //===============================================>
                            MessageBox.Show("Category added successfully!", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //refresh the list content
                            string query = "SELECT cat_desc FROM " + ct;
                            DataTable x = db.getData(query);
                            if (x.Rows.Count > 0)
                            {
                                lstCat.Items.Clear();
                                for (int i = 0; i < x.Rows.Count; i++)
                                {
                                    lstCat.Items.Add(x.Rows[i][0]);
                                }
                            }
                            tbAddCat.Clear();
                        }
                    }
                }
            }
            else
            {
                //===============================================>
                //Category name not set! Exclamation
                //===============================================>
                MessageBox.Show("Category name cannot be empty!", "No Category Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void tsmCatDelete_Click(object sender, EventArgs e)
        {
            string target = lstCat.SelectedItem.ToString();
            Connection con = new Connection(s, u, p, d);
            if (con.checkConnection())
            {
                DatabaseOps db = new DatabaseOps(con.getConnection());
                if (db.deleteData(ct, "cat_desc", target))
                {
                    //===============================================>
                    //Category Deleted! Information
                    //===============================================>
                    MessageBox.Show("Category has been deleted", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the list content
                    string query = "SELECT cat_desc FROM " + ct;
                    DataTable x = db.getData(query);
                    if (x.Rows.Count > 0)
                    {
                        lstCat.Items.Clear();
                        for (int i = 0; i < x.Rows.Count; i++)
                        {
                            lstCat.Items.Add(x.Rows[i][0]);
                        }
                    }
                }
            }
        }
        private void lstCat_SelectedValueChanged(object sender, EventArgs e)
        {
            string sel = lstCat.SelectedItem.ToString();
            Connection con = new Connection(s,u,p,d);
            if(con.checkConnection()){
                DatabaseOps db = new DatabaseOps(con.getConnection());
                //get cat_id of the selected category.
                string query = "SELECT cat_id FROM Category WHERE cat_desc='" + sel + "'";
                DataTable x = db.getData(query);
                int id = int.Parse(x.Rows[0]["cat_id"].ToString());
                x.Clear();
                //get types...
                query = "SELECT type_desc FROM Type WHERE Type.cat_id = " + id;
                x = db.getData(query);
                //list on list box
                lstType.Items.Clear();
                if (x.Rows.Count > 0)
                {
                    for (int i = 0; i < x.Rows.Count; i++)
                    {
                        lstType.Items.Add(x.Rows[i]["type_desc"]);
                    }
                }
                else
                {
                    //===============================================>
                    //No type found in selected category! Warning
                    //===============================================>
                    MessageBox.Show("No type found in this category. Add One!", "No Type Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                x.Clear();
            }
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (lstCat.SelectedItem != null)
            {
                if(tbAddType.Text.Length > 0){
                    string sel = lstCat.SelectedItem.ToString();
                    string typeName = tbAddType.Text;
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        
                        //get cat_id of the selected category.
                        string query = "SELECT cat_id FROM Category WHERE cat_desc='" + sel + "'";
                        DataTable x = db.getData(query);
                        int id = int.Parse(x.Rows[0]["cat_id"].ToString());
                        x.Clear();
                        if (db.checkDuplicate(tt, "type_desc", typeName,id))
                        {
                            //===============================================>
                            //Type name existed in this category! Exclamation
                            //===============================================>
                            MessageBox.Show("Type name existed in this Category", "Type Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }else{
                            //insert the type
                            string[] tc = new String[] { "cat_id", "type_desc" };
                            string[] parm = new String[] { "catid", "typedesc" };
                            object[] vals = new object[] { id, typeName };
                            if (db.insertData(tt, tc, parm, vals))
                            {
                                //===============================================>
                                //Type added Successfully! Information
                                //===============================================>
                                MessageBox.Show("Type added successfully!", "Type Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //refresh the list content
                                query = "SELECT type_desc FROM " + tt + " WHERE cat_id=" + id;
                                x = db.getData(query);
                                if (x.Rows.Count > 0)
                                {
                                    lstType.Items.Clear();
                                    for (int i = 0; i < x.Rows.Count; i++)
                                    {
                                        lstType.Items.Add(x.Rows[i][0]);
                                    }
                                }
                                tbAddType.Clear();
                                x.Clear();
                            }
                        }
                    }
                }else{
                    //===============================================>
                    //Type name not set! Exclamation
                    //===============================================>
                    MessageBox.Show("Type name cannot be empty!", "No Type Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //===============================================>
                //No Category Selected! Exclamation
                //===============================================>
                MessageBox.Show("Please choose a Category for this type!", "No Category found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void tsmTypeDelete_Click(object sender, EventArgs e)
        {
            string sel = lstCat.SelectedItem.ToString();
            string target = lstType.SelectedItem.ToString();
            Connection con = new Connection(s, u, p, d);
            if (con.checkConnection())
            {
                DatabaseOps db = new DatabaseOps(con.getConnection());
                //get cat_id of the selected category.
                string query = "SELECT cat_id FROM Category WHERE cat_desc='" + sel + "'";
                DataTable x = db.getData(query);
                int id = int.Parse(x.Rows[0]["cat_id"].ToString());
                x.Clear();
                if (db.deleteData(tt, "type_desc", target))
                {
                    //===============================================>
                    //Type Deleted! Information
                    //===============================================>
                    MessageBox.Show("Type has been deleted!", "Delete Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the list content
                    query = "SELECT type_desc FROM " + tt + " WHERE cat_id=" + id;
                    x = db.getData(query);
                    if (x.Rows.Count > 0)
                    {
                        lstType.Items.Clear();
                        for (int i = 0; i < x.Rows.Count; i++)
                        {
                            lstType.Items.Add(x.Rows[i][0]);
                        }
                    }
                    x.Clear();
                }
            }
        }
        private void rbDateToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDateToday.Checked)
            {
                tbDateCustom.Enabled = false;
            }
        }
        private void rbDateCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDateCustom.Checked)
            {
                tbDateCustom.Enabled = true;
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName.ToString();
                lblFileName.Text = ofd.SafeFileName.ToString();
            }
        }
        private void cbAddCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbAddCat.SelectedItem.ToString() != "") || (cbAddCat.SelectedItem != null)){

                string sel = cbAddCat.SelectedItem.ToString(); // <--- The force is strong with this one. :(

                cbAddType.Text = "";
                Connection con = new Connection(s, u, p, d);
                if (con.checkConnection())
                {
                    DatabaseOps db = new DatabaseOps(con.getConnection());
                    //get cat_id of the selected category.
                    string query = "SELECT cat_id FROM Category WHERE cat_desc='" + sel + "'";
                    DataTable x = db.getData(query);
                    int id = int.Parse(x.Rows[0]["cat_id"].ToString());
                    x.Clear();
                    //get types...
                    query = "SELECT type_desc FROM Type WHERE Type.cat_id = " + id;
                    x = db.getData(query);
                    //list on combo box
                    cbAddType.Items.Clear();
                    if (x.Rows.Count > 0)
                    {
                        for (int i = 0; i < x.Rows.Count; i++)
                        {
                            cbAddType.Items.Add(x.Rows[i]["type_desc"]);
                        }
                        cbAddType.SelectedIndex = 0;
                    }
                    else
                    {
                        //===============================================>
                        //No type found in selected category! Warning
                        //===============================================>
                        MessageBox.Show("No type found in this category. Add One!", "No Type Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    x.Clear();
                }
            }
            
            
        }
        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            bool dateSet = false;
            string date = "";
            if (rbDateToday.Checked)
            {
                date = DateTime.Now.ToShortDateString();
                dateSet = true;
            }
            else
            {
                DateTime temp;
                if(DateTime.TryParse(tbDateCustom.Text,out temp)){
                    date = temp.ToShortDateString();                 
                    dateSet = true;
                }
                else
                {
                    //===============================================>
                    //Invalid Date! Exclamation
                    //===============================================>
                    MessageBox.Show("The date you entered is not valid","Invalid Date",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            if (dateSet)
            {
                if (tbFilePath.Text.Length > 0)
                {
                    if (tbDocName.Text.Length > 0)
                    {
                        if (cbAddSem.SelectedItem != null)
                        {
                            if (cbAddCat.SelectedItem != null)
                            {
                                if (cbAddType.SelectedItem != null)
                                {
                                    string docsDir = Application.StartupPath + "/Docs";
                                    if(!(Directory.Exists(docsDir))){
                                        Directory.CreateDirectory(docsDir);
                                    }
                                    //get doc name
                                    string docName = tbDocName.Text;
                                    //get source path
                                    string sourcePath = tbFilePath.Text;
                                    //get target file path
                                    string filePath = docsDir + "/" + lblFileName.Text;
                                    //get sem value
                                    int sem_id = int.Parse(cbAddSem.SelectedIndex.ToString());
                                    //get cat and type id
                                    string selCat = cbAddCat.SelectedItem.ToString();
                                    string selType = cbAddType.SelectedItem.ToString();
                                    Connection con = new Connection(s, u, p, d);
                                    if (con.checkConnection())
                                    {
                                        DatabaseOps db = new DatabaseOps(con.getConnection());
                                        //get cat_id of the selected category.
                                        string query = "SELECT cat_id FROM Category WHERE cat_desc='" + selCat + "'";
                                        DataTable x = db.getData(query);
                                        int cat_id = int.Parse(x.Rows[0]["cat_id"].ToString());
                                        x.Clear();
                                        //get type_id of the selected type.
                                        query = "SELECT type_id FROM Type WHERE type_desc='" + selType + "'";
                                        x = db.getData(query);
                                        int type_id = int.Parse(x.Rows[0]["type_id"].ToString());
                                        x.Clear();
                                        //check for duplicate
                                        if (!(db.checkDuplicate(dt, "doc_name", docName)))
                                        {
                                            File.Copy(sourcePath, filePath, true);
                                            if (File.Exists(filePath))
                                            {
                                                //Insert the data.
                                                string[] tc = { "doc_name", "sem_id", "cat_id", "type_id", "doc_path", "doc_date" };
                                                string[] pr = { "docName", "semid", "catid", "typeid", "docpath", "docdate" };
                                                object[] items = { docName, sem_id, cat_id, type_id, filePath, date };
                                                if (db.insertData(dt, tc, pr, items))
                                                {
                                                    //===============================================>
                                                    //Document added! Information
                                                    //===============================================>
                                                    MessageBox.Show("Document Added Successfully!","Record Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                }
                                                //Refresh
                                                rbDateToday.Checked = true;
                                                tbFilePath.Text = "";
                                                lblFileName.Text = "File Name";
                                                tbDocName.Text = "";
                                                cbAddSem.SelectedIndex = 0;
                                                cbAddCat.SelectedIndex = 0;
                                                cbAddType.SelectedIndex = 0;
                                            }
                                        }
                                        else
                                        {
                                            //===============================================>
                                            //Document name exists! Exclamation
                                            //===============================================>
                                            MessageBox.Show("The name you entered already exists!","Please choose another document's name",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                        }
                                    }
                                }
                                else
                                {
                                    //===============================================>
                                    //Document Type not set! Exclamation
                                    //===============================================>
                                    MessageBox.Show("Please select document type!","No Type Selected",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                    else
                    {
                        //===============================================>
                        //Document Name not set! Exclamation
                        //===============================================>
                        MessageBox.Show("Please enter the document's name!","Document Name not set",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    //===============================================>
                    //No file uploaded! Exclamation
                    //===============================================>
                    MessageBox.Show("Please upload your document!","File not uploaded",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }
        private void dgvDocs_SelectionChanged(object sender, EventArgs e)
        {
                foreach (DataGridViewRow row in dgvDocs.SelectedRows)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    if (id != null)
                    {
                        btnDIDel.Enabled = true;
                        btnDIEdit.Enabled = true;
                        btnDIPrint.Enabled = true;
                    }
                    string name = row.Cells[1].Value.ToString();
                    string category = row.Cells[2].Value.ToString();
                    string type = row.Cells[3].Value.ToString();
                    int sem = int.Parse(row.Cells[4].Value.ToString());
                    string date = row.Cells[5].Value.ToString();
                    string path = row.Cells[6].Value.ToString();
                    //display data information
                    tbDIName.Text = name;
                    tbDIDate.Text = date;
                    tbDIPath.Text = path;
                    cbDISem.SelectedIndex = sem;
                    //load category to cbDICat combo box.

                    //empty cbDICat first.
                    cbDICat.Items.Clear();
                    Connection con = new Connection(s, u, p, d);
                    string query = "";
                    DataTable x;
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        query = "SELECT cat_desc FROM Category";
                        x = db.getData(query);
                        if (x.Rows.Count > 1)
                        {
                            for (int i = 0; i < x.Rows.Count; i++)
                            {
                                cbDICat.Items.Add(x.Rows[i]["cat_desc"]);
                            }
                        }
                    }
                    cbDICat.SelectedItem = category;
                    cbDIType.SelectedItem = type;
                }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBy = cbSearchBy.SelectedItem.ToString();
            if(tbSearchTerm.Text.Length > 0)
            {
                
                if ((searchBy == "Month") || (searchBy == "Year") || (searchBy == "Semester") || (searchBy == "Category") || (searchBy == "Type"))
                {
                    //Date
                    string query = "";
                    //If month
                    if (searchBy == "Month")
                    {
                        searchBy = "doc_date";
                        query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND " + searchBy + " LIKE '" + tbSearchTerm.Text + "/%'";
                    }
                    //If year
                    if (searchBy == "Year")
                    {
                        searchBy = "doc_date";
                        query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND " + searchBy + " LIKE '%/" + tbSearchTerm.Text + "'";
                    }
                    //If Semester
                    if (searchBy == "Semester")
                    {
                        searchBy = "sem_id";
                        int targetSem = 0;
                        try{
                            targetSem = int.Parse(tbSearchTerm.Text);
                            query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND " + searchBy + "=" + targetSem + "";
                        }catch{
                            //===============================================>
                            //Invalid Semester! Exclamation
                            //===============================================>
                            MessageBox.Show("The semester you want to search is invalid!","Invalid Search Term",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                    //If Category
                    if (searchBy == "Category")
                    {
                        searchBy = "cat_id";
                        //get cat_id of the selected category.
                        int id = 0;
                        Connection c = new Connection(s, u, p, d);
                        if (c.checkConnection())
                        {
                            DatabaseOps dbs = new DatabaseOps(c.getConnection());
                            string q = "SELECT cat_id FROM Category WHERE cat_desc='" + tbSearchTerm.Text + "'";
                            DataTable f = dbs.getData(q);
                            if (f.Rows.Count > 0)
                            {
                                id = int.Parse(f.Rows[0]["cat_id"].ToString());
                                f.Clear();
                            }
                        }
                        query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND Documents." + searchBy + "=" + id;
                    }
                    //If Type
                    if (searchBy == "Type")
                    {
                        searchBy = "type_id";
                        //get cat_id of the selected category.
                        int id = 0;
                        Connection c = new Connection(s, u, p, d);
                        if (c.checkConnection())
                        {
                            DatabaseOps dbs = new DatabaseOps(c.getConnection());
                            string q = "SELECT type_id FROM Type WHERE type_desc='" + tbSearchTerm.Text + "'";
                            DataTable f = dbs.getData(q);
                            if (f.Rows.Count > 0)
                            {
                                id = int.Parse(f.Rows[0]["type_id"].ToString());
                                f.Clear();
                            }
                        }
                        query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND Documents." + searchBy + "=" + id;
                    }
                    //display documents in data grid view
                    if(query.Length > 1){
                        Connection con = new Connection(s, u, p, d);
                        if (con.checkConnection())
                        {
                            DatabaseOps db = new DatabaseOps(con.getConnection());
                            DataTable x = db.getData(query);
                            dgvDocs.DataSource = x.AsDataView();
                            lblNumOfRows.Text = "Search results for '" + tbSearchTerm.Text + "' : " + x.Rows.Count + " Result(s)";
                            if (x.Rows.Count < 1)
                            {
                                btnDIDel.Enabled = false;
                                btnDIEdit.Enabled = false;
                                btnDIPrint.Enabled = false;
                                lblNumOfRows.Text = "No results for '" + tbSearchTerm.Text + "'";
                            }
                        }
                        
                    }
                }
                else
                {
                    //Not date
                    //Convert to proper column name
                    searchBy = "doc_name";
                    //display documents in data grid view
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        string query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id AND " + searchBy + "='" + tbSearchTerm.Text + "'";
                        DataTable x = db.getData(query);
                        dgvDocs.DataSource = x.AsDataView();
                        lblNumOfRows.Text = "Search results for '" + tbSearchTerm.Text + "' : " + x.Rows.Count + " Result(s)";
                        if (x.Rows.Count < 1)
                        {
                            btnDIDel.Enabled = false;
                            btnDIEdit.Enabled = false;
                            btnDIPrint.Enabled = false;
                            lblNumOfRows.Text = "No results for '" + tbSearchTerm.Text + "'";
                        }
                        
                    }
                }
                lblClearSearch.Visible = true;

            }
            else
            {
                //==========================================>
                //Search Term textbox is empty! Exclamation
                //==========================================>
                MessageBox.Show("There's nothing to search!","Nothing to search",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void cbDICat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load types.
            Connection con = new Connection(s, u, p, d);
            if (con.checkConnection())
            {
                //get category id
                DatabaseOps db = new DatabaseOps(con.getConnection());
                string query = "SELECT cat_id FROM Category WHERE cat_desc='" + cbDICat.SelectedItem.ToString() + "'";
                DataTable x = db.getData(query);
                int cat_id = int.Parse(x.Rows[0]["cat_id"].ToString());
                x.Clear();
                //clear cbDIType first
                cbDIType.Items.Clear();
                //get types
                query = "SELECT type_desc FROM Type WHERE cat_id=" + cat_id;
                x = db.getData(query);
                if (x.Rows.Count > 0)
                {
                    for (int i = 0; i < x.Rows.Count; i++)
                    {
                        cbDIType.Items.Add(x.Rows[i]["type_desc"].ToString());
                    }
                    cbDIType.SelectedIndex = 0;
                }
                else
                {
                    //===============================================>
                    //No type found in selected category! Warning
                    //===============================================>
                    MessageBox.Show("No type found in this category. Add One!","No Type Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDIDel_Click(object sender, EventArgs e)
        {
            Connection con = new Connection(s, u, p, d);
            if (con.checkConnection())
            {
                DatabaseOps db = new DatabaseOps(con.getConnection());
                //===============================================>
                //Confirm Delete! Question
                //===============================================>
                if (MessageBox.Show("Are you sure you want to delete " + tbDIName.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (db.deleteData("Documents", "doc_name", tbDIName.Text))
                    {
                        //delete file
                        File.Delete(tbDIPath.Text);
                        //===============================================>
                        //Record Deleted! Information
                        //===============================================>
                        MessageBox.Show("Document has been remove!","Remove Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //refresh dgv
                        string query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id";
                        DataTable x = db.getData(query);
                        dgvDocs.DataSource = x.AsDataView();
                        lblNumOfRows.Text = "Showing " + x.Rows.Count + " documents record.";
                        if (dgvDocs.RowCount < 1)
                        {
                            tbDIDate.Clear();
                            tbDIName.Clear();
                            tbDIPath.Clear();
                            cbDICat.SelectedIndex = 0;
                            cbDISem.SelectedIndex = 0;
                            cbDIType.SelectedIndex = 0;
                        }
                    }
                }
               
            }
        }
        private void btnDIEdit_Click(object sender, EventArgs e)
        {
            
            if (btnDIEdit.Text == "Edit")
            {
                btnDIEdit.Text = "Save";
                tbDIPath.ReadOnly = false;
                tbDIName.ReadOnly = false;
                tbDIDate.ReadOnly = false;
                checkToday.Enabled = true;
                cbDICat.Enabled = true;
                cbDIType.Enabled = true;
                cbDISem.Enabled = true;
                btnDIBrowse.Enabled = true;
            }
            else
            {
                //check if something changes...
                string oldName = dgvDocs.SelectedRows[0].Cells[1].Value.ToString();
                string cat_id_desc = dgvDocs.SelectedRows[0].Cells[2].Value.ToString();
                string type_id_desc = dgvDocs.SelectedRows[0].Cells[3].Value.ToString();
                int sem_id_desc = int.Parse(dgvDocs.SelectedRows[0].Cells[4].Value.ToString());
                string old_date = dgvDocs.SelectedRows[0].Cells[5].Value.ToString();
                string old_path = dgvDocs.SelectedRows[0].Cells[6].Value.ToString();
                //New
                string name = tbDIName.Text;
                string date = tbDIDate.Text;
                string path = tbDIPath.Text;
                int sem_id = cbDISem.SelectedIndex;
                string new_cat_id_desc = cbDICat.SelectedItem.ToString();
                string new_type_id_desc = cbDIType.SelectedItem.ToString();
                //check...
                if(!((oldName.Equals(name)) && (cat_id_desc.Equals(new_cat_id_desc)) && (type_id_desc.Equals(new_type_id_desc)) && (sem_id_desc.Equals(sem_id)) && (old_date.Equals(date)) && (old_path.Equals(path))))
                {
                    Connection con = new Connection(s, u, p, d);
                    if (con.checkConnection())
                    {
                        DatabaseOps db = new DatabaseOps(con.getConnection());
                        if (!(db.checkDuplicate(dt, "doc_name", name)))
                        {
                            //get cat_id...
                            string query = "SELECT cat_id FROM Category WHERE cat_desc='" + cbDICat.SelectedItem.ToString() + "'";
                            DataTable x = db.getData(query);
                            int cat_id = int.Parse(x.Rows[0]["cat_id"].ToString());
                            x.Clear();
                            //get type_id...
                            query = "SELECT type_id FROM Type WHERE type_desc='" + cbDIType.SelectedItem.ToString() + "'";
                            x = db.getData(query);
                            int type_id = int.Parse(x.Rows[0]["type_id"].ToString());
                            x.Clear();
                            //---------------------------COPY the new path.
                            string docsDir = Application.StartupPath + "/Docs";
                            //get target file path
                            string targetfilePath = docsDir + "/" + lblDISafeFileName.Text;
                            if (!(File.Exists(targetfilePath)))
                            {
                                File.Copy(tbDIPath.Text, targetfilePath, true);
                            }
                            //check if copy is successful...
                            if (File.Exists(targetfilePath))
                            {
                                //---------------------------UPDATE / Modify
                                string[] targetCols = { "doc_name", "sem_id", "cat_id", "type_id", "doc_path", "doc_date" };
                                string[] paramet = { "docName", "semid", "catid", "typeid", "path", "date" };
                                object[] vals = { name, sem_id, cat_id, type_id, targetfilePath, date };
                                if (db.updateData(dt, targetCols, paramet, vals, "doc_name", oldName))
                                {
                                    //===============================================>
                                    //Update Saved! Information
                                    //===============================================>
                                    MessageBox.Show("Update has been successfully saved!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    checkToday.Enabled = false;
                                    cbDICat.Enabled = false;
                                    cbDIType.Enabled = false;
                                    cbDISem.Enabled = false;
                                    btnDIBrowse.Enabled = false;
                                    tbDIPath.ReadOnly = true;
                                    tbDIName.ReadOnly = true;
                                    tbDIDate.ReadOnly = true;
                                    btnDIEdit.Text = "Edit";
                                    //refresh
                                    query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id";
                                    x = db.getData(query);
                                    dgvDocs.DataSource = x.AsDataView();
                                    lblNumOfRows.Text = "Showing " + x.Rows.Count + " documents record.";
                                }
                            }
                        }
                        else
                        {
                            //===============================================>
                            //Document name exists! Exclamation
                            //===============================================>
                            MessageBox.Show("The name you entered already exists!","Document Name Already Exists",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    //===========================================>
                    // Exclamation
                    //===========================================>
                    MessageBox.Show("There is nothing to change!", "Nothing's changed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //go back
                    checkToday.Enabled = false;
                    cbDICat.Enabled = false;
                    btnDIBrowse.Enabled = false;
                    cbDIType.Enabled = false;
                    cbDISem.Enabled = false;
                    tbDIPath.ReadOnly = true;
                    tbDIName.ReadOnly = true;
                    tbDIDate.ReadOnly = true;
                    btnDIEdit.Text = "Edit";
                }
                
            }
        }
        private void checkToday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkToday.Checked)
            {                
                tbDIDate.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                tbDIDate.Text = dgvDocs.SelectedRows[0].Cells[5].Value.ToString();
            }
        }


        private void lblClearSearch_Click(object sender, EventArgs e)
        {
            //refresh
            Connection con = new Connection(s, u, p, d);
            if (con.checkConnection())
            {
                DatabaseOps db = new DatabaseOps(con.getConnection());
                string query = "SELECT Documents.doc_id AS ID, Documents.doc_name AS Name, exTable.cat_desc AS Category, exTable.type_desc AS Type, Documents.sem_id AS Semester, Documents.doc_date AS Date, Documents.doc_path AS Path FROM Documents INNER JOIN (SELECT Type.type_id, Category.cat_id,Category.cat_desc,type_desc FROM Category INNER JOIN Type ON Category.cat_id = Type.cat_id) AS exTable ON Documents.cat_id = exTable.cat_id AND Documents.type_id = exTable.type_id";
                DataTable x = db.getData(query);
                dgvDocs.DataSource = x.AsDataView();
                lblNumOfRows.Text = "Showing " + x.Rows.Count + " documents record.";
               
            }
            lblClearSearch.Visible = false;
            
        }

        private void btnDIPrint_Click(object sender, EventArgs e)
        {
            string filepath = tbDIPath.Text;
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @filepath;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(10000);
            if (false == p.CloseMainWindow())
            {
                p.Kill();
            }
        }

        private void btnDIBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbDIPath.Text = ofd.FileName;
                lblDISafeFileName.Text = ofd.SafeFileName;
            }
        }
    }
}
