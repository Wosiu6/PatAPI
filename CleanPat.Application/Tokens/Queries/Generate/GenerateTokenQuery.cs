using CleanPat.Application.Authentication.Queries.Login;
using CleanPat.Domain.Users;

using ErrorOr;

using MediatR;

namespace CleanPat.Application.Tokens.Queries.Generate;

public record GenerateTokenQuery(
    Guid? Id,
    string FirstName,
    string LastName,
    string Email,
    List<string> Permissions,
    List<string> Roles) : IRequest<ErrorOr<GenerateTokenResult>>;