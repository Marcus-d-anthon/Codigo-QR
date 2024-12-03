using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Codigo_QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw CodigoQR = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            ptbCodigoQR.Image = CodigoQR.Draw(txtTextoQR.Text, 40);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivos.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            GuardarArchivos.FileName = "";
            GuardarArchivos.Filter = "JPEG|*.jpeg";

            if (GuardarArchivos.ShowDialog() != DialogResult.Cancel)
            {
                string VariableImagen = GuardarArchivos.FileName;
                Bitmap VarBitmap = new Bitmap(ptbCodigoQR.Image);
                VarBitmap.Save(VariableImagen, ImageFormat.Jpeg);
            }
        }
    }
}
