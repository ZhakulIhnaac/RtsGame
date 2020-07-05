using Enums;
using UnityEngine;

public class Attacker : Unit
{
    public GameObject bullet;
    public GameObject target;
    public float attackingRange;
    public float hitPoint;

    protected void Attack(GameObject enemy)
    {
        unitStatus = EUnitStatus.InAction;
        target = enemy;
    }

    public void ShootToKill(GameObject enemy)
    {
        GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        newBullet.GetComponent<Bullet>().FlyForward(transform.forward);
    }

}
