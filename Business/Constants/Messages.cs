using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProducCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProducNameAlReadyExists = "Bu isimden daha önce kayıt oldu";
        public static string CategoryLimitExcedet = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
