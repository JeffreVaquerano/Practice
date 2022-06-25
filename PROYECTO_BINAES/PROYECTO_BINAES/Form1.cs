using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PROYECTO_BINAES
{
    public partial class frmMenu : Form
    {
        bool sidebarExpand;
        bool homeCollapsed;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void siderbarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                flpSidebar.Width -= 10;
                if(flpSidebar.Width == flpSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    siderbarTimer.Stop();
                }
            }
            else
            {

                flpSidebar.Width += 10;
                if (flpSidebar.Width == flpSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    siderbarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            siderbarTimer.Start();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //flpSidebar.BackColor = Color.FromArgb(45, 46, 129);
            tabContenedor.ItemSize = new Size(0, 1);
            tabContenedor.SizeMode = TabSizeMode.Fixed;

            //txtTituloEvento.TextAlign = HorizontalAlignment.Center;


        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if(homeCollapsed)
            {
                HomeContainer.Height += 10;
                if(HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void picMinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void ExitButton()
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 0;
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 1;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 2;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 3;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ExitButton();
        }

        private void txtTituloEvento_Enter_1(object sender, EventArgs e)
        {
            if (txtTituloEvento.Text == "Titulo del evento...")
            {
                txtTituloEvento.Text = "";
                txtTituloEvento.ForeColor = Color.Black;
            }
        }

        private void txtTituloEvento_Leave_1(object sender, EventArgs e)
        {
            if (txtTituloEvento.Text == "")
            {
                txtTituloEvento.Text = "Titulo del evento...";
                txtTituloEvento.ForeColor = Color.DimGray;
            }
        }

        private void btnColecciones_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 4;
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 5;
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 6;
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            tabContenedor.SelectedIndex = 7;
        }
    }
}

