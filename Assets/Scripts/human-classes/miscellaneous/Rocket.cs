using IBullets;
using UnityEngine;

public class Rocket : Bullet, IRocket
{
    void Start()
    {
        damage = 50f;
        speed = 100f;
    }

}
