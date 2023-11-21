using System.Collections;
using System.Data.SqlClient;

namespace Library.ManagedConnectivity
{
    public class ManagedReaderRow : IEnumerable<object>
    {
        private readonly object[] _objects;

        public ManagedReaderRow(SqlDataReader nativeReader)
        {
            _objects = new object[nativeReader.FieldCount];

            for (int i = 0; i < nativeReader.FieldCount; i++)
            {
                _objects[i] = nativeReader[i];
            }
        }

        public IEnumerator<object> GetEnumerator()
        {
            foreach (var o in _objects)
            {
                yield return o;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _objects.GetEnumerator();
        }
    }
}
