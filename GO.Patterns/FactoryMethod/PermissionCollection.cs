using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO.Patterns.FactoryMethod
{
    public class PermissionCollection : ICollection<Permission>
    {
        public int Count => _permissions.Count;

        public bool IsReadOnly => false;

        private List<Permission> _permissions = null;

        public PermissionCollection()
        {
            _permissions = new List<Permission>();
        }

        public PermissionCollection(IList<Permission> permissions)
        {
            _permissions = permissions.ToList();
        }

        public void Add(Permission item)
        {
            _permissions.Add(item);
        }

        public void Clear()
        {
            _permissions.Clear();
        }

        public bool Contains(Permission item)
        {
            return _permissions.Contains(item);
        }

        public void CopyTo(Permission[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Permission> GetEnumerator()
        {
            return _permissions.GetEnumerator();
        }

        public bool Remove(Permission item)
        {
            return _permissions.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
