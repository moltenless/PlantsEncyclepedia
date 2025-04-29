using System;

namespace PlantsEncyclopedia
{
    [Serializable]
    public class Characteristic
    {
        public string Name { get; private set; }
        public ContentType Type { get; private set; }
        public string[] List { get; private set; }
        public bool IsListNumeric { get; private set; }

        public Characteristic(string name, ContentType c, string[] list = null, bool isListNumeric = false)
        {
            Name = name;
            Type = c;
            List = list;
            IsListNumeric = isListNumeric;
            for (int i = 0; isListNumeric == true && i < list.Length; i++)
            {
                Convert.ToDouble(list[i]);
            }
        }

        public static void Create(Characteristic newCharacteristic, object[] contentsForAppending)
        {
            Encyclopedia.GetCharacteristics(169).Add(newCharacteristic);
            for (int i = 0; i < Encyclopedia.GetPlants(169).Count; i++)
            {
                Encyclopedia.GetPlants(169)[i].Contents.Add(contentsForAppending);
            }
        }

        public static void Change(Characteristic oldCharacteristic, Characteristic newCharacteristic, object[] contents)
        {
            int index = Encyclopedia.GetCharacteristics(169).IndexOf(oldCharacteristic);
            oldCharacteristic = newCharacteristic;
            for (int i = 0; i < Encyclopedia.GetPlants(169).Count; i++)
            {
                Encyclopedia.GetPlants(169)[i].Contents[index] = (newCharacteristic, contents[i]);
            }
        }

        public static void Delete(Characteristic characteristic)
        {
            int index = Encyclopedia.GetCharacteristics(169).IndexOf(characteristic);
            Encyclopedia.GetCharacteristics(169).Remove(characteristic);
            for (int i = 0; i < Encyclopedia.GetPlants(169).Count; i++)
            {
                Encyclopedia.GetPlants(169)[i].Contents.RemoveAt(index);
            }
        }
    }

    public enum ContentType
    {
        Text, List, Bool
    }
}
