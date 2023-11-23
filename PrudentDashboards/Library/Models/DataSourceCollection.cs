using NTDLS.Persistence;

namespace Library.Models
{
    public class DataSourceCollection : List<DataSource>
    {
        public static DataSourceCollection Load()
        {
            return ApplicationData.LoadFromDisk(Constants.TitleCaption, new DataSourceCollection(), Utility.GetEncryptionProvider());
        }

        public void Save()
        {
            ApplicationData.SaveToDisk(Constants.TitleCaption, this, Utility.GetEncryptionProvider());
        }
    }
}
