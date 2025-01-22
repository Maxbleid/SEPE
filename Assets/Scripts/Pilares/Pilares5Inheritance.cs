using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilares5Inheritance : MonoBehaviour
{
    Character character;
    private void Awake()
    {
        character = new Character();
        character.Attack();
        character = new Warrior();
        character.Attack();
        character = new Mage();
        character.Attack();

    }
}

public class Character
{
    public virtual void Attack()
    {
        Debug.Log("Basic Attack");
    }
}

public class Warrior : Character
{
    public override void Attack()
    {
        Debug.Log("Sword Swing!");
    }
}

public class Mage: Character
{
    public override void Attack()
    {
        Debug.Log("Fireball Cast");
      //  base.Attack(); // se usa base para ejecutar codigo del padre
    }
}