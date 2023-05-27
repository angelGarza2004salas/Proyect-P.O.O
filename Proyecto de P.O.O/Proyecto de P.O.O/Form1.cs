using System.Runtime.InteropServices;

namespace Proyecto_de_P.O.O
{
    public partial class FrmLog_in : Form
    {
        public FrmLog_in()
        {
            InitializeComponent();
            TtpMessage.SetToolTip(ptbxMinimize, "Minimize");
            TtpMessage.SetToolTip(ptbxClose, "Close");
        }
        DatosUsername validar = new DatosUsername();
        Create_Account Abrir = new Create_Account();
        //-----------------------PLANTILLA PARA MOVER LA VENTANA--------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //--------------------------------------------------------------------
        //-----------------------ELIMINA EL TEXTO DE LOS TEXTBOX--------------

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if(txbxUsername.Text == "Username")
            {
                txbxUsername.Text = string.Empty;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (txbxPassword.Text == "Password")
            {
                txbxPassword.Text=string.Empty;
                txbxPassword.UseSystemPasswordChar = true;
            }
        }
        //---------------------REACTIVA EL TEXTO DE LOS TEXTBOX----------------
        private void txbxUsername_Leave(object sender, EventArgs e)
        {
            if(txbxUsername.Text == string.Empty)
            {
                txbxUsername.Text = "Username";
            }
        }

        private void txbxPassword_Leave(object sender, EventArgs e)
        {
            if (txbxPassword.Text == string.Empty)
            {
                txbxPassword.Text = "Password";
                txbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void txbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ptbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abrir.ShowDialog();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                ErrorIcon.Clear();
                validar.NombreUsuario = txbxUsername.Text;
                MessageBox.Show("Your data is correct");
                FrmStudent_Registration AbrirVentana = new FrmStudent_Registration();
                AbrirVentana.ShowDialog();
                this.Hide();
            }
        }

        private bool ValidarDatos()
        {
            if(txbxUsername.Text=="Username"||txbxUsername.Text==String.Empty)
            {
                ErrorIcon.Clear();
                ErrorIcon.SetError(txbxUsername, "You must enter your username");
                return false;
            }
            if(txbxPassword.Text=="Password"||txbxPassword.Text==String.Empty)
            {
                ErrorIcon.Clear();
                ErrorIcon.SetError(txbxPassword, "Password error");
                return false;
            }
            return true;
        }
    }
}