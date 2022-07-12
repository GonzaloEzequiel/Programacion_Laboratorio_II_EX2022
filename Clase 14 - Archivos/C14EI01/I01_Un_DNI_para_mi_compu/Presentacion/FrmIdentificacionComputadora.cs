using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = "Compu de " + Environment.UserName;
            this.ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            this.lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";
            this.ConfigurarArquitectura();
            this.lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";
            this.lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine} {Environment.CurrentDirectory}";
            this.ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if (OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if (OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if (OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }

        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                this.lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                this.lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            DriveInfo[] discos = DriveInfo.GetDrives();
            double espacioTotal = 0;
            double espacioDisponible = 0;

            try
            {
                foreach (DriveInfo disco in discos)
                {
                    espacioTotal += disco.TotalSize;
                    espacioDisponible += disco.TotalFreeSpace;
                }
            }
            catch(Exception)
            {

            }

            double multiplicadorLoco = (9.31 * (Math.Pow(10, -10)));

            espacioTotal *= multiplicadorLoco;
            espacioDisponible *= multiplicadorLoco;

            this.lblEspacioTotal.Text = $"Espacio total: {Math.Floor(espacioTotal)} Gigabytes";
            this.lblEspacioDisponible.Text = $"Espacio disponible: {Math.Floor(espacioDisponible)} Gigabytes";

        }
    }
}
