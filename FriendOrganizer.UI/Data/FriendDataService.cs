using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        // when it was used as fake memory data
        //public IEnumerable<Friend> GetAll()
        //{
        //    // TODO: Load data from real database
        //    yield return new Friend { FirstName = "Thomas", LastName = "Huber" };
        //    yield return new Friend { FirstName = "Andreas", LastName = "Boehler" };
        //    yield return new Friend { FirstName = "Julia", LastName = "Huber" };
        //    yield return new Friend { FirstName = "Chrissi", LastName = "Egin" };
        //}

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Friend>> GetAllAsync()
        {
            using( var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }    
        }
    }
}
