using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace QuizShared.Models
{
    [FirestoreData]
    public class Room
    {
        [FirestoreProperty]
        public string RoomId { get; set; }

        [FirestoreProperty]
        public string HostId { get; set; }

        [FirestoreProperty]
        public string Title { get; set; }

        [FirestoreProperty]
        public string QuizId { get; set; }

        [FirestoreProperty]
        public QuizState State { get; set; }

        [FirestoreProperty]
        public int CurrentQuestionIndex { get; set; }

        [FirestoreProperty]
        public Dictionary<string, Player> Players { get; set; }

        [FirestoreProperty]
        public List<Question> Questions { get; set; }

        public Room()
        {
            State = QuizState.Waiting;
            CurrentQuestionIndex = -1;

            Players = new Dictionary<string, Player>();
            Questions = new List<Question>();
        }
    }
}
