using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlantsEncyclopedia
{
    public static class Encyclopedia
    {
        private static List<Plant> plants;
        private static List<Characteristic> characteristics;

        public static List<Plant> GetPlants(int key)
        {
            if (key == 169)
                return plants;
            else throw new Exception("Encyclopedia > GetPlants");
        }
        public static List<Characteristic> GetCharacteristics(int key)
        {
            if (key == 169)
                return characteristics;
            else throw new Exception("Encyclopedia > GetCharacteristics");
        }

        // Serialization stuff
        public static void Serialize(object obj, string path)
        {
            File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                new BinaryFormatter().Serialize(fs, obj);
            }
        }
        public static object Deserialize(string path)
        {
            try
            {
                object obj = null;
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    obj = new BinaryFormatter().Deserialize(fs);
                return obj;
            }
            catch { return null; }
        }

        //Data managment
        public static void LoadData()
        {
            plants = (List<Plant>)Deserialize("PlantsDataBase.dat") ?? new List<Plant>();
            characteristics = (List<Characteristic>)Deserialize("CharacteristicsDataBase.dat") ?? new List<Characteristic>();
        }
        public static void SaveData()
        {
            FileInfo fileInfo = new FileInfo("PlantsDataBase.dat");
            Serialize(plants, "PlantsDataBase.dat");
            Serialize(characteristics, "CharacteristicsDataBase.dat");
        }
    }
}