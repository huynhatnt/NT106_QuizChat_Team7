using Google.Cloud.Firestore;
using QuizShared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientForm.Services
{
    public class QuizService
    {
        private readonly FirestoreDb _db = FirebaseService.Db;

        public async Task<List<Question>> LoadQuestionsAsync(string quizId)
        {
            if (string.IsNullOrEmpty(quizId))
                return new List<Question>();

            var doc = await _db.Collection("quizzes").Document(quizId).GetSnapshotAsync();
            if (!doc.Exists)
                return new List<Question>();

            var quiz = doc.ConvertTo<Quiz>();
            return quiz.Questions ?? new List<Question>();
        }

        public Task SubmitAnswerAsync(string roomId, string uid, string answer)
        {
            return _db.Collection("rooms")
                      .Document(roomId)
                      .UpdateAsync($"Players.{uid}.SelectedAnswer", answer);
        }
    }
}
