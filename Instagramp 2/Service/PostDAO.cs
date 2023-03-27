using ClassLibrary;
using MongoDB.Driver;

namespace Instagramp_2.Service
{
    public class PostDAO
    {
        private readonly IMongoCollection<PostModel> _posts;

        public PostDAO()
        {
            var client = new MongoClient("mongodb+srv://Ace:squirty115@cluster0.og5dfyn.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("insta-gramp-2");
            _posts = database.GetCollection<PostModel>("posts");
        }

        public async Task Create(PostModel post)
        {
            await _posts.InsertOneAsync(post);
        }

        public async Task<PostModel> GetById(string id)
        {
            var filter = Builders<PostModel>.Filter.Eq(p => p.Id, id);
            return await _posts.Find(filter).FirstOrDefaultAsync();
        }

        public List<PostModel> GetAll()
        {
            return _posts.Find(_ => true).ToList();
        }

        public async Task Update(string id, PostModel post)
        {
            var filter = Builders<PostModel>.Filter.Eq(p => p.Id, id);
            await _posts.ReplaceOneAsync(filter, post);
        }

        public async Task Delete(string id)
        {
            var filter = Builders<PostModel>.Filter.Eq(p => p.Id, id);
            await _posts.DeleteOneAsync(filter);
        }
    }
}

