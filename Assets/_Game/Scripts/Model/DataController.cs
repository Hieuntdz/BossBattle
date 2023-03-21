using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
public static class DataController
{
    public static void WriteToFile(string fileName, string data)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter write = new StreamWriter(fileStream))
        {
            write.Write(data);
        }
    }
    public static string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.LogWarning("File not found!");
        }
        return "";
    }
    public static string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
    public static bool IsExist(string path){
        return (File.Exists(path)) ? true : false;
    }
    public static T ParseTo<T>(string _data){
        var data = JsonConvert.DeserializeObject<T>(_data);
        return data;
    }
    public static T ParseTo<T>(this T obj, string _data){
        obj = JsonConvert.DeserializeObject<T>(_data);
        return obj;
    }
}
