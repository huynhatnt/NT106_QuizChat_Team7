using Google.Cloud.Firestore;

namespace QuizShared.Models
{
    [FirestoreData]
    public class Player
    {
        [FirestoreProperty]
        public string Uid { get; set; }

        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public int Score { get; set; }

        [FirestoreProperty]
        public string SelectedAnswer { get; set; }
    }
}
