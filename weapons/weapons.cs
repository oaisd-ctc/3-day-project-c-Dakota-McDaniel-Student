public class weapon
{

    private int damage;
    private string weapon;

    public Item(string weapon, int damage)
    {

        this.weapon = weapon;
        this.damage = damage;
    
    }

    public void IncreaseDamage()
    {

        damage++;
        return damage;

    }

}