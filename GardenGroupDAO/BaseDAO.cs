namespace GardenGroupDAO
{
    public abstract class BaseDAO
    {
        public readonly MongoDB db;

        public BaseDAO()
        {
            db = MongoDB.Instance;
        }
    }
}