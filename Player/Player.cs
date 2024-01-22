public class Player {

    private int health;
    private string name;
    private string[] inventory;

    public Player(string name, string startingPotion) {
        this.name = name;
        health = 100;
        inventory[0] = startingPotion;
    }

    public void SetName(string newName) {
        name = newName;
    }

    public int GetHealth() {
        return health;
    }

    public string GetInventory() {
        return inventory[0];
    }

}