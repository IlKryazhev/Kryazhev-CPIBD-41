using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLiner
{
    class PierCollection
    {
        readonly Dictionary<string, Pier<Vehicle>> _pierStages;
        public List<string> Keys => _pierStages.Keys.ToList();
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        

        public PierCollection(int pictureWidth, int pictureHeight)
        {
                _pierStages = new Dictionary<string, Pier<Vehicle>>();
                _pictureWidth = pictureWidth;
                _pictureHeight = pictureHeight;
        }

        public void AddPier(string name)
        {
            _pierStages.Add(name, new Pier<Vehicle>(_pictureWidth, _pictureHeight));
        }

        public void DelPier(string name)
        {
            _pierStages.Remove(name);
        }

        public Pier<Vehicle> this[string ind]
        {
            get { return _pierStages.GetValueOrDefault(ind); }
        }
    }
}
