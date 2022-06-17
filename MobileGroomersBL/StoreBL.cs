using MobileGroomersBL;

namespace StoreBL
{
    public class StoreBL : IStoreBL
    {
        private IRepository<Store> _storeRepo;
        public StoreBL(IRepository<Store> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }
        public List<Product> ViewStoreInventory(int p_sId) //fixed spelling 
        {
            List<Store> listOfCurrentStore = _storeRepo.GetAll();
            foreach (Store item in listOfCurrentStore)
            {
                if (true)
                {
                    
                }
            }
            throw new NotImplementedException();
        }
    }
}