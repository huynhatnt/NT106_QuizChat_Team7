using Google.Cloud.Firestore;
using System.Threading.Tasks;

namespace ClientForm.Services
{
    public class UserService
    {
        private readonly FirestoreDb _db = FirebaseService.Db;

        public Task SaveUserAsync(string uid, string email)
        {
            return _db.Collection("users").Document(uid)
                .SetAsync(new
                {
                    Uid = uid,
                    Email = email
                });
        }
    }
}
