namespace Cypherly.Message.Contracts.Abstractions;

internal interface IResponse : IBaseMessage
{
    public bool IsSuccess { get; init; }
    public string? Error { get; init; }
}