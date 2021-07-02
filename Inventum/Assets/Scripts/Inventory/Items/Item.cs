using UnityEngine;

public abstract class Item : ScriptableObject{
    public enum Type {
        Food, Weapon, PowerUp
    }

    public Type type;
    public string title;
    public Sprite icon;

}
