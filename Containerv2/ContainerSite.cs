using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Containerv2
{
    public class ContainerSite
    {

        private int _currentVacantSlots;
        private Container[] _containers;
        private string _fileName = "containers.json";

        public Container[] SiteContainer
        {
            get { return _containers; }
            set { _containers = value; }
        }

        public int CurrentSlots { get { return _currentVacantSlots; } set { _currentVacantSlots = value; } }

        //Initialize Container Object Array

        public void InitContainers()
        {
            _containers = new Container[103];
            for (int i =0; i < _containers.Length; i++)
            {
                _containers[i] = new Container(i);
            }
        }

        //Serialize the object array to a .json file for storage of the objects

        public void SerializeContainers()
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"" + _fileName, JsonConvert.SerializeObject(_containers,Formatting.Indented));
        }

        //Dserialize the .json file for loading of the data objects

        public void DeserializeContainers()
        {
            _containers = JsonConvert.DeserializeObject<Container[]>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"" + _fileName));

        }



    }

}