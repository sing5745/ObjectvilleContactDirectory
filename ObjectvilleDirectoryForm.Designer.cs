namespace ObjecvilleContactDirectory
{
    partial class ObjectvilleDirectoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectvilleDirectoryForm));
            System.Windows.Forms.Label _lblContact;
            System.Windows.Forms.Label _lblName;
            System.Windows.Forms.Label _lblCompany;
            System.Windows.Forms.Label _lblTelepphone;
            System.Windows.Forms.Label _lblEmail;
            System.Windows.Forms.Label _lblClient;
            System.Windows.Forms.Label _lblLastCall;
            this._imgLogo = new System.Windows.Forms.PictureBox();
            this._contactDataSet = new ObjecvilleContactDirectory.ContactDBDataSet();
            this._bndContactList = new System.Windows.Forms.BindingSource(this.components);
            this._taContacts = new ObjecvilleContactDirectory.ContactDBDataSetTableAdapters.ContactsTableAdapter();
            this._taContactsAdapterManager = new ObjecvilleContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager();
            this._bndNavContactList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._txtContactId = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtCompany = new System.Windows.Forms.TextBox();
            this._txtTelephone = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._ckbClient = new System.Windows.Forms.CheckBox();
            this._dtLastCall = new System.Windows.Forms.DateTimePicker();
            this._btnClose = new System.Windows.Forms.Button();
            _lblContact = new System.Windows.Forms.Label();
            _lblName = new System.Windows.Forms.Label();
            _lblCompany = new System.Windows.Forms.Label();
            _lblTelepphone = new System.Windows.Forms.Label();
            _lblEmail = new System.Windows.Forms.Label();
            _lblClient = new System.Windows.Forms.Label();
            _lblLastCall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).BeginInit();
            this._bndNavContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // _imgLogo
            // 
            this._imgLogo.Image = global::ObjecvilleContactDirectory.Properties.Resources.OBC;
            this._imgLogo.Location = new System.Drawing.Point(409, 64);
            this._imgLogo.Name = "_imgLogo";
            this._imgLogo.Size = new System.Drawing.Size(268, 104);
            this._imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgLogo.TabIndex = 0;
            this._imgLogo.TabStop = false;
            this._imgLogo.Click += new System.EventHandler(this.OnShowAboutBox);
            // 
            // _contactDataSet
            // 
            this._contactDataSet.DataSetName = "ContactDBDataSet";
            this._contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _bndContactList
            // 
            this._bndContactList.DataMember = "Contacts";
            this._bndContactList.DataSource = this._contactDataSet;
            // 
            // _taContacts
            // 
            this._taContacts.ClearBeforeFill = true;
            // 
            // _taContactsAdapterManager
            // 
            this._taContactsAdapterManager.BackupDataSetBeforeUpdate = false;
            this._taContactsAdapterManager.ContactsTableAdapter = this._taContacts;
            this._taContactsAdapterManager.UpdateOrder = ObjecvilleContactDirectory.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _bndNavContactList
            // 
            this._bndNavContactList.AddNewItem = this.bindingNavigatorAddNewItem;
            this._bndNavContactList.BindingSource = this._bndContactList;
            this._bndNavContactList.CountItem = this.bindingNavigatorCountItem;
            this._bndNavContactList.DeleteItem = this.bindingNavigatorDeleteItem;
            this._bndNavContactList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._bndNavContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsBindingNavigatorSaveItem});
            this._bndNavContactList.Location = new System.Drawing.Point(0, 0);
            this._bndNavContactList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._bndNavContactList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._bndNavContactList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._bndNavContactList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._bndNavContactList.Name = "_bndNavContactList";
            this._bndNavContactList.PositionItem = this.bindingNavigatorPositionItem;
            this._bndNavContactList.Size = new System.Drawing.Size(722, 27);
            this._bndNavContactList.TabIndex = 1;
            this._bndNavContactList.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.contactsBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // _lblContact
            // 
            _lblContact.AutoSize = true;
            _lblContact.Location = new System.Drawing.Point(55, 67);
            _lblContact.Name = "_lblContact";
            _lblContact.Size = new System.Drawing.Size(75, 17);
            _lblContact.TabIndex = 2;
            _lblContact.Text = "Contact Id:";
            // 
            // _txtContactId
            // 
            this._txtContactId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "ContactId", true));
            this._txtContactId.Location = new System.Drawing.Point(141, 64);
            this._txtContactId.Name = "_txtContactId";
            this._txtContactId.Size = new System.Drawing.Size(200, 22);
            this._txtContactId.TabIndex = 3;
            // 
            // _lblName
            // 
            _lblName.AutoSize = true;
            _lblName.Location = new System.Drawing.Point(55, 95);
            _lblName.Name = "_lblName";
            _lblName.Size = new System.Drawing.Size(49, 17);
            _lblName.TabIndex = 4;
            _lblName.Text = "Name:";
            // 
            // _txtName
            // 
            this._txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Name", true));
            this._txtName.Location = new System.Drawing.Point(141, 92);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(200, 22);
            this._txtName.TabIndex = 5;
            // 
            // _lblCompany
            // 
            _lblCompany.AutoSize = true;
            _lblCompany.Location = new System.Drawing.Point(55, 123);
            _lblCompany.Name = "_lblCompany";
            _lblCompany.Size = new System.Drawing.Size(71, 17);
            _lblCompany.TabIndex = 6;
            _lblCompany.Text = "Company:";
            // 
            // _txtCompany
            // 
            this._txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Company", true));
            this._txtCompany.Location = new System.Drawing.Point(141, 120);
            this._txtCompany.Name = "_txtCompany";
            this._txtCompany.Size = new System.Drawing.Size(200, 22);
            this._txtCompany.TabIndex = 7;
            // 
            // _lblTelepphone
            // 
            _lblTelepphone.AutoSize = true;
            _lblTelepphone.Location = new System.Drawing.Point(55, 151);
            _lblTelepphone.Name = "_lblTelepphone";
            _lblTelepphone.Size = new System.Drawing.Size(80, 17);
            _lblTelepphone.TabIndex = 8;
            _lblTelepphone.Text = "Telephone:";
            // 
            // _txtTelephone
            // 
            this._txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Telephone", true));
            this._txtTelephone.Location = new System.Drawing.Point(141, 148);
            this._txtTelephone.Name = "_txtTelephone";
            this._txtTelephone.Size = new System.Drawing.Size(200, 22);
            this._txtTelephone.TabIndex = 9;
            // 
            // _lblEmail
            // 
            _lblEmail.AutoSize = true;
            _lblEmail.Location = new System.Drawing.Point(55, 179);
            _lblEmail.Name = "_lblEmail";
            _lblEmail.Size = new System.Drawing.Size(46, 17);
            _lblEmail.TabIndex = 10;
            _lblEmail.Text = "Email:";
            // 
            // _txtEmail
            // 
            this._txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Email", true));
            this._txtEmail.Location = new System.Drawing.Point(141, 176);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(200, 22);
            this._txtEmail.TabIndex = 11;
            // 
            // _lblClient
            // 
            _lblClient.AutoSize = true;
            _lblClient.Location = new System.Drawing.Point(55, 209);
            _lblClient.Name = "_lblClient";
            _lblClient.Size = new System.Drawing.Size(47, 17);
            _lblClient.TabIndex = 12;
            _lblClient.Text = "Client:";
            // 
            // _ckbClient
            // 
            this._ckbClient.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._bndContactList, "Client", true));
            this._ckbClient.Location = new System.Drawing.Point(141, 204);
            this._ckbClient.Name = "_ckbClient";
            this._ckbClient.Size = new System.Drawing.Size(200, 24);
            this._ckbClient.TabIndex = 13;
            this._ckbClient.UseVisualStyleBackColor = true;
            // 
            // _lblLastCall
            // 
            _lblLastCall.AutoSize = true;
            _lblLastCall.Location = new System.Drawing.Point(55, 238);
            _lblLastCall.Name = "_lblLastCall";
            _lblLastCall.Size = new System.Drawing.Size(66, 17);
            _lblLastCall.TabIndex = 14;
            _lblLastCall.Text = "Last Call:";
            // 
            // _dtLastCall
            // 
            this._dtLastCall.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bndContactList, "LastCall", true));
            this._dtLastCall.Location = new System.Drawing.Point(141, 234);
            this._dtLastCall.Name = "_dtLastCall";
            this._dtLastCall.Size = new System.Drawing.Size(200, 22);
            this._dtLastCall.TabIndex = 15;
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(409, 283);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(268, 33);
            this._btnClose.TabIndex = 16;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnClose);
            // 
            // ObjectvilleDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 422);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(_lblContact);
            this.Controls.Add(this._txtContactId);
            this.Controls.Add(_lblName);
            this.Controls.Add(this._txtName);
            this.Controls.Add(_lblCompany);
            this.Controls.Add(this._txtCompany);
            this.Controls.Add(_lblTelepphone);
            this.Controls.Add(this._txtTelephone);
            this.Controls.Add(_lblEmail);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(_lblClient);
            this.Controls.Add(this._ckbClient);
            this.Controls.Add(_lblLastCall);
            this.Controls.Add(this._dtLastCall);
            this.Controls.Add(this._bndNavContactList);
            this.Controls.Add(this._imgLogo);
            this.Name = "ObjectvilleDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objectville Contact Directory";
            this.Load += new System.EventHandler(this.ObjectvilleDirectoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).EndInit();
            this._bndNavContactList.ResumeLayout(false);
            this._bndNavContactList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgLogo;
        private ContactDBDataSet _contactDataSet;
        private System.Windows.Forms.BindingSource _bndContactList;
        private ContactDBDataSetTableAdapters.ContactsTableAdapter _taContacts;
        private ContactDBDataSetTableAdapters.TableAdapterManager _taContactsAdapterManager;
        private System.Windows.Forms.BindingNavigator _bndNavContactList;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox _txtContactId;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtCompany;
        private System.Windows.Forms.TextBox _txtTelephone;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.CheckBox _ckbClient;
        private System.Windows.Forms.DateTimePicker _dtLastCall;
        private System.Windows.Forms.Button _btnClose;
    }
}

