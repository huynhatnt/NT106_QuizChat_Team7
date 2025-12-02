using Google.Cloud.Firestore;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerForm.Services
{
    public class QuizRepository
    {
        private readonly FirestoreDb _db;
        private CollectionReference Quizzes => _db.Collection("quizzes");

        public QuizRepository()
        {
            _db = FirestoreService.Db;
        }

        public async Task<string> CreateQuizAsync(string title, List<Question> questions)
        {
            string quizId = Guid.NewGuid().ToString("N").Substring(0, 8);

            var quiz = new Quiz
            {
                QuizId = quizId,
                Title = title,
                Questions = questions
            };

            await Quizzes.Document(quizId).SetAsync(quiz);

            return quizId;
        }

        // Lấy full Quiz để server & client dùng chung
        public async Task<List<Quiz>> GetAllQuizAsync()
        {
            var result = new List<Quiz>();

            var snaps = await Quizzes.GetSnapshotAsync();
            foreach (var doc in snaps.Documents)
            {
                var quiz = doc.ConvertTo<Quiz>();
                if (string.IsNullOrEmpty(quiz.QuizId))
                    quiz.QuizId = doc.Id;

                result.Add(quiz);
            }

            return result;
        }

        public async Task<Quiz> GetQuizAsync(string quizId)
        {
            var snap = await Quizzes.Document(quizId).GetSnapshotAsync();
            if (!snap.Exists) return null;

            var quiz = snap.ConvertTo<Quiz>();
            if (string.IsNullOrEmpty(quiz.QuizId))
                quiz.QuizId = snap.Id;
            return quiz;
        }
    }
}
