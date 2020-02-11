using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    public bool InRangeFood;
    public bool InrangeOven; 
    public bool pickUp;
    public Transform hand;
    public GameObject foodInhand;
    public Transform OvenPositon;
    private GameObject OvenCollidedWith;

    private void OnTriggerEnter(Collider other)
    {
        GameObject food;
        if (other.gameObject.tag == "food")
        {
            food = GameObject.FindGameObjectWithTag("food");
            InRangeFood = true;
            foodInhand = food;            
        }
        else
        {
            InRangeFood = false;
            foodInhand = null;
            food = null;
        }
    }
    public void Update()
    {
        pickUpFood();
        putDownFood();
    }
    void pickUpFood()
    {
        if (Input.GetKey(KeyCode.E) && InRangeFood)
        {
            pickUp = true;
        }
        if (pickUp)
        {
            foodInhand.transform.position = hand.position;
        }
    }


   public void OnCollisionEnter(Collision collision)       
    {
        
        if(collision.gameObject.tag == "Oven")
        {
            OvenCollidedWith = collision.gameObject; //GameObject.FindGameObjectWithTag("Oven");
            InrangeOven = true;
        }
        else
        {
            OvenCollidedWith = null;
            InrangeOven = false;
        }
    }
    void putDownFood()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            pickUp = false;
            foodInhand = null;




            /*
             *ifnull
            oven = ovencollidedwith


            ovendetails = oven.GetComponent<ovendetails>
            set position of food to ovendetails.foodposition
         
         */
        }
    }



















    //  // radiuse of the picable object
    //  public float interacRadius = 3f;
    //
    //  // bool for in range
    //
    //  bool inRange = false;
    //
    //
    //  // transfer  to becam somting later on
    //  Transform origen;
    //
    //  private void Update()
    //  {
    //      //find player
    //      GameObject[] original = GameObject.FindGameObjectsWithTag("Player");
    //
    //      GameObject Originallocation = null;
    //
    //      float location = Mathf.Infinity;
    //      foreach (GameObject og in original)
    //      {
    //          float ogdistance = Vector3.Distance(transform.position, og.transform.position);
    //          if (ogdistance < location)
    //          {
    //              location = ogdistance;
    //              Originallocation = og;
    //              Debug.Log("checking OrginalLocaion" + Originallocation);
    //
    //              origen = Originallocation.transform;
    //              inRange = true;
    //          }
    //      }
    //      if (inRange)
    //      {
    //          float distance = Vector3.Distance(origen.position, transform.position);
    //          if (distance <= interacRadius)
    //          {
    //              if (Input.GetMouseButtonUp(0))
    //              {
    //
    //              }
    //          }
    //      }
    //
    //  }
    //  public virtual void AnInteractio()
    //  {
    //      transform.SetParent(origen);
    //      transform.position = origen.position;
    //  }

}
