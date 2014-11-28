using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;
using RestaurantAppVersion4.Model;

namespace RestaurantAppVersion4
{
    class PersistenceFacade
    {
        private static string jsonFileName = "Comments.dat";

        public static async void SaveCommentsAsJsonAsync(ObservableCollection<KommentarModel> comments)
        {
            string CommentsJsonString = JsonConvert.SerializeObject(comments);
            SerializeCommentsFileAsync(CommentsJsonString, jsonFileName);
        }

        public static async Task<List<KommentarModel>> LoadCommentsFromJsonAsync()
        {
            string CommentsJsonString = await DeSerializeCommentsFileAsync(jsonFileName);
            return (List<KommentarModel>)JsonConvert.DeserializeObject(CommentsJsonString, typeof(List<KommentarModel>));  
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
