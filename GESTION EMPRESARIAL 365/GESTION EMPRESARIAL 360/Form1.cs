using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_DE_ENTIDADES;
using CAPA_DE_NEGOCIO;

namespace GESTION_EMPRESARIAL_360
{
    public partial class Form1 : Form
    {
        private readonly CN_Usuarios _cn_Usuarios;
        public Form1()
        {
            InitializeComponent();
            _cn_Usuarios = new CN_Usuarios();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mostrar_Usuarios(_cn_Usuarios);
        }

        public CN_Usuarios Get_cn_Usuarios()
        {
            return _cn_Usuarios;
        }

        #region

        public void Mostrar_Usuarios(CN_Usuarios _cn_Usuarios)
        {
            // Limpia el ListView antes de cargar los usuarios
            lvUsuarios.Items.Clear();

            // Obtén la lista de usuarios desde la capa de negocio
            List<CE_Usuario> usuarios = _cn_Usuarios.Mostrar_Usuarios();

            // Agrega cada usuario al ListView
            foreach (var user in usuarios)
            {
                ListViewItem item = new ListViewItem(user.Id_Usuario.ToString());
                item.SubItems.Add(user.Usuario);
                item.SubItems.Add(user.Contrasena);
                item.SubItems.Add(user.Estado ? "Activo" : "Inactivo");
                item.SubItems.Add(user.Id_tipo_documento.ToString());
                lvUsuarios.Items.Add(item);
            }
        }
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
