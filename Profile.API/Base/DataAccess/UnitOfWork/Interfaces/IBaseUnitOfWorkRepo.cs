namespace Profile.API.Base.DataAccess.UnitOfWork.Interfaces
{
    public interface IBaseUnitOfWorkRepo
    {
        TSrv Repository<TSrv>() where TSrv : class;

        Task<int> SaveChanges();
    }
}
