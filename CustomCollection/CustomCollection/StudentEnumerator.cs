
using System;
using System.Collections;


namespace CustomCollection
{
    class StudentEnumerator : IEnumerator
    {
        private StudentsCollection _coll;
        private int _index;

        public StudentEnumerator(StudentsCollection coll)
        {
            _coll = coll;
            _index = -1;
        }

        public object Current { get { return _coll._s[_index]; } }

        public bool MoveNext()
        {
            _index++;

            if (_index >= _coll._s.Count)
                return false;
            else
                return true;

        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
