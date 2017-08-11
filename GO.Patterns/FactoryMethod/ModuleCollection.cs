using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public class ModuleCollection : ICollection<Module>
    {
        public int Count => _modules.Count;

        public bool IsReadOnly => false;

        private List<Module> _modules;

        public ModuleCollection()
        {
            _modules = new List<Module>();
        }

        public ModuleCollection(IList<Module> modules)
        {
            _modules = modules.ToList();
        }

        public void Add(Module item)
        {
            _modules.Add(item);
        }

        public void Clear()
        {
            _modules.Clear();
        }

        public bool Contains(Module item)
        {
            return _modules.Contains(item);
        }

        public void CopyTo(Module[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Module> GetEnumerator()
        {
            return _modules.GetEnumerator();
        }

        public bool Remove(Module item)
        {
            return _modules.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
