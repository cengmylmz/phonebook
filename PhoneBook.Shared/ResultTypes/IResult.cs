﻿namespace PhoneBook.Shared.ResultTypes
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
