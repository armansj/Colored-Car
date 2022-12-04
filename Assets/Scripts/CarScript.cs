using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class CarScript : MonoBehaviour
{


    
    SpriteRenderer renderer;

   
    bool isRight;

   int scoreCar1;
   
   public Text myTextCar1;
   
   

    Color currentColor;

    bool isNotColored;

   public float carspeed = 8f;


    // Start is called before the first frame update


    private void Awake()
    {
        myTextCar1.text=" Score: ";
       
    }



    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
       
    }



    private void Update()
    {
        myTextCar1.text = "Score: " + scoreCar1;
       

        
        Car1Move();

    }

    // Update is called once per frame
   


    void Car1Move()
    {
       
            if (gameObject.tag == "Car" )
            {


                if (Input.GetMouseButtonDown(0) && !isRight)
                {

                    transform.position = new Vector3(-7.05f, transform.position.y, 0);
                    isRight = true;

                }
                else if (Input.GetMouseButtonDown(0) && isRight)
                {
                    transform.position = new Vector3(-4.03f, transform.position.y, 0);
                    isRight = false;
                }


               
                    transform.Translate(0, carspeed*Time.smoothDeltaTime, 0);
                

            }

        

      



    }




     void OnTriggerEnter2D(Collider2D target)
    {
       







        if (tag == "Car")
        {

            //Yellow

            if (target.gameObject.tag == "YellowSquare" && !isNotColored)
            {
                target.gameObject.SetActive(false);

                renderer.color = Color.yellow;

                print("Score;");
                scoreCar1++;

                //defineScore

                isNotColored = true;
            }

            else if (renderer.color == Color.yellow && target.gameObject.tag == "YellowSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar1++;


                //defineScore


            }

            else if (renderer.color == Color.yellow && target.gameObject.tag != "YellowSquare")
            {
                print("Stop");


                Time.timeScale = 0;



                //define GameOVer

            }


            ////////////




            //Blue

            if (target.gameObject.tag == "BlueSquare" && !isNotColored)
            {
                target.gameObject.SetActive(false);

                renderer.color = Color.blue;

                print("Score;");
                scoreCar1++;
                //defineScore


                isNotColored = true;

            }

            else if (renderer.color == Color.blue && target.gameObject.tag == "BlueSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar1++;


                //defineScore
            }

            else if (renderer.color == Color.blue && target.gameObject.tag != "BlueSquare")
            {
                print("Stop");


                Time.timeScale = 0;



                //defineGameOver
            }

            ///////////


            //Red


            if (target.gameObject.tag == "RedSquare" && !isNotColored)
            {
                target.gameObject.SetActive(false);

                renderer.color = Color.red;

                print("Score;");
                scoreCar1++;
                //defineScore

                isNotColored = true;

            }

            else if (renderer.color == Color.red && target.gameObject.tag == "RedSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar1++;



                //defineScore
            }

            else if (renderer.color == Color.red && target.gameObject.tag != "RedSquare")
            {
                print("Stop");


                Time.timeScale = 0;


                //define GameOver


            }


            ////////////


            //Black


            if (target.gameObject.tag == "BlackSquare" && !isNotColored)
            {
                target.gameObject.SetActive(false);

                renderer.color = Color.black;

                print("Score;");
                scoreCar1++;

                isNotColored = true;

            }

            else if (renderer.color == Color.black && target.gameObject.tag == "BlackSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar1++;

                //defnine Score




            }

            else if (renderer.color == Color.black && target.gameObject.tag != "BlackSquare")
            {
                print("Stop");


                Time.timeScale = 0;

                //define gameover

            }



        }//Car




      }//Ontrigger



  



}//class
