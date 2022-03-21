using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mediaregister
{
    static class ProfileHandler
    {
        static public List<Profile> profiles = new List<Profile>();
        
        static public void AddProfile(string name)
        {
            if (!ValidateProfileName(name)) return; // Control name
            profiles.Add(new Profile(name)); // Add new profile
        }

        static public void Display(ListBox listBox)
        {
            // Update listBox items to match profiles list
            listBox.Items.Clear();
            listBox.Items.AddRange(profiles.ToArray());
            listBox.SelectedIndex = profiles.Count - 1; // Set selected profile to newly created profile
        }

        static private bool ValidateProfileName(string name)
        {
            // Validate inputs, throw error otherwise
            string errorMessage = "Name not valid";
            Char[] charArray = name.ToCharArray();
            if (charArray.Length <= 0) { Form1.ThrowError(errorMessage); return false; } // If no letter written
            if (!charArray.All(char.IsLetterOrDigit)) { Form1.ThrowError(errorMessage); return false; } // Not all letters or digits
            foreach (var profile in profiles) if (profile.name == name) { Form1.ThrowError(errorMessage); return false; } // Profile with name already exists
            return true;
        }
    }
}
