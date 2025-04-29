using System;
using System.Collections.Generic;
using System.Drawing;

namespace PlantsEncyclopedia
{
    [Serializable]
    public class Plant
    {
        public string Name { get; private set; }
        public List<Image> Images { get; private set; }
        public List<object> Contents { get; private set; }

        public Plant(string name, List<Image> images, List<object> contents)
        {
            Name = name;
            Images = images;
            Contents = contents;
        }
        
        public bool FitToFilter(Filter filter)
        {
            bool isSuitableToFilter = true;
            if (!IsNameFit(filter.FilterItems[0]))
                return false;
            for (int i = 1; i < Contents.Count; i++)
            {
                if (filter.FilterItems[i] == null || Contents[i] == null)
                {
                    isSuitableToFilter = true;
                }
                else if (filter.FilterItems[i] is bool param1)
                {
                    if (param1 != (bool)Contents[i])
                    {
                        return false;
                    }
                }
                else if (filter.FilterItems[i] is string param2)
                {
                    if (param2 != (string)Contents[i])
                    {
                        return false;
                    }
                }
                else if (filter.FilterItems[i] is bool[] param3)
                {
                    isSuitableToFilter = false;
                    string[] chosenElements = Contents[i] as string[];
                    for (int j = 0; j < param3.Length; j++)
                    {
                        for (int h = 0; h < chosenElements.Length; h++)
                        {
                            if (chosenElements[h] == Encyclopedia.GetCharacteristics(169)[i].List[j] == true && param3[j])
                            {
                                isSuitableToFilter = true;
                                break;
                            }
                        }
                    }
                    return isSuitableToFilter;
                }
                else if (filter.FilterItems[i] is object[] param4)
                {
                    isSuitableToFilter = false;
                    bool higher = (bool)param4[0];
                    double number = (double)param4[1];
                    string[] chosenElements = Contents[i] as string[];

                    for (int h = 0; h < chosenElements.Length; h++)
                    {
                        if (higher && number > Convert.ToDouble(chosenElements[h]))
                        {
                            isSuitableToFilter = true;
                            break;
                        }
                        else if (!higher && number < Convert.ToDouble(chosenElements[h]))
                        {
                            isSuitableToFilter = true;
                            break;
                        }
                    }
                    return isSuitableToFilter;
                }
            }
            return isSuitableToFilter;

            bool IsNameFit(object filteringName)
            {
                if (filteringName == null) return true;
                string[] words = Name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word == (string)filteringName || word.Contains((string)filteringName))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static void Create(Plant plant)
        {
            if (plant.Contents.Count != Encyclopedia.GetCharacteristics(169).Count)
                throw new Exception("Plant > Create()");
            Encyclopedia.GetPlants(169).Add(plant);
        }

        public static void Change(Plant oldPlant, Plant newPlant)
        {
            oldPlant = newPlant;
        }

        public static void Delete(Plant plant)
        {
            Encyclopedia.GetPlants(169).Remove(plant);
        }
    }
}
