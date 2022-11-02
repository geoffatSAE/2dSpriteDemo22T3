using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5;
    public Animator myAnimator;
    public GameObject mySprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, v, 0) * speed * Time.deltaTime);

        myAnimator.SetFloat("Up", v);


        if(h > 0)
        {
            //moving to the right
            myAnimator.SetBool("Walking", true);
            mySprite.transform.localScale = new Vector3(1, 1, 1);

        } else if(h < 0)
        {
            //moving to the left
            myAnimator.SetBool("Walking", true);
            mySprite.transform.localScale = new Vector3(-1,1, 1);

        } else
        {
            //not walking right
            myAnimator.SetBool("Walking", false);
        }



    }
}
