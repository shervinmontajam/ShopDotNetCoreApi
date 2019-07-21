namespace Shop.Model.DatabaseEntities.Dragon
{

    public class BreathEntity
    {
        public enum BreathType
        {
            Fire,
            Ice,
            Lightning,
            PoisonGas,
            Darkness,
            Light
        }


        public string Name { get; set; }

        public string Description { get; set; }

        public BreathType Type { get; set; }

    }

}
