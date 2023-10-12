using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Anket_Json
{
    public partial class Form1 : Form
    {
        bool flag = false;
        List<User> users = new List<User> {
            new User{ Name="Ruad",Surname="Dunyamaliyev",Email="ruad10015@gmail.com",Phone="994103110104",
                BirthDate=new DateTime(2008,05,17),JsonFileName="ruad.json"},
            new User{ Name="Vusal",Surname="Dunyamaliyev",Email="vusal10015@gmail.com",Phone="994503110104",
                BirthDate=new DateTime(1979,10,27),JsonFileName="vusal.json"}
        };

        User selectedUser = null;
        public Form1()
        {
            InitializeComponent();
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            FileManage.WriteJsonAllUser(users);
            users = FileManage.ReadJsonAllUser();
            foreach (User user in users)
            {
                FileManage.WriteJson(user);
            }
            listBox.DataSource = users;
            listBox.DisplayMember = nameof(User.Name);
            listBox.SelectedIndex = 0;
            btnChange.Enabled = false;
            flag = false;
        }



        /// <summary>
        /// Creates a new user with the information entered by the user and adds it to the user list.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFilledAll())
                {
                    var newUser = OtherHelperFunctions.GetUser(txtName.Text, txtSurname.Text,
                        txtEmail.Text, mskTxtPhone.Text, dtpBirthDate.Value);
                    users.Add(newUser);
                    FileManage.WriteJsonAllUser(users);
                    users = FileManage.ReadJsonAllUser();
                    listBox.DataSource = null;
                    listBox.DataSource = users;
                    listBox.DisplayMember = nameof(User.Name);

                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileManage.LogError(ex); 
            }
        }



        /// <summary>
        /// Displays the information of the selected user in the ListBox.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedUser = listBox.SelectedItem as User;
                if (selectedUser != null)
                {
                    txtFileName.Text = selectedUser.JsonFileName;
                }
                else
                {

                    btnChange.Enabled = false;
                    txtName.Text = string.Empty;
                    txtSurname.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    mskTxtPhone.Text = string.Empty;
                    dtpBirthDate.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileManage.LogError(ex);
            }

        }



        /// <summary>
        /// Saves the information of the selected user.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser != null)
                {
                    if (Validation.isFilled(txtFileName.Text))
                    {
                        selectedUser.JsonFileName = txtFileName.Text;
                        FileManage.WriteJson(selectedUser);
                        FileManage.WriteJsonAllUser(users);
                        users = FileManage.ReadJsonAllUser();
                        listBox.DataSource = null;
                        listBox.DataSource = users;
                        listBox.DisplayMember = nameof(User.Name);
                        MessageBox.Show($"User added {selectedUser.JsonFileName}",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileManage.LogError(ex);
            }
        }


        /// <summary>
        /// Reads a JSON-formatted file and loads the user.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.CheckJsonFormat(txtFileName.Text))
                {
                    flag = true;
                    btnChange.Enabled = true;

                    selectedUser = FileManage.ReadJson(txtFileName.Text);


                    txtName.Text = selectedUser.Name;
                    txtSurname.Text = selectedUser.Surname;
                    txtEmail.Text = selectedUser.Email;
                    mskTxtPhone.Text = selectedUser.Phone;
                    dtpBirthDate.Value = selectedUser.BirthDate;

                    MessageBox.Show($"User loaded from {selectedUser.JsonFileName}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileManage.LogError(ex);
            }

        }


        /// <summary>
        /// Handles the click event when the user wants to change the data of a selected user.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser != null && isFilledAll())
                {
                    selectedUser = OtherHelperFunctions.GetUser(txtName.Text, txtSurname.Text, txtEmail.Text,
                                   mskTxtPhone.Text, dtpBirthDate.Value);
                    selectedUser.JsonFileName = txtFileName.Text;
                    FileManage.WriteJson(selectedUser);
                    MessageBox.Show($"{selectedUser.Name} data changed successfully...",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FileManage.WriteJsonAllUser(users);
                    users = FileManage.ReadJsonAllUser();
                    listBox.DataSource = null;
                    listBox.DataSource = users;
                    listBox.DisplayMember = nameof(User.Name);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileManage.LogError(ex);
            }
        }


        /// <summary>
        /// Checks if all required fields are filled with valid data.
        /// </summary>
        /// <returns>True if all fields are filled correctly, false otherwise</returns>
        private bool isFilledAll()
        {
            if (Validation.isFilled(txtName.Text) && Validation.isFilled(txtSurname.Text) &&
                Validation.isFilled(txtEmail.Text) && Validation.isFilled(mskTxtPhone.Text) &&
                Validation.CheckDateTime(dtpBirthDate.Value)) return true; return false;
        }


        /// <summary>
        /// Handles the click event when the user wants to clear the input fields.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">Event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (flag) { flag = false; btnChange.Enabled = true; }
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mskTxtPhone.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }
    }
}


