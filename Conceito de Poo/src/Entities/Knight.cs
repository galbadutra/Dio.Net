namespace poo
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int Life)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
        }

        public override string Attack()
        {
            return base.Attack() + "com sua espada";
        }
    }
}