using System.Collections;
using System.Data.SqlClient;

namespace Library.ManagedConnectivity
{
    public class ManagedReaderRow : IEnumerable<object>
    {
        private readonly object[] _objects;
        private readonly SqlDataReader _nativeReader;

        public ManagedReaderRow(SqlDataReader nativeReader)
        {
            _nativeReader = nativeReader;
            _objects = new object[nativeReader.FieldCount];

            for (int i = 0; i < nativeReader.FieldCount; i++)
            {
                _objects[i] = nativeReader[i];
            }
        }

        public decimal AsDecimal(string fieldName, decimal defaultValue) => (_nativeReader[fieldName] as decimal?) ?? defaultValue;
        public decimal? AsDecimal(string fieldName) => _nativeReader[fieldName] as decimal?;

        public double AsDouble(string fieldName, double defaultValue) => (_nativeReader[fieldName] as double?) ?? defaultValue;
        public double? AsDouble(string fieldName) => _nativeReader[fieldName] as double?;

        public string AsString(string fieldName, string defaultValue) => (_nativeReader[fieldName] as string) ?? defaultValue;
        public string? AsString(string fieldName) => _nativeReader[fieldName] as string;

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
