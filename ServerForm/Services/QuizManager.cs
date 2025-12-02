using Google.Cloud.Firestore;
using QuizShared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerForm.Services
{
    public class QuizManager
    {
        private readonly FirestoreDb _db;

        public QuizManager()
        {
            _db = FirestoreService.Db;
        }

        private CollectionReference Rooms => _db.Collection("rooms");

        public async Task StartQuizAsync(string roomId)
        {
            await Rooms.Document(roomId).UpdateAsync(new Dictionary<string, object>
            {
                { "State", QuizState.Starting },
                { "CurrentQuestionIndex", 0 }
            });
        }

        public async Task NextQuestionAsync(string roomId, int nextIndex)
        {
            await Rooms.Document(roomId).UpdateAsync(new Dictionary<string, object>
            {
                { "State", QuizState.InQuestion },
                { "CurrentQuestionIndex", nextIndex }
            });
        }

        public async Task ShowResultAsync(string roomId)
        {
            await Rooms.Document(roomId).UpdateAsync("State", QuizState.ShowingResult);
        }

        public async Task FinishQuizAsync(string roomId)
        {
            await Rooms.Document(roomId).UpdateAsync("State", QuizState.Finished);
        }
    }
}
