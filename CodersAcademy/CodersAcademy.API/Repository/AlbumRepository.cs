using CodersAcademy.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodersAcademy.API.Repository
{
    public class AlbumRepository
    {
        private MusicContext Context { get; init; }
        public AlbumRepository(MusicContext context)
        {
            Context = context;
        }

        public async Task<IList<Album>> GetAllAsync()
            => await this.Context.Albuns.ToListAsync();

    }
}
