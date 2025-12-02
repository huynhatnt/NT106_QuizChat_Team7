using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;

namespace ServerForm.Services
{
    public static class FirestoreService
    {
        private const string ProjectId = "quizchatuit";

        private static readonly Lazy<FirestoreDb> _db =
            new Lazy<FirestoreDb>(() =>
            {
                string credentialPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

                if (string.IsNullOrWhiteSpace(credentialPath))
                    throw new Exception("GOOGLE_APPLICATION_CREDENTIALS chưa được cấu hình (trỏ đến file firebase-key.json).");
                return FirestoreDb.Create(ProjectId);
            });

        public static FirestoreDb Db => _db.Value;
    }
}
