using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorkBuilder.Data;
using ZorkBuilderForm.WinForms.ViewModels;

namespace ZorkBuilderForm.WinForms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
        private WorldViewModel mViewModel;
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }
        private bool mIsGameLoaded;
        private bool IsGameLoaded
        {
            get => mIsGameLoaded;
            set
            {
                mIsGameLoaded = value;
                zorkTabControl.Enabled = mIsGameLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsGameLoaded = false;
        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Game = game;
                ViewModel.Filename = openFileDialog.FileName;
                IsGameLoaded = true;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveGame();

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveGame();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createNewDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = createNewDialog.FileName;
                ViewModel.Rooms = new BindingList<Room> { new Room { Name = "Start" } };
                ViewModel.SaveGame();
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(createNewDialog.FileName));
                ViewModel.Game = game;
                IsGameLoaded = true;
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (addRoomForm addRoomForm = new addRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO
                    Room room = new Room { Name = addRoomForm.RoomName, Description = addRoomForm.RoomDescription };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
                roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }
    }
}
