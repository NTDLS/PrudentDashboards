using NTDLS.Persistence;

namespace Library.Models
{
    public class DataSourceViewModelCollection : List<DataSourceViewModel>
    {
        public static DataSourceViewModelCollection Load()
        {
            return ApplicationData.LoadFromDisk(Constants.TitleCaption, new DataSourceViewModelCollection(), Utility.GetEncryptionProvider());
        }

        public void Save()
        {
            ApplicationData.SaveToDisk(Constants.TitleCaption, this, Utility.GetEncryptionProvider());
        }
    }
}
