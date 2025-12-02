using Google.Cloud.Firestore;
using QuizShared.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClientForm.Services
{
    public class RoomService
    {
        private readonly FirestoreDb _db = FirebaseService.Db;

        private FirestoreChangeListener _listener;

        public async Task<List<Room>> GetRoomsAsync()
        {
            List<Room> result = new List<Room>();

            QuerySnapshot snap = await _db.Collection("rooms").GetSnapshotAsync();
            foreach (var doc in snap.Documents)
            {
                result.Add(doc.ConvertTo<Room>());
            }

            return result;
        }

        public Task JoinRoomAsync(string roomId, Player player)
        {
            return _db.Collection("rooms")
                .Document(roomId)
                .UpdateAsync($"Players.{player.Uid}", player);
        }

        public void ListenRoom(string roomId, Action<Room> onUpdate)
        {
            DocumentReference docRef = _db.Collection("rooms").Document(roomId);

            _listener = docRef.Listen(snapshot =>
            {
                if (snapshot == null || !snapshot.Exists)
                    return;

                Room r = snapshot.ConvertTo<Room>();
                onUpdate(r);
            });
        }

        public void Stop()
        {
            if (_listener != null)
            {
                _listener.StopAsync(CancellationToken.None)
                         .GetAwaiter()
                         .GetResult();

                _listener = null;
            }
        }
    }
}
