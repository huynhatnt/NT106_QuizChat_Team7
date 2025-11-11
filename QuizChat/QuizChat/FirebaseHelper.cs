using Google.Cloud.Firestore;
using System;
using System.Text;
using System.Threading.Tasks;

namespace QuizChatApp
{
    public class FirebaseHelper
    {
        private static FirestoreDb firestoreDb;

        public class AuthResult
        {
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
            public string Email { get; set; }
            public string Uid { get; set; }
            public string Username { get; set; }
        }

        public static void InitializeFirebase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "firebase-config.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            firestoreDb = FirestoreDb.Create("quizchat-6d2ae"); // thay nếu projectId khác
        }

        public static async Task<AuthResult> RegisterUserAsync(string username, string email, string password)
        {
            var result = new AuthResult { Success = false };
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    result.ErrorMessage = "Vui lòng nhập đầy đủ tên, email và mật khẩu.";
                    return result;
                }

                var docRef = firestoreDb.Collection("users").Document(email);
                var snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    result.ErrorMessage = "Email đã tồn tại.";
                    return result;
                }

                var user = new
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    CreatedAt = Timestamp.GetCurrentTimestamp()
                };

                await docRef.SetAsync(user);

                result.Success = true;
                result.Email = email;
                result.Uid = email;
                result.Username = username;
                return result;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                return result;
            }
        }

        public static async Task<AuthResult> LoginUserAsync(string email, string password)
        {
            var result = new AuthResult { Success = false };
            try
            {
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    result.ErrorMessage = "Vui lòng nhập email và mật khẩu.";
                    return result;
                }

                var docRef = firestoreDb.Collection("users").Document(email);
                var snapshot = await docRef.GetSnapshotAsync();
                if (!snapshot.Exists)
                {
                    result.ErrorMessage = "Tài khoản không tồn tại.";
                    return result;
                }

                string storedPassword = null;
                if (snapshot.ContainsField("Password"))
                    storedPassword = snapshot.GetValue<string>("Password");

                if (string.IsNullOrEmpty(storedPassword))
                {
                    result.ErrorMessage = "Dữ liệu mật khẩu không hợp lệ.";
                    return result;
                }

                if (storedPassword != password)
                {
                    result.ErrorMessage = "Sai mật khẩu.";
                    return result;
                }

                string username = snapshot.ContainsField("Username") ? snapshot.GetValue<string>("Username") : null;
                result.Success = true;
                result.Email = email;
                result.Uid = email;
                result.Username = username;
                return result;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                return result;
            }
        }
    }
}