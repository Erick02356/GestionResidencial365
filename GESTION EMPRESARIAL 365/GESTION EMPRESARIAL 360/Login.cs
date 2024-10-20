using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GESTION_EMPRESARIAL_360;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(TXTUsuario.Text == "USUARIO")
            {
                TXTUsuario.Text = "";
                TXTUsuario.ForeColor = Color.LightGray;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (TXTUsuario.Text == "")
            {
                TXTUsuario.Text = "USUARIO";
                TXTUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (TXTContraseña.Text == "CONTRASEÑA")
            {
                TXTContraseña.Text = "";
                TXTContraseña.ForeColor = Color.LightGray;
                TXTContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (TXTContraseña.Text == "")
            {
                TXTContraseña.Text = "CONTRASEÑA";
                TXTContraseña.ForeColor = Color.DimGray;
                TXTContraseña.UseSystemPasswordChar = false;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de login
            this.Hide(); // Oculta el formulario de login

            // Crear y mostrar el nuevo formulario
            Form1 form1 = new Form1();
            form1.Show(); // Muestra el formulario Form1 
        }
    }
}
