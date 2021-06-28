namespace OKWorkers.Model
{
    /// <summary>
    /// Навыки в дизайне
    /// </summary>
    public class DesignSkill : Skill
    {
        /// <summary> Рисовательство </summary>
        public decimal Drawing { get; set; }
        
        /// <summary> Воображение </summary>
        public decimal Imagination { get; set; }

        /// <inheritdoc />
        public override decimal Value => Drawing + Imagination;

    }
}