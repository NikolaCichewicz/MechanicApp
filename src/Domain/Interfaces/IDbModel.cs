namespace MechanicApp.Domain.Interfaces;

public interface IDbModel<TId>
{
    public TId Id { get; set; }
}
