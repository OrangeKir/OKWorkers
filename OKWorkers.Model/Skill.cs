namespace OKWorkers.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Навык
    /// </summary>
    public abstract class Skill
    {
        /// <summary> ctor </summary>
        public Skill()
        {
            Id = Guid.NewGuid();
        }
        
        /// <summary> Id </summary>
        public Guid Id { get; private set; }

        /// <summary> Значение </summary>
        [NotMapped]
        public virtual decimal Value { get; }
    }
}