using app.Models;
using app.Data;

namespace app.Repository
{
    public class StarRepository : BaseRepository<Star, RDIDBContext>
    {
        public StarRepository(RDIDBContext context) : base(context)
        {

        }
                // methods specific to the repository here in the future

    }
}
