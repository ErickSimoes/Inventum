using UnityEngine;

public abstract class Item : ScriptableObject{
    public static PlayerController Player;
    public enum Type {
        Food, Weapon, PowerUp
    }

    public Type type;
    public string title;
    public Sprite icon;

    public abstract void Action();

}
