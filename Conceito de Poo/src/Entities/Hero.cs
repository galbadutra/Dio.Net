namespace poo
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Life { get; set; }

        public Hero(string Name, int Level, string HeroType, int Life)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
        }
        public Hero() { }


        // VIRTUAL permitir alteração por qualquer filho
        public virtual string Attack()
        {
            return this.Name + " Ataque ";

        }

        public override string ToString()
        {
            return this.Name;
        }

    }

}





