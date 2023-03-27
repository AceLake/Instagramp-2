using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PostModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ImgURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public PostModel()
        {
        }

        public PostModel(string id, string imgURL, string title, string description)
        {
            Id = id;
            ImgURL = imgURL;
            Title = title;
            Description = description;
        }
    }
}
