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
        private static string jsonFileName = "Kommentars.dat";
        
        public static async void SavePersonsAsJsonAsync(ObservableCollection<KommentarModel> _kommentars)
        {
            string personsJsonString = JsonConvert.SerializeObject(_kommentars);
            SerializePersonsFileAsync(personsJsonString, jsonFileName);
        }

        public static async Task<List<KommentarModel>> LoadPersonsFromJsonAsync()
        {
            string personsJsonString = await DeSerializePersonsFileAsync(jsonFileName);
            return (List<KommentarModel>)JsonConvert.DeserializeObject(personsJsonString, typeof(List<KommentarModel>));  
        }

        public static async void SerializePersonsFileAsync(string PersonsString, string fileName)
        {       
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, PersonsString);
        }

        public static async Task<string> DeSerializePersonsFileAsync(String fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);           
        }
    }
}
