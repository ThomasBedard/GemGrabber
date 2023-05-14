using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//using UnityEngine.Windows;
//using UnityEngine.Windows;

public class MoveCharacter : MonoBehaviour
{
    //link for character -> https://stackoverflow.com/questions/45569580/sprite-sheet-animation-with-arrow-keys
    //link for gem -> https://www.deviantart.com/bigbark24/art/Diamond-sprite-sheet-759155287
    //link for level 1 sprite sheet -> https://opengameart.org/content/outdoor-tiles-again
    //link for tree -> https://opengameart.org/content/gnarled-tree
    //link for level 2 sprite sheet -> https://opengameart.org/content/sci-fi-interior-tiles
    //link for tree ->https://www.google.ca/url?sa=i&url=https%3A%2F%2Fwww.pngkey.com%2Fmaxpic%2Fu2e6t4t4t4q8a9o0%2F&psig=AOvVaw2DYYBtGunR8_IRjYZ1VKNA&ust=1683262626904000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCLjwusX92v4CFQAAAAAdAAAAABAE
    Animator animator; //to talk to the animator
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = 1;
        float val_x = Input.GetAxis("Horizontal");
        float val_y = Input.GetAxis("Vertical");

        ////if val_x is less than 0, then set direction to 3
        //if (val_x < 0f)
        //{
        //    animator.SetInteger("direction", (int)MoveDirection.LEFT);
        //}
        ////if val_x is more than 0, then set direction to 4
        //if (val_x > 0f)
        //{
        //    animator.SetInteger("direction", (int)MoveDirection.RIGHT);
        //}
        ////if val_y is less than 0, then set direction to 2
        //if (val_y < 0f)
        //{
        //    animator.SetInteger("direction", (int)MoveDirection.DOWN);
        //}
        ////if val_y is more than 0, then set direction to 1
        //if (val_y > 0f)
        //{
        //    animator.SetInteger("direction", (int)MoveDirection.UP);
        //}
        //do for all dorection
        //then move the guy just like you didfor animation 1.
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("direction", (int)MoveDirection.UP);

        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("direction", (int)MoveDirection.LEFT);

        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("direction", (int)MoveDirection.DOWN);

        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("direction", (int)MoveDirection.RIGHT);

        }

        transform.position += new Vector3(val_x, val_y, 0).normalized *speed * Time.deltaTime;

        //animator.StopPlayback();
    }

    public enum MoveDirection
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        LEFT = 3,
        RIGHT = 4
    }
}
