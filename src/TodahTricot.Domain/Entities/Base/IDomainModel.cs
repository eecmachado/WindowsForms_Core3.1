namespace TodahTricot.Domain.Entities.Base
{
    public interface IDomainModel
    {
        int Id { get; set; }

        bool Novo { get; }
    }
}
