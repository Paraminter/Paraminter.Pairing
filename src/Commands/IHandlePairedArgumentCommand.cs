namespace Paraminter.Pairing.Commands;

using Paraminter.Arguments.Models;
using Paraminter.Cqs;

/// <summary>Represents a command to handle an argument that has been paired with a parameter.</summary>
/// <typeparam name="TArgumentData">The type representing data about the arguments.</typeparam>
public interface IHandlePairedArgumentCommand<out TArgumentData>
    : ICommand
    where TArgumentData : IArgumentData
{
    /// <summary>Data about the argument.</summary>
    public abstract TArgumentData ArgumentData { get; }
}
