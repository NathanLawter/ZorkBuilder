using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkBuilder.Data;

namespace ZorkBuilderForm.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public BindingList<Room> Rooms { get; set; }
        public World World { get; set; }
        public string WelcomeMessage { get; set; }
        private Game mGame;
        public Game Game
        {
            set
            {
                if(mGame != value)
                {
                    mGame = value;
                    if(mGame != null)
                    {
                        WelcomeMessage = mGame.WelcomeMessage;
                        World = mGame.World;
                        Rooms = new BindingList<Room>(mGame.World.Rooms);
                    }
                    else
                    {
                        WelcomeMessage = "";
                        World = new World();
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public WorldViewModel(Game game = null)
        {
            Game = game;
        }

        public void SaveGame()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }
    }
}
