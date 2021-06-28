namespace OKWorkers.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Тестируемый кандидат
    /// </summary>
    public class Candidate
    {
        /// <summary> ctor </summary>
        /// <param name="nicName">Ник</param>
        public Candidate(string nicName)
        {
            Id = Guid.NewGuid();
            NicName = nicName;
            Skills = new List<Skill>();
        }
        /// <summary> Id </summary>
        public Guid Id { get; private set; }
        
        /// <summary> Ник </summary>
        public string NicName { get; private set; }

        /// <summary> Список навыков </summary>
        public List<Skill> Skills { get; set; }
    }
}