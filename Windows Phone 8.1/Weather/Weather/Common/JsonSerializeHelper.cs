using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Weather.Common
{
    public static class JsonSerializeHelper
    {
        /// <summary>
        /// 序列化Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string JsonSerialize<T>(T target)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(target.GetType());

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, target);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }

            }
        }



        /// <summary>
        /// 反序列化Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static T JsonDeserialize<T>(string target) where T : class
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(target)))
            {
                return serializer.ReadObject(ms) as T;
            }
        }



        /// <summary>
        /// 文件化Json序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <param name="fileName"></param>
        /// <param name="fileFolder"></param>
        public static async void JsonSerializeForFile<T>(T target, string fileName, string fileFolder)
        {
            try
            {
                //序列化
                string jsonContent = JsonSerialize<T>(target);
                //获取本地文件夹，目录文件夹
                IStorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
                //
                IStorageFolder storageFolder = await local.GetFolderAsync(new Uri("ms-appdata:///local/") + fileFolder);
                //
                IStorageFile storageFile = await storageFolder.CreateFileAsync(new Uri("ms-appdata:///local/") + fileName, CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(storageFile, jsonContent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 文件化Json反序列化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static async Task<T> JsonDeSerializeForFile<T>(string fileName, string fileFolder) where T : class
        {
            try
            {
                //获取本地文件夹，目录文件夹
                IStorageFolder local = ApplicationData.Current.

                foreach (var file in await local.GetFoldersAsync())
                {
                    
                }

                IStorageFolder storageFolder = await local.GetFolderAsync(new Uri("ms-appdata:///local/")+fileFolder);
                IStorageFile storageFile = await storageFolder.GetFileAsync(new Uri("ms-appdata:///local/")+fileName);
                IRandomAccessStream accessSream = await storageFile.OpenReadAsync();
                using (StreamReader streaReader = new StreamReader(accessSream.AsStreamForRead((int)accessSream.Size)))
                {
                    return JsonDeserialize<T>(streaReader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
