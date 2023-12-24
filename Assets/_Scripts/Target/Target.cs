using UnityEngine;

public abstract class Target : MonoBehaviour
{
    public abstract void GetDamage(); 
    public abstract void Death(); 
    public abstract void Respawn(); 
}