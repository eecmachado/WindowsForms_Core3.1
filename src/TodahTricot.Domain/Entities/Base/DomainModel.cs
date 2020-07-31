namespace TodahTricot.Domain.Entities.Base
{
    public class DomainModel : IDomainModel
    {
        public int Id { get; set; }

        public bool Novo { get; protected set; }
    }
}
