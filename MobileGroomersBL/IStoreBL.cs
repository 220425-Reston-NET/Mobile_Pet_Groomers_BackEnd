namespace MobileGroomersBL
{
    public interface IStoreBL
    {
       /// <summary>
       /// will display the list of products from a store
       /// </summary>
       /// <param name="p_sId"></param>
       /// <returns></returns>
        public List<Product> ViewStoreInvetory(int p_sId);
    }
}