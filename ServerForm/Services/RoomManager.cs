using Google.Cloud.Firestore;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerForm.Services
{
    public class RoomManager
    {
        private readonly FirestoreDb _db;

        public RoomManager()
        {
            _db = FirestoreService.Db;
        }

        private CollectionReference Rooms => _db.Collection("rooms");

        public async Task<string> CreateRoomAsync(string hostId, string title, string quizId)
        {
            var newRoom = new Room
            {
                RoomId = Guid.NewGuid().ToString("N").Substring(0, 6),
                HostId = hostId,
                Title = title,
                QuizId = quizId,
                Players = new Dictionary<string, Player>(),
                Questions = new List<Question>(),
                State = QuizState.Waiting
            };

            await Rooms.Document(newRoom.RoomId).SetAsync(newRoom);

            return newRoom.RoomId;
        }

        public async Task AddPlayerAsync(string roomId, Player player)
        {
            await Rooms.Document(roomId).UpdateAsync($"Players.{player.Uid}", player);
        }

        public async Task SetStateAsync(string roomId, QuizState state)
        {
            await Rooms.Document(roomId).UpdateAsync("State", state);
        }

        public async Task UpdateCurrentQuestionAsync(string roomId, int index)
        {
            await Rooms.Document(roomId).UpdateAsync("CurrentQuestionIndex", index);
        }
    }
}
