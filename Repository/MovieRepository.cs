using app.Models;
using app.Data;

namespace app.Repository
{
    public class MovieRepository : BaseRepository<Movie, RDIDBContext>
    {
        public MovieRepository(RDIDBContext context) : base(context)
        {

        }
        // methods specific to the repository here in the future
    }
}
