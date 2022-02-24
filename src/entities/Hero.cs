namespace RPG_ABSTRACAO.src.entities
{
    public class Hero
    {
        public string name;
        public int level;
        public string heroType;
        public int HP;
        public int MP;

        public Hero(string name, int level, string heroType, int HP, int MP )
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string ToString()
        {
            return $"{name} {level} {heroType}";
        }

        public virtual string Attack(){
            return $"{this.name} atacou com a espada";
        }
    }
}