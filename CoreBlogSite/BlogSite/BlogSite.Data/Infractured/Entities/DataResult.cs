// Ekleme silme işlemleri buradan sonuçlarını görebiliriz
namespace BlogSite.Data.Infractured.Entities
{
    class DataResult
    {
        public DataResult(bool isSucceed, string message)
        {
            IsSucceed = isSucceed;
            Message = message;
        }

        public bool IsSucceed { get; set; }
        public string Message { get; set; }

    }
}
