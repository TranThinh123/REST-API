namespace BuderDinner.Contracts.Authentication;

public record AuthenticationRespone(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string token
);
