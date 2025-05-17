using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNameChanger.MVC
{
    public class View
    {
        public TextBox Input;
        public List<string> selectedFiles = new List<string>();
        public Model model;

        public string[] RefreshPreviewList()
        {
            var newNames = Input.Text
                 .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (newNames.Length != selectedFiles.Count)
            {
                string[] txt = { "The number of new names must match the number of selected files." };
                return txt;
            }
            else
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < selectedFiles.Count; i++)
                {

                    temp.Add(model.Prefix + newNames[i] + model.Suffix + "." + GetFileExtensionOnly(selectedFiles[i]));
                }
                return temp.ToArray();
            }
        }
        private string GetFileExtensionOnly(string fullPath)
        {
            return Path.GetExtension(fullPath).TrimStart('.').ToLower();
        }
    }
}
