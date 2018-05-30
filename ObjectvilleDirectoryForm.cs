using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjecvilleContactDirectory
{
    public partial class ObjectvilleDirectoryForm : Form
    {
        /// <summary>
        /// Constructor of the form which will create and initialize
        /// all the controls on the form
        /// </summary>
        public ObjectvilleDirectoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler called when the user clicks on the logo.
        /// Displays the abou information
        /// </summary>
        /// <param name="sender">the image (picturebox) control</param>
        /// <param name="e">not used</param>
        private void OnShowAboutBox(object sender, EventArgs e)
        {
            MessageBox.Show("The Objectville Paper Company Contact Directory 1.0\n Written By Inderpreet Singh", "About");
        }

        /// <summary>
        /// Event handler for saving a new record being added to 
        /// the contact table
        /// </summary>
        /// <param name="sender">the save button on the binding navigator tool</param>
        /// <param name="e">not used</param>
        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //prform dta validation
            this.Validate();

            //ensure temporary changes are made final
            this._bndContactList.EndEdit();

            //update the database with all changes
            this._taContactsAdapterManager.UpdateAll(this._contactDataSet);

        }

        private void ObjectvilleDirectoryForm_Load(object sender, EventArgs e)
        {
            //Fill the local dataset wich caches the database data in
            // local memory with data
            _taContacts.Fill(_contactDataSet.Contacts);

        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}
