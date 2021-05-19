using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL {
    public interface ILibraryService {
        //konyvek felvetele, modositasa, torlese, keresese
        Task<IEnumerable<Konyv>> GetKonyvAsync(string cim, string iro , string kolcs);
        Task<Konyv> GetKonyvAsyncById(int id );
        Task<IEnumerable<Konyv>> GetKonyvekAsync();
        Task<Konyv> InsertKonyvAsync(Konyv newKonyv);
        Task UpdateKonyvAsync(int konyvId, Konyv updateKonyv);
        Task DeleteKonyvAsync(int konyvId);

        //olvasok adatai
        Task<IEnumerable<Olvaso>> GetOlvasoAsync(string nev);
        Task<Olvaso> GetOlvasoAsyncById(int id);
        Task<IEnumerable<Olvaso>> GetOlvasokAsync();
        Task<Olvaso> InsertOlvasoAsync(Olvaso newOlvaso);
        Task UpdateOlvasoAsync(int olvasoId, Olvaso updateOlvaso);
        Task DeleteOlvasoAsync(int olvasoId);

        //kolcsonzesek
        Task<IEnumerable<Kolcsonzes>> GetKolcsonzesAsync(int Id);
        Task<Kolcsonzes> GetKolcsonzesAsyncById(int kolcsonzesId);
        Task<IEnumerable<Kolcsonzes>> GetKolcsonzesekAsync();
        Task<Kolcsonzes> InsertKolcsonzesAsync(Kolcsonzes newKolcsonzes);
        Task DeleteKolcsonzesAsync(int kolcsonzesId);

    }
}
