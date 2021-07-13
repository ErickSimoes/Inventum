using UnityEngine;

public abstract class Item : ScriptableObject{
    public static PlayerController player;
    public static Inventory inventory;
    public enum Type {
        Food, Weapon, PowerUp
    }

    public Type type;
    public string title;
    public Sprite icon;

    public abstract void Action();

}
