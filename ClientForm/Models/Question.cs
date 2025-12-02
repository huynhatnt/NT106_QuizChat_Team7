using System.Collections.Generic;
using Google.Cloud.Firestore;

namespace QuizShared.Models
{
    [FirestoreData]
    public class Question
    {
        [FirestoreProperty]
        public string Text { get; set; }

        [FirestoreProperty]
        public Dictionary<string, string> Options { get; set; }

        [FirestoreProperty]
        public string CorrectAnswer { get; set; }

        [FirestoreProperty]
        public int TimeLimitSeconds { get; set; }
    }
}
