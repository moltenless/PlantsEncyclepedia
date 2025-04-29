using System;
using System.Collections.Generic;

namespace Энциклопедия_растений
{
    public class Filter
    {
        public List<object> FilterItems { get; private set; }
        public string NameFiltering { get; private set; }
        public bool IsFilterReady { get; private set; } = false;

        public Filter(string nameFiltering)
        {
            FilterItems = new List<object>();
            NameFiltering = nameFiltering;
        }

        public void AddItemToFilter(object item, ContentType contentType)
        {
            if (item == null)
            {
                FilterItems.Add(null);
                if (FilterItems.Count == Encyclopedia.GetCharacteristics(169).Count)
                {
                    IsFilterReady = true;
                }
                else
                {
                    IsFilterReady = false;
                }
                return;
            }
            switch (contentType)
            {
                case ContentType.Bool:
                    {
                        if (item is bool newItem)
                        {
                            FilterItems.Add(newItem);
                        }
                        else
                            throw new Exception("Filter > AddItemToFilter");

                        break;
                    }
                case ContentType.List:
                    {
                        if (item is bool[] newItem)
                        {
                            FilterItems.Add(newItem);
                        }
                        else if (item is object[] newItem2)
                        {
                            FilterItems.Add(newItem2);
                        }
                        else
                            throw new Exception("Filter > AddItemToFilter");
                        break;
                    }
                case ContentType.Text:
                    {
                        if (item is string newItem)
                        {
                            FilterItems.Add(newItem);
                        }
                        else
                            throw new Exception("Filter > AddItemToFilter");

                        break;
                    }
                default: throw new Exception("Filter > AddItemToFilter > default");
            }
            if (FilterItems.Count == Encyclopedia.GetCharacteristics(169).Count)
            {
                IsFilterReady = true;
            }
            else
            {
                IsFilterReady = false;
            }
        }

        public List<Plant> GetResults(List<Plant> sourcePlants)
        {
            List<Plant> results = new List<Plant>();

            if (!IsFilterReady)
                throw new Exception("Filter > GetResults()");

            FilterItems.Insert(0, NameFiltering);
            foreach (var plant in sourcePlants)
            {
                if (plant.FitToFilter(this))
                {
                    results.Add(plant);
                }
            }
            return results;
        }
    }
}
