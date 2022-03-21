using System;
using System.Windows.Forms;
using System.IO;

namespace Mediaregister
{
    public partial class Form1 : Form
    {
        //Variables
        Profile selectedProfile;
        
        public Form1()
        {
            InitializeComponent();
            nud_legnth.Value = 0;
            nud_nrOfPages.Value = 0;
        }

        #region Methods

        private void ResetTextBoxes()
        {
            tbx_author.Clear();
            tbx_director.Clear();
            tbx_bookTitle.Clear();
            tbx_filmTitle.Clear();
            nud_legnth.Value = 0;
            nud_nrOfPages.Value = 0;
        }

        static public void ThrowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        #endregion

        #region Callback functions

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Add media
        private void Btn_AddFilm_Click(object sender, EventArgs e)
        {
            MediaHandler.AddFilm(selectedProfile,  tbx_filmTitle.Text, tbx_director.Text, nud_legnth.Value);
            MediaHandler.Display(selectedProfile, rtf_display);
            ResetTextBoxes();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            MediaHandler.AddBook(selectedProfile, tbx_bookTitle.Text, tbx_author.Text, nud_nrOfPages.Value);
            MediaHandler.Display(selectedProfile, rtf_display);
            ResetTextBoxes();
        }

        // Filter
        private void rbtn_films_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_films.Checked) MediaHandler.filter = MediaHandler.Filter.films;
            MediaHandler.Display(selectedProfile, rtf_display);
        }

        private void rbtn_all_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_all.Checked) MediaHandler.filter = MediaHandler.Filter.all;
            MediaHandler.Display(selectedProfile, rtf_display);
        }

        private void rbtn_books_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_books.Checked) MediaHandler.filter = MediaHandler.Filter.books;
            MediaHandler.Display(selectedProfile, rtf_display);
        }

        // Save
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveHandler.Save(selectedProfile);
        }

        // Profile
        private void lbx_availableProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_availableProfiles.SelectedItem == null) return;
            selectedProfile = (Profile)lbx_availableProfiles.SelectedItem; // Set current profile to selected profile
            MediaHandler.Display(selectedProfile, rtf_display);
        }

        private void btn_addNewProfile_Click(object sender, EventArgs e)
        {
            ProfileHandler.AddProfile(tbx_newProfile.Text);
            tbx_newProfile.Clear(); // Clear new profile text box
            ProfileHandler.Display(lbx_availableProfiles);
        }

        

        #endregion
    }
}
