using Proyecto_de_P.O.O.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_P.O.O
{
    public partial class FrmStudent_Registration : Form
    {
        public FrmStudent_Registration()
        {
            InitializeComponent();
            ToolTip message = new ToolTip();
            message.SetToolTip(PtbxClose, "Close");
            message.SetToolTip(PtbxMinimize, "Minimze");
            BtnEdit.Enabled = false;
            BtnEliminate.Enabled = false;
        }
        //-------------------Instancias globales-------------------
        int indice;
        ErrorProvider errorIcon = new ErrorProvider();
        readonly List<AppClass.StudentData> ListMain = new List<AppClass.StudentData>();
        readonly List<AppClass.StateStudents> ListState = new List<AppClass.StateStudents>();
        readonly List<AppClass.RecordNotes> ListRecord = new List<AppClass.RecordNotes>();
        //---------------------------------------------------------------
         AppClass.StudentData KeyData = new AppClass.StudentData();
    //--------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PtbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PtbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatosEntrada())
                {
                    errorIcon.Clear();
                    AppClass.StateStudents state = new AppClass.StateStudents();
                    AppClass.RecordNotes Records = new AppClass.RecordNotes();
                    AppClass.StudentData StudenDa = new AppClass.StudentData
                    
                    {
                        //------------------Student´s data-----------------------
                        Name = TxbxNames.Text,
                        Surnames = TxbxSurnames.Text,
                        Age = int.Parse(TxbxAge.Text),
                        //------------------Student´s units-----------------------
                        Unit1 = double.Parse(TxbxUnit1.Text),
                        Unit2 = double.Parse(TxbxUnit2.Text),
                        Unit3 = double.Parse(TxbxUnit3.Text),
                        Unit4 = double.Parse(TxbxUnit4.Text),
                    };
                    StudenDa.CalculateProme(TxbxPorcentajeUnit1.Text, TxbxPorcentajeUnit2.Text, TxbxPorcentajeUnit3.Text, TxbxPorcentajeUnit4.Text);
                    KeyData = StudenDa;
                    //--------------------add the data to the second dataGridView-------------------------
                    state.Names = TxbxNames.Text;
                    state.Surnames = TxbxSurnames.Text;
                    state.Prome = Math.Round(StudenDa.Prome, 2);
                    if (state.Prome > double.Parse(TxbxAprobation.Text)) { state.State = "Approved"; }
                    else
                    if (state.Prome < double.Parse(TxbxAprobation.Text)) { state.State = "Reproved"; }
                    //--------------------------addd data to the third DataGridView-------------------
                    Records.Names = StudenDa.Name;      Records.Surnames = StudenDa.Surnames;
                    Records.Prome = StudenDa.Prome;     ListRecord.Add(Records);

                    //---------------------------------Student´s sex-------------------------------
                    if (RbtnFemale.Checked == true) 
                    { StudenDa.Sex = "Female"; ListMain.Add(StudenDa); MantainMasterData(); ListState.Add(state); 
                    UpdateStatusData(); DeleteData(); }

                    else if (RbtnMale.Checked == true)
                    { StudenDa.Sex = "Male"; ListMain.Add(StudenDa); MantainMasterData(); ListState.Add(state);
                    UpdateStatusData(); DeleteData(); }

                    else { MessageBox.Show("Please enter your sex"); }
                    //---------------------------To disable the percentage or aprobation Textboxes---------------------
                    TxbxPorcentajeUnit1.Enabled = false;TxbxPorcentajeUnit2.Enabled = false;TxbxPorcentajeUnit3.Enabled = false;TxbxPorcentajeUnit4.Enabled = false;
                    TxbxAprobation.Enabled = false;
                    //---------------------Calling the EiminarDat method--------------------------
                    
                }
            }
            catch(Exception ex){ MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        //------------------Update dataGridPrincipal with aggregated data------------------
        private void MantainMasterData()
        {
            DgvRegistersEstudent.DataSource = null;
            DgvRegistersEstudent.DataSource = ListMain;
        }
        //------------------Update main DataGrid with aggregated data------------------------------
        private void UpdateStatusData()
        {
            DgvRegisterState.DataSource = null;
            DgvRegisterState.DataSource= ListState;
        }
        //------------------Method To Validate Input Data------------------------------------------
        private bool ValidarDatosEntrada()
        {
            //--------------------------Student data is validated----------------------------------
            if (TxbxNames.Text==String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxNames, "Please enter a valid name"); TxbxNames.Focus();
                return false; }
            if(TxbxSurnames.Text==String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxSurnames, "Please enter a valid surnames"); TxbxSurnames.Focus();
                return false; }
            if(TxbxAge.Text==String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxAge, "Please enter a valid age"); TxbxAge.Focus();
                return false; }
            //--------------------------Student units are validated------------------------------
            if (TxbxUnit1.Text==String.Empty) { errorIcon.Clear();errorIcon.SetError(TxbxUnit1, "Plese enter a valid unit1"); TxbxUnit1.Focus();
                return false; }
            if(TxbxUnit2.Text==String.Empty) { errorIcon.Clear();errorIcon.SetError(TxbxUnit2, "Please enter a valid unit2"); TxbxUnit2.Focus();
                return false; }
            if(TxbxUnit3.Text==String.Empty) { errorIcon.Clear();errorIcon.SetError(TxbxUnit3, "Please enter a valid unit3"); TxbxUnit3.Focus();
                return false; }
            if(TxbxUnit4.Text==String.Empty) { errorIcon.Clear();errorIcon.SetError(TxbxUnit4, "Please enter a valid unit4"); TxbxUnit4.Focus();
                return false; }
            //--------------------------percentages are validated-----------------------------------
            if (TxbxPorcentajeUnit1.Text == String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxPorcentajeUnit1, "Please enter a percentage valid"); 
            return false; }
            if (TxbxPorcentajeUnit2.Text == String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxPorcentajeUnit2, "Please enter a percentage valid"); 
            return false; }
            if (TxbxPorcentajeUnit3.Text == String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxPorcentajeUnit3, "Please enter a percentage valid"); 
            return false; }
            if (TxbxPorcentajeUnit4.Text == String.Empty) { errorIcon.Clear(); errorIcon.SetError(TxbxPorcentajeUnit4, "Please enter a percentage valid"); 
            return false; }
            if (TxbxAprobation.Text == String.Empty) { MessageBox.Show("Please enter an approval value","approval value",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return false; }
            if (double.Parse(TxbxAprobation.Text) > 10 || double.Parse(TxbxAprobation.Text)< 1) { MessageBox.Show("The approval value must be between 1 and 10"); 
            return false; }
            return true;
        }

        private void TxbxPorcentajeUnit4_TextChanged(object sender, EventArgs e)
        {

        }
        //--------------------Method for deleting data once it has been entered---------------
        private void DeleteData()
        {
            TxbxNames.Text = String.Empty;  TxbxSurnames.Text = String.Empty;
            TxbxAge.Text = String.Empty;    TxbxUnit1.Text = String.Empty; TxbxUnit2.Text = String.Empty;
            TxbxUnit3.Text = String.Empty;  TxbxUnit4.Text = String.Empty;
            RbtnFemale.Checked = false;
            RbtnMale.Checked = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<AppClass.RecordNotes> Newlist = new List<AppClass.RecordNotes>();
            foreach(AppClass.RecordNotes s in ListRecord)
            {
                if (s.Prome>= double .Parse(TxbxSerach.Text)) { Newlist.Add(s); break; }
            }
            DgvRegisterRecords.DataSource = null;
            DgvRegisterRecords.DataSource = Newlist;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnAdd.Enabled = false;
            BtnEliminate.Enabled = true;
            AppClass.StudentData ad = new AppClass.StudentData(); //<----------------Instance for the first DataGridView
            AppClass.StateStudents add = new AppClass.StateStudents();//<------------Instance for second DataGridView
            AppClass.RecordNotes addd = new AppClass.RecordNotes();//<------------------instance for the third DataGridView
            //-------------------add to the first DataGridView-------------------------------
            ad.Name = TxbxNames.Text;
            ad.Surnames = TxbxSurnames.Text;
            ad.Age = int.Parse(TxbxAge.Text);
            ad.Unit1 = double.Parse(TxbxUnit1.Text);
            ad.Unit2 = double.Parse(TxbxUnit2.Text);
            ad.Unit3 = double.Parse(TxbxUnit3.Text);
            ad.Unit4 = double.Parse(TxbxUnit4.Text);
            //-------------------add to the second DataGridView-------------------------------
            add.Names = TxbxNames.Text;
            add.Surnames = TxbxSurnames.Text;
            //-------------------add to the third DataGridView--------------------------------
            addd.Names = TxbxNames.Text;
            addd.Surnames = TxbxSurnames.Text;
            //--------------------Calculate average---------------------------------
            ad.CalculateProme(TxbxPorcentajeUnit1.Text, TxbxPorcentajeUnit2.Text, TxbxPorcentajeUnit3.Text, TxbxPorcentajeUnit4.Text);
            add.Prome = Math.Round(ad.Prome,2);
            addd.Prome = Math.Round(ad.Prome,2);
            //---------------------Calculate status----------------------------------------
            if (add.Prome >= double.Parse(TxbxAprobation.Text)) { add.State = "Approved"; }
            else 
            if(add.Prome < double.Parse(TxbxAprobation.Text)) { add.State = "Reproved";
                //---------------------Check that the RadioButton is selected----------------
                if (RbtnFemale.Checked == true)
                {
                    ad.Sex = "Female"; ListMain[indice] = ad;
                    ListState[indice] = add; ListRecord[indice] = addd;
                    indice = -1; MantainMasterData(); UpdateStatusData(); DeleteData();
                    BtnEdit.Enabled = false;
                }
                else
                    if (RbtnMale.Checked == true)
                {
                    ad.Sex = "Male"; ListMain[indice] = ad;
                    ListState[indice] = add; ListRecord[indice] = addd;
                    indice = -1; MantainMasterData(); UpdateStatusData(); DeleteData();
                    BtnEdit.Enabled = false;
                }
                else MessageBox.Show("You must select the sex", "Select sex", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DgvRegistersEstudent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow P = DgvRegistersEstudent.SelectedRows[0];
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = true;
                BtnEliminate.Enabled = true;
                int s = DgvRegistersEstudent.Rows.IndexOf(P);
                indice = s;
                AppClass.StudentData Edit = ListMain[s];
                TxbxNames.Text = Edit.Name;
                TxbxSurnames.Text = Edit.Surnames;
                TxbxAge.Text = Edit.Age.ToString();
                TxbxUnit1.Text = Edit.Unit1.ToString();
                TxbxUnit2.Text = Edit.Unit2.ToString();
                TxbxUnit3.Text = Edit.Unit3.ToString();
                TxbxUnit4.Text = Edit.Unit4.ToString();
                RbtnFemale.Checked = false;
                RbtnMale.Checked = false;
            }
            catch { MessageBox.Show("impossible to edit"); }     

        }

        private void BtnEliminate_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(option== DialogResult.Yes)
            {
                ListMain.RemoveAt(indice);
                ListState.RemoveAt(indice);
                ListRecord.RemoveAt(indice);
                indice = -1;
                MantainMasterData();
                UpdateStatusData();
                DeleteData();
                BtnEdit.Enabled = false;
                BtnEliminate.Enabled = false;
                BtnAdd.Enabled = false;
            }
        }
    }
}
