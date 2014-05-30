using System;
using System.Collections.Generic;
using System.Linq;
using ProgramDioptase.Interfaces.ItemDescription;

namespace ProgramDioptase.Interfaces.DatabaseManager
{
    public interface IFileManager
    {
        IList<T> GetItems<T>(Uri baseDirectory) where T : IDataInitializable, new();

        IList<string> ReadItemsNames(Uri baseDirectory);

        Uri GetBaseDirectory(string type);

        void InitializeObjectData<T>(IList<string> itemNames, Uri baseDirectory, IList<T> allItems)
            where T : IDataInitializable, new();

        string GetOrdersCount(Uri baseDirectory);

        IList<string> GetUserOrders(string clientName);

        void MakeClientOrder(string clientName, IList<IDescription> catalogItems);
    }
}