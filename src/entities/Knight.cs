namespace RPG_ABSTRACAO.src.entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int HP, int MP) : 
        base(name, level, heroType, HP, MP)
        {
        }

         public override string Attack()
        {
            return $"{this.name} atacou com bola a espada de duas mão";
        }

        public string Attack(int bonus)
        {
            if(bonus>6)
             {
                 return $"{this.name} atacou com a espada de duas mãos de maneira muito efetiva com bonus de ataque de {bonus}";
             }
            else
             {
                return $"{this.name} atacou com a espada de duas mãos de maneira muito efetiva com bonus de ataque de {bonus}";
             }  
       }

    }
}