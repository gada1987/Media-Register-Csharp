using System.Windows.Forms;
using System.IO;

namespace Mediaregister
{
    static class SaveHandler
    {
        static public void Save(Profile profile)
        {
            // Save media int text file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*txt) | *.txt";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(sfd.FileName);

                // Return array as string
                string text = string.Empty;
                foreach (var item in profile.mediaList) text += item.ToString() + "\n";
                writer.Write(text);
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
