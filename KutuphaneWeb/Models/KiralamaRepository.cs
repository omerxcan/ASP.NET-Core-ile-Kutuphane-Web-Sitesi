using KutuphaneWeb.Utility;

namespace KutuphaneWeb.Models
{
    public class KiralamaRepository : Repository<Kiralama>, IKiralamaRepository
    {
        private UygulamaDbContext _uygulamaDbContext;
        public KiralamaRepository(UygulamaDbContext uygulamaDbcontext) : base(uygulamaDbcontext)
        {
            _uygulamaDbContext = uygulamaDbcontext;
        }

        public void Guncelle(Kiralama kiralama)
        {
            _uygulamaDbContext.Update(kiralama);
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }
    }
}
