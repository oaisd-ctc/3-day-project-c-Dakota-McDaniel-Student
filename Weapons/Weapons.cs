public class weapon
{

    private int damage;
    private string weapon;

    public Weapon(string weapon, int damage)
    {

        this.weapon = weapon;
        this.damage = damage;
    
    }

    public int IncreaseDamage()
    {

        damage = damage + 20;
        return damage;

    }

    // public int Attack()
    // {

//      enemyHealth = enemyHealth - damage; 
//

    // }

}