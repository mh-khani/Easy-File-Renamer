namespace FileNameChanger.MVC
{
    public class Controller
    {

        public void DirectoryInitialize(OpenFileDialog ofd, ListBox listBox1)
        {
            ofd.Multiselect = true;
            ofd.Filter = "All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Model.selectedFiles = ofd.FileNames.ToList(); // Assign selected files to the instance field
                foreach (string file in Model.selectedFiles)
                {
                    listBox1.Items.Add(GetFileNameWithExtension(file)); // Add to the list for display and renaming
                }
            }
        }
        public string GetFileNameWithExtension(string fullPath)
        {
            return Path.GetFileName(fullPath);
        }
    }
}
