using AutoMapper;
using LibraryDAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBLL {
    public class LibraryService : ILibraryService {
        private readonly KonyvtarContext ctx;
        private readonly IMapper mapper;

        public LibraryService(KonyvtarContext context, IMapper mpr) {
            ctx = context;
            mapper = mpr;
        }
        //konyvek
        public async Task DeleteKonyvAsync(int konyvId) {
            ctx.Konyvek.Remove(new LibraryDAL.Entities.Konyv { Id = konyvId });
            try {
                await ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (ctx.Konyvek.SingleOrDefault(k => k.Id == konyvId) == null) {
                    throw new EntityNotFoundException("Nem található könyv");
                }
                else throw;
            }
        }
        public async Task<Konyv> GetKonyvAsyncById(int id) {
            return await mapper.ProjectTo<Konyv>(ctx.Konyvek
               .Where(k=> k.Id == id)
               ).SingleOrDefaultAsync() ?? throw new EntityNotFoundException("Nem található könyv");
        }
        public async Task<IEnumerable<Konyv>> GetKonyvAsync(string cim, string iro, string kolcs) {
            bool kolcsonzes=false;
            if (!string.IsNullOrEmpty(kolcs) && kolcs.Equals("true")) kolcsonzes = true;
            return await mapper.ProjectTo<Konyv>(
                ctx.Konyvek
               .Where(k => (cim == null || k.Cim.Equals(cim)))
               .Where(k => (iro == null || k.Iro.Equals(iro)))
               .Where(k=>(kolcs==null || k.Kolcsonozve.Equals(kolcsonzes)))
               ).ToListAsync() ?? throw new EntityNotFoundException("Nem található könyv");
        }
        public async Task<IEnumerable<Konyv>> GetKonyvekAsync() {
            return await mapper.ProjectTo<Konyv>(ctx.Konyvek).ToListAsync();
        }
        public async Task<Konyv> InsertKonyvAsync(Konyv newKonyv) {
            var uj = mapper.Map<LibraryDAL.Entities.Konyv>(newKonyv);
            ctx.Konyvek.Add(uj);
            await ctx.SaveChangesAsync();
            return await GetKonyvAsyncById(uj.Id);
        }
        public async Task UpdateKonyvAsync(int konyvId, Konyv updateKonyv) {
            var konyv = mapper.Map<LibraryDAL.Entities.Konyv>(updateKonyv);
            konyv.Id = konyvId;
            var entry = ctx.Attach(konyv);
            entry.State = EntityState.Modified;
            try {
                await ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if ((await ctx.Konyvek.SingleOrDefaultAsync(k => k.Id == konyvId)) == null) throw new EntityNotFoundException("Nem található könyv");
                else throw;
            }
        }

        //olvasok
        public async Task DeleteOlvasoAsync(int olvasoId) {
            ctx.Olvasok.Remove(new LibraryDAL.Entities.Olvaso { Id = olvasoId });
            try {
                await ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (ctx.Olvasok.SingleOrDefault(k => k.Id == olvasoId) == null) {
                    throw new EntityNotFoundException("Nem található olvasó");
                }
                else throw;
            }
        }
        public async Task<IEnumerable<Olvaso>> GetOlvasoAsync(string nev) {
            return await mapper.ProjectTo<Olvaso>(ctx.Olvasok.Where(k => k.Nev.Equals(nev))).ToListAsync() ?? throw new EntityNotFoundException("Nem található olvasó");
        }
        public async Task<Olvaso> GetOlvasoAsyncById(int id) {
            return await mapper.ProjectTo<Olvaso>(ctx.Olvasok.Where(k=>k.Id==id)
                                                        ).SingleOrDefaultAsync() ?? throw new EntityNotFoundException("Nem található olvasó");
        }
        public async Task<IEnumerable<Olvaso>> GetOlvasokAsync() {
            var olvasok = await mapper.ProjectTo<Olvaso>(ctx.Olvasok).ToListAsync();
            return olvasok;
        }
        public async Task<Olvaso> InsertOlvasoAsync(Olvaso newOlvaso) {
            var uj = mapper.Map<LibraryDAL.Entities.Olvaso>(newOlvaso);
            ctx.Olvasok.Add(uj);
            await ctx.SaveChangesAsync();
            return await GetOlvasoAsyncById(uj.Id);
        }
        public async Task UpdateOlvasoAsync(int olvasoID, Olvaso updateOlvaso) {
            var olvaso = mapper.Map<LibraryDAL.Entities.Olvaso>(updateOlvaso);
            olvaso.Id = olvasoID;
            var entry = ctx.Attach(olvaso);
            entry.State = EntityState.Modified;
            try {
                await ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if ((await ctx.Olvasok.SingleOrDefaultAsync(k => k.Id == olvasoID)) == null) throw new EntityNotFoundException("Nem található olvaso");
                else throw;
            }
        }

        //kolcsonzesek
        public async Task DeleteKolcsonzesAsync(int kolcsonzesId) {
            ctx.Kolcsonzesek.Remove(new LibraryDAL.Entities.Kolcsonzes { Id = kolcsonzesId });
            try {
                await ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (ctx.Olvasok.SingleOrDefault(k => k.Id == kolcsonzesId) == null) {
                    throw new EntityNotFoundException("Nem található kölcsönzés");
                }
                else throw;
            }
        }
        public async Task<IEnumerable<Kolcsonzes>> GetKolcsonzesAsync(int id) {
            return await mapper.ProjectTo<Kolcsonzes>(ctx.Kolcsonzesek.Where(k => k.OlvasoId == id)).ToListAsync() ?? throw new EntityNotFoundException("Nem található kölcsönzés");
        }
        public async Task<IEnumerable<Kolcsonzes>> GetKolcsonzesekAsync() {
            var kolcsonzes = await mapper.ProjectTo<Kolcsonzes>(ctx.Kolcsonzesek).ToListAsync();
            return kolcsonzes;
        }
        public async Task<Kolcsonzes> GetKolcsonzesAsyncById(int id) {
            return await mapper.ProjectTo<Kolcsonzes>(ctx.Kolcsonzesek.Where(k => k.Id == id)).SingleOrDefaultAsync() ?? throw new EntityNotFoundException("Nem található kölcsönzés");
        }
        public async Task<Kolcsonzes> InsertKolcsonzesAsync(Kolcsonzes newKolcsonzes) {
            var uj = mapper.Map<LibraryDAL.Entities.Kolcsonzes>(newKolcsonzes);
            ctx.Kolcsonzesek.Add(uj);
            await ctx.SaveChangesAsync();
            var k = ctx.Konyvek.Find(uj.KonyvId);
            k.KolcsonzesId = uj.Id;
            k.Kolcsonozve = true;
            await ctx.SaveChangesAsync();
            return await GetKolcsonzesAsyncById(uj.Id);
        }
    }
}
