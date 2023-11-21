using System.Collections;
using System.Data.SqlClient;

namespace Library.ManagedConnectivity
{
    public class ManagedReader : IEnumerable<ManagedReaderRow>, IDisposable
    {
        public SqlDataReader NativeReader { get; private set; }

        private readonly SqlCommand _sqlCommand;
        private ManagedReaderFields? _cachedFields = null;

        public ManagedReader(string sqlText, SqlConnection sqlConnection)
        {
            _sqlCommand = new SqlCommand(sqlText, sqlConnection);
            NativeReader = _sqlCommand.ExecuteReader();
        }

        public void Dispose()
        {
            try
            {
                _sqlCommand.Dispose();
            }
            catch { }
        }

        public ManagedReaderFields Fields
        {
            get
            {
                _cachedFields ??= new ManagedReaderFields(NativeReader);
                return _cachedFields;
            }
        }

        public IEnumerator<ManagedReaderRow> GetEnumerator()
        {
            while (NativeReader.Read())
            {
                yield return new ManagedReaderRow(NativeReader);
            }
            NativeReader.Close();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
