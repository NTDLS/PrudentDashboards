using NTDLS.Persistence;

namespace Library.Models
{
    public class ChartModelCollection : List<ChartModel>
    {
        public static ChartModelCollection Load()
        {
            return ApplicationData.LoadFromDisk(Constants.TitleCaption, new ChartModelCollection(), Utility.GetEncryptionProvider());
        }

        public void Save()
        {
            ApplicationData.SaveToDisk(Constants.TitleCaption, this, Utility.GetEncryptionProvider());
        }
    }
}
