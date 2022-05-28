
public class Wizard : Hero
{
    public Wizard(string Name, int Level, string HeroType, int Life)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.Life = Life;
    }

    public override string Attack()
    {
        return this.Name + " Ataque com Magias!!";
    }

    public string Attack(int bonus, string nameAttack)
    {
        return this.Name + " Ataque com Magias!! " + bonus + nameAttack + "vezes";
    }
}

