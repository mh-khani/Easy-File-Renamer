using FileNameChanger.MVC;
using MetroFramework.Forms;
using System.Runtime.InteropServices;

namespace FileNameChanger
{
    public partial class Form1 : MetroForm
    {
        // DLL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        // Refrences
        public Controller controller = new Controller();
        public MVC.View view = new MVC.View();
        public Model model = new Model();

        private bool FirstIniPrefix = false, FirstIniSuffix = false;

        public Form1()
        {
            InitializeComponent();
            // UI Initialize
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width,
                this.Height, 20, 20));
            OpenFilesBt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, OpenFilesBt.Width,
                OpenFilesBt.Height, 20, 20));
            ChagefileNames.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ChagefileNames.Width,
                ChagefileNames.Height, 20, 20));
            Filenames.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Filenames.Width,
                Filenames.Height, 20, 20));
            InputNames.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, InputNames.Width,
                InputNames.Height, 20, 20));
            InputNames.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, InputNames.Width,
                InputNames.Height, 20, 20));
            PrefixTxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PrefixTxt.Width,
                PrefixTxt.Height, 20, 20));
            Suffixtxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Suffixtxt.Width,
                Suffixtxt.Height, 20, 20));

            // View Class
            view.Input = InputNames;
            view.selectedFiles = Model.selectedFiles;
            view.model = model;

        }
        private void OpenFilesBt_Click(object sender, EventArgs e) // Initialze Directory Open
        {
            if (InputNames.Text != "")
            {
                Application.Restart();
            }
            controller.DirectoryInitialize(openFileDialog1, Filenames);
            view.selectedFiles = Model.selectedFiles;

            ChagefileNames.ForeColor = Color.Black;
            Color temp = Color.YellowGreen;
            ChagefileNames.BackColor = temp;
            OpenFilesBt.BackColor = Color.WhiteSmoke;
        }

        private void InputNames_TextChanged(object sender, EventArgs e)
        {
            Show();
        }


        private void PrefixTxt_TextChanged(object sender, EventArgs e)
        {
            model.Prefix = PrefixTxt.Text;
            Show();

        }

        private void Suffixtxt_TextChanged(object sender, EventArgs e)
        {
            model.Suffix = Suffixtxt.Text;

            Show();

        }


        private void Suffixtxt_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FirstIniSuffix)
            {
                FirstIniSuffix = true;
                Suffixtxt.Text = "";
                Suffixtxt.ForeColor = Color.Black;
            }
            else
            {
                model.Suffix = Suffixtxt.Text;
                Show();
            }
        }
        private void PrefixTxt_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FirstIniPrefix)
            {
                PrefixTxt.Text = "";
                PrefixTxt.ForeColor = Color.Black;
                FirstIniPrefix = true;
            }
            else
            {
                model.Prefix = PrefixTxt.Text;
                Show();

            }
        }
        private void Show()
        {

            view.selectedFiles = Model.selectedFiles;
            view.model = model;
            Filenames.Items.Clear();
            Filenames.Items.AddRange(view.RefreshPreviewList());

        }

        private void ChagefileNames_Click(object sender, EventArgs e)
        {
            model.RenameFiles(InputNames);
        }
    }
}
