using System.Collections;
using System.Collections.Generic;

namespace CustomCollection
{
    class StudentsCollection : CollectionBase, IEnumerable
    {
        public List<Student> _s = new List<Student>();

        public void Add(object o)
        {

        }

        public IEnumerator GetEnumerator()
        {
            return _s.GetEnumerator();
        }
    }
}
