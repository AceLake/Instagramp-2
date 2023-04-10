using ClassLibrary;
using MongoDB.Driver;
using RegisterAndLoginApp.Models;
using System.Data.SqlClient;

namespace RegisterAndLoginApp.Service
{
    public class SecurityDAO
    {
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly IMongoCollection<UserModel> _users;

        public SecurityDAO()
        {
            var client = new MongoClient("mongodb+srv://Ace:squirty115@cluster0.og5dfyn.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("insta-gramp-2");
            _users = database.GetCollection<UserModel>("users");
        }

        public async Task Create(UserModel user)
        {
            await _users.InsertOneAsync(user);
        }

        public UserModel GetById(string id)
        {
            var filter = Builders<UserModel>.Filter.Eq(u => u.Id, id);
            return _users.Find(filter).FirstOrDefault();
        }

        public UserModel GetByNameAndPassword(string username, string password)
        {
            var filter = Builders<UserModel>.Filter.Eq("username", username) &
                         Builders<UserModel>.Filter.Eq("password", password);
            return _users.Find(filter).FirstOrDefault();
        }

        public List<UserModel> GetAll()
        {
            return _users.Find(_ => true).ToList();
        }

        public void Update(string id, UserModel post)
        {
            var filter = Builders<UserModel>.Filter.Eq(u => u.Id, id);
            _users.ReplaceOne(filter, post);
        }

        public void Delete(string id)
        {
            var filter = Builders<UserModel>.Filter.Eq(u => u.Id, id);
            _users.DeleteOne(filter);
        }

        //public bool FindUserByNameAndPassword(UserModel user)
        //{
        //    bool success = false;

        //    string sqlStatement = "select * from dbo.users where Username = @username and Password = @password";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(sqlStatement, connection);

        //        command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
        //        command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                success = true;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //    return success;
        //}

    }
}
