namespace ProgramDioptase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ProgramDioptase.CatalogItems;
    using ProgramDioptase.ClientDescription;
    using ProgramDioptase.Interfaces.DatabaseManager;

    public class Resources : ICatalogItemManager, IClientManager, IStatisticManager
    {
        private static IList<Movie> movies;
        private static IList<Game> games;
        private static IList<Music> music;
        private static IList<Client> clients;

        private static string movieOrdersCount;
        private static string gameOrdersCount;
        private static string musicOrdersCount;

        public Resources(IFileManager dataManager)
        {
            this.DataManager = dataManager;
        }

        private IFileManager DataManager { get; set; }

        #region [Statistic Manager]
        
        public string MovieOrdersCount
        {
            get
            {
                if (string.IsNullOrEmpty(movieOrdersCount))
                {
                    movieOrdersCount = this.DataManager.GetOrdersCount(this.DataManager.GetBaseDirectory("Movie"));
                }
                
                return movieOrdersCount;
            }
        }
        
        public string GameOrdersCount
        {
            get
            {
                if (string.IsNullOrEmpty(gameOrdersCount))
                {
                    gameOrdersCount = this.DataManager.GetOrdersCount(this.DataManager.GetBaseDirectory("Game"));
                }
                
                return gameOrdersCount;
            }
        }
        
        public string MusicOrdersCount
        {
            get
            {
                if (string.IsNullOrEmpty(musicOrdersCount))
                {
                    musicOrdersCount = this.DataManager.GetOrdersCount(this.DataManager.GetBaseDirectory("Music"));
                }
                
                return musicOrdersCount;
            }
        }
        
        #endregion

        #region [Catalog Manager]
        
        public IList<Movie> Movies
        {
            get
            {
                if (movies == null)
                {
                    movies = this.DataManager.GetItems<Movie>(this.DataManager.GetBaseDirectory("Movie"));
                }
            
                return movies;
            }
        }
        
        public IList<Game> Games
        {
            get
            {
                if (games == null)
                {
                    games = this.DataManager.GetItems<Game>(this.DataManager.GetBaseDirectory("Game"));
                }
            
                return games;
            }
        }
        
        public IList<Music> Music
        {
            get
            {
                if (music == null)
                {
                    music = this.DataManager.GetItems<Music>(this.DataManager.GetBaseDirectory("Music"));
                }
            
                return music;
            }
        }
        
        #endregion

        #region [Client Manager]

        public IList<Client> Clients
        {
            get
            {
                if (clients == null)
                {
                    clients = this.DataManager.GetItems<Client>(this.DataManager.GetBaseDirectory("Client"));
                }
        
                return clients;
            }
        }
        
        #endregion
    }
}