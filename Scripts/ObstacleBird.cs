using UnityEngine;
using System.Collections;

public class ObstacleBird : MonoBehaviour 
{
    
    private bool isDead = false;            //Has the player collided with a wall?

    private Animator anim;                    //Reference to the Animator component.


    void Start()
    {
        //Get reference to the Animator component attached to this GameObject.
        anim = GetComponent<Animator> ();
 
    }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isDead == false) 
        {
    
                anim.SetTrigger("SecondBird");
            
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
	
			isDead = true;
			anim.SetTrigger ("DeadBird");
			GameControl.instance.BirdDied ();
    
    }
}
