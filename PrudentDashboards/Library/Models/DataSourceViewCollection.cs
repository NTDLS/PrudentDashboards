using NTDLS.Persistence;

namespace Library.Models
{
    public class DataSourceViewCollection : List<DataSourceView>
    {
        public static DataSourceViewCollection Load()
        {
            return ApplicationData.LoadFromDisk(Constants.TitleCaption, new DataSourceViewCollection(), Utility.GetEncryptionProvider());
        }

        public void Save()
        {
            ApplicationData.SaveToDisk(Constants.TitleCaption, this, Utility.GetEncryptionProvider());
        }
    }
}
