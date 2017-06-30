using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Security.Principal;

namespace GigHub
{
    public static class ExtensionsMethods
    {
        public static string GetUserFirstName( this IIdentity identity )
        {
            if (identity == null)
            {
                throw new ArgumentNullException( nameof( identity ) );
            }
            var userId = identity.GetUserId();
            var currentUser = new ApplicationDbContext().Users.FirstOrDefault( u => u.Id == userId );
            if (currentUser == null)
                return identity.GetUserName();

            return currentUser.FullName;
        }
    }
}