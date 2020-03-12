using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Mvvm;

namespace Module.ViewModels
{
    public class View3ViewModel:BindableBase
    {
        public View3ViewModel()
        {
            var now = DateTime.Now;
            var random = new Random();
            Data = Enumerable.Range(0, 1000).Select(i => new DataItem()
            {
                Key = i,// now.AddSeconds(i),
                Value = random.Next(10, 1000),
            }).ToList();

            //Data = new Dictionary<string, int>();

            //Data.Add("aaaa", 10);
            //Data.Add("bbbb", 60);
            //Data.Add("cccc", 30);
            //Data.Add("dddd", 40);
            //Data.Add("eeee", 50);
            //Data.Add("ffff", 80);
            //Data.Add("gggg", 20);
        }
        //public Dictionary<string, int> Data { get; private set; }
        public List<DataItem> Data { get; set; }
    }

    public class DataItem
    {
        public int Key { get; set; }
        public float Value { get; set; }
    }
}
