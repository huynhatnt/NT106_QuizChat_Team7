using Google.Cloud.Firestore;
using System;

namespace ClientForm.Services
{
    public static class FirebaseService
    {
        private const string ProjectId = "quizchatuit";

        private static readonly Lazy<FirestoreDb> _db =
            new Lazy<FirestoreDb>(() =>
            {
                string path = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
                if (string.IsNullOrWhiteSpace(path))
                    throw new Exception("GOOGLE_APPLICATION_CREDENTIALS chưa được cấu hình (trỏ đến file firebase-key.json).");

                return FirestoreDb.Create(ProjectId);
            });

        public static FirestoreDb Db
        {
            get { return _db.Value; }
        }
    }
}
