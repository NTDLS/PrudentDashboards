using NTDLS.Persistence;

namespace Library.Models
{
    public class DataSourceModelCollection : List<DataSourceModel>
    {
        public static DataSourceModelCollection Load()
        {
            return ApplicationData.LoadFromDisk(Constants.TitleCaption, new DataSourceModelCollection(), Utility.GetEncryptionProvider());
        }

        public void Save()
        {
            ApplicationData.SaveToDisk(Constants.TitleCaption, this, Utility.GetEncryptionProvider());
        }
    }
}
