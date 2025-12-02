using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace QuizShared.Models
{
    [FirestoreData]
    public class Quiz
    {
        [FirestoreDocumentId]
        public string QuizId { get; set; }

        [FirestoreProperty]
        public string Title { get; set; }

        [FirestoreProperty]
        public List<Question> Questions { get; set; }

        public Quiz()
        {
            Questions = new List<Question>();
        }
    }
}
