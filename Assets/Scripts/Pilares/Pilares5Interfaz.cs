using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilares5Interfaz : MonoBehaviour
{
    IAttackBehaviour attackBehaviour;
    private void Awake()
    {
        attackBehaviour = new SwordAttack();
        attackBehaviour.Attack();
        attackBehaviour = new MagicAttack();
        attackBehaviour.Attack();
    }
}

public interface IAttackBehaviour
{
    void Attack();
}

public class SwordAttack : IAttackBehaviour
{
    public void Attack()
    {
        Debug.Log("Sword Attack");
    }
}

public class MagicAttack : IAttackBehaviour
{
    public void Attack()
    {
        Debug.Log("Fireball Cast");
    }
}

