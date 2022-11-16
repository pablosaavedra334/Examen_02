using Ex_02.Data.Entity;
using System.Collections.Generic;

namespace Ex_02.Data.Repository
{
    public interface IRepository
    {

        IEnumerable<Plantas> GetProducts();

        Plantas GetProduct(int Id);

        void AddProduct(Plantas product);

        void UpdateProduct(Plantas product);

        void RemoveProduct(Plantas product);

        Task<bool> SaveAllAsync();

        bool ProductExists(int id);










    }
}
