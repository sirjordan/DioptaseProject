using System;
using System.Linq;

namespace ProgramDioptase.Interfaces.DatabaseManager
{
    public interface IStatisticManager
    {
        string MovieOrdersCount { get; }

        string GameOrdersCount { get; }

        string MusicOrdersCount { get; }
    }
}