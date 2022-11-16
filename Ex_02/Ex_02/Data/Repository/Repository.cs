using Ex_02.Data.Entity;

namespace Ex_02.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            
            this.context = context;
        }


        public IEnumerable<Plantas> GetProducts()   
        {
            return this.context.plantas.OrderBy(p => p.Nombre);
        }

        public Plantas GetProduct(int Id)
        {

            return this.context.plantas.Find(Id);
        }

        public void AddProduct(Plantas product)  //"product"  es una variable
        {

            this.context.plantas.Add(product); //añadir en la tabla productos

        }

        public void UpdateProduct(Plantas product)
        {

            this.context.plantas.Update(product);

        }

        public void RemoveProduct(Plantas product)
        {

            this.context.plantas.Remove(product);
        }

        public async Task<bool> SaveAllAsync()
        {

            return await this.context.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return this.context.plantas.Any(p => p.Id == id);  ///controla el id
        }





    }
}
