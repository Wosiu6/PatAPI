using CleanPat.Domain.Common;
using ErrorOr;

using Throw;

namespace CleanPat.Domain.Users;

public class User : Entity
{

    private readonly List<Guid> _reminderIds = [];

    private readonly List<Guid> _dismissedReminderIds = [];

    public string Email { get; } = null!;

    public string FirstName { get; } = null!;

    public string LastName { get; } = null!;

    public User(
        Guid id,
        string firstName,
        string lastName,
        string email)
            : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private User()
    {
    }
}