using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Storage;
using Newtonsoft.Json;
using RestaurantAppVersion4.Model;

namespace WindowsAppsSerializeTest
{
    class PersistenceFacade
    {
        private static string jsonFileName = "Comments.dat";

        public static async void SaveCommentsAsJsonAsync(ObservableCollection<Comment> Comments)
        {
            string CommentsJsonString = JsonConvert.SerializeObject(Comments);
            SerializePersonsFileAsync(CommentsJsonString, jsonFileName);
        }

        public static async Task<List<Comment>> LoadCommentsFromJsonAsync()
        {
            string CommentsJsonString = await DeSerializeCommentsFileAsync(jsonFileName);
            return (List<Comment>)JsonConvert.DeserializeObject(CommentsJsonString, typeof(List<Comment>));  
        }

        public static async void SerializeCommentsFileAsync(string CommentsString, string fileName)
        {       
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, CommentsString);
        }

        public static async Task<string> DeSerializeCommentsFileAsync(String fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);           
        }    
    }
}
