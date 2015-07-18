using MongoDb.Model.Base;

namespace MongoDb.Model
{
    public class User : EntityBase<string>
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}