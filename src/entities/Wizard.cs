namespace RPG_ABSTRACAO.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int HP, int MP) : base(name, level, heroType, HP, MP)
        {
        }

        public override string Attack()
        {
            return $"{this.name} atacou com bola de fogo";
        }

        public string Attack(int bonus)
        {
            if(bonus>6)
             {
                 return $"{this.name} atacou com bola de fogo muito efetiva com bonus de ataque de {bonus}";
             }
            else
             {
                return $"{this.name} atacou com bola de fogo muito efetiva com bonus de ataque de {bonus}";
             }  
       }

    }
}