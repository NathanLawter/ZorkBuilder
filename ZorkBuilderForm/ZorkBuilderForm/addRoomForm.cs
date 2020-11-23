using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorkBuilderForm.WinForms
{
    public partial class addRoomForm : Form
    {
        public string RoomName
        {
            get => roomNameTextBox.Text;
            set => roomNameTextBox.Text = value;
        }

        public string RoomDescription
        {
            get => roomDescriptionTextBox.Text;
            set => roomDescriptionTextBox.Text = value;
        }

        public addRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
