namespace FMS.Data.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork GetInstance();
        IUnitOfWork GetReadonlyInstance();
    }
}
