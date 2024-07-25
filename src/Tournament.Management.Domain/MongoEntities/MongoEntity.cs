using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Tournament.Management.Domain.MongoEntities;

public abstract class MongoEntity
{
    [JsonIgnore]
    [BsonIgnoreIfNull]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }

    [BsonIgnore]
    [JsonPropertyName("id")]
    public virtual string IdEntity { get => Id.ToString() ?? string.Empty; set => Id = new ObjectId(value); }
}
