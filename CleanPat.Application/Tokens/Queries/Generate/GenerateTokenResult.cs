using CleanPat.Domain.Users;

namespace CleanPat.Application.Authentication.Queries.Login;

public record GenerateTokenResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);