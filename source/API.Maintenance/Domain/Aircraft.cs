namespace API.Maintenance.Domain
{
    using System;

    public class Aircraft
    {
        public Aircraft(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
