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

        private Action ShowAction;

        public Form1()
        {
            InitializeComponent();
            #region UI
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
            #endregion
            // View Class
            view.Input = InputNames;
            view.selectedFiles = Model.selectedFiles;
            view.model = model;

            ShowAction += Show;
        }

        #region Refresh_Preview
        private void InputNames_TextChanged(object sender, EventArgs e)
        {
            ShowAction?.Invoke();
        }

        private void PrefixTxt_TextChanged(object sender, EventArgs e)
        {
            model.Prefix = PrefixTxt.Text;
            ShowAction?.Invoke();
        }

        private void Suffixtxt_TextChanged(object sender, EventArgs e)
        {
            model.Suffix = Suffixtxt.Text;
            ShowAction?.Invoke();
        }
        private void Show()
        {
            view.selectedFiles = Model.selectedFiles;
            view.model = model;
            Filenames.Items.Clear();
            Filenames.Items.AddRange(view.RefreshPreviewList());
        }
        #endregion

        #region Events
        private void OpenFilesBt_Click(object sender, EventArgs e) // Initialze Directory Open
        {
            if (InputNames.Text != "" || Model.selectedFiles.Count != 0)
            {
                Application.Restart();
            }
            controller.DirectoryInitialize(openFileDialog1, Filenames);
            view.selectedFiles = Model.selectedFiles;

            InitializeProgram();
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
            }
        }
        private void ChagefileNames_Click(object sender, EventArgs e)
        {
            model.RenameFiles(InputNames);
        }
        private void AutoIncrement_CheckedChanged(object sender, EventArgs e)
        {
            model.AutoInc = !model.AutoInc;
            ShowAction?.Invoke();
        }
        private void AutoA_Z_CheckedChanged(object sender, EventArgs e)
        {
            model.AutoABC = !model.AutoABC;
            ShowAction?.Invoke();
        }
        private void none_CheckedChanged(object sender, EventArgs e)
        {
            model.AutoABC = false;
            model.AutoInc = false;
            ShowAction?.Invoke();
        }
        #endregion
        private void InitializeProgram()
        {
            ChagefileNames.ForeColor = Color.Black;
            ChagefileNames.BackColor = Color.YellowGreen;
            OpenFilesBt.BackColor = Color.WhiteSmoke;

            AutoIncrement.Enabled = true;
            AutoA_Z.Enabled = true;
            ChagefileNames.Enabled = true;
            PrefixTxt.Enabled = true;
            Suffixtxt.Enabled = true;
            InputNames.Enabled = true;
            none.Enabled = true;
        }

        
    }
}
