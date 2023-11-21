using System.Collections;
using System.Data.SqlClient;

namespace Library.ManagedConnectivity
{
    public class ManagedReaderFields : IEnumerable<ManagedField>
    {
        private SqlDataReader _reader;

        public ManagedReaderFields(SqlDataReader reader)
        {
            _reader = reader;
        }
        public IEnumerator<ManagedField> GetEnumerator()
        {
            for (int i = 0; i < _reader.FieldCount; i++)
            {
                yield return new ManagedField(_reader.GetName(i), _reader.GetFieldType(i));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }
    }
}
