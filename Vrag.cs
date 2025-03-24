using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrag : MonoBehaviour
{
   private Rigidbody2D phisic;
   public Transform player;
    public float speed;
    public float agroDistance;
    // Start is called before the first frame update
    void Start()
    {
        phisic = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distansplayer = Vector2.Distance(transform.position, player.position);
        if(distansplayer<agroDistance)
        {
            StartHunt();
        }
        else
        {
            StopHunt();
        }
    }
    void StartHunt()
    {
        if(player.position.x<transform.position.x)
        {
            phisic.velocity = new Vector2(-speed,0);
        }
        else if(player.position.x > transform.position.x)
        {
            phisic.velocity = new Vector2(speed, 0);
        }
    }
    void StopHunt()
    {
        phisic.velocity = new Vector2(0, 0);
    }
}
