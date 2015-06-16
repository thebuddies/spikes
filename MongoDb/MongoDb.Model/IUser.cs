using System.Collections.Generic;

namespace MongoDb.Model
{
    public interface IUser<T> : IEntity<T>
    {
        string Username { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        int Age { get; set; }

        ICollection<string> Address { get; set; }
    }
}