using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car2Script : MonoBehaviour
{
    bool isRight;
    int scoreCar2;
    public Text myTextCar2;

    Color currentColor;

    bool isNotColored;

    public float carspeed = 8f;

    SpriteRenderer renderer;

    private void Awake()
    {
        myTextCar2.text = "Score: ";
    }

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        myTextCar2.text = "Score: " + scoreCar2;
        Car2Move();
    }

    void Car2Move()
    {



        if (gameObject.tag == "Car2")
        {

            if (Input.GetMouseButtonDown(1) && !isRight)
            {

                transform.position = new Vector3(3.04f, transform.position.y, 0);
                isRight = true;


            }
            else if (Input.GetMouseButtonDown(1) && isRight)
            {
                transform.position = new Vector3(0, transform.position.y, 0);
                isRight = false;

            }

            transform.Translate(0, carspeed * Time.smoothDeltaTime, 0);





        }






    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (tag == "Car2")
        {

            //Yellow

            if (target.gameObject.tag == "YellowSquare" && !isNotColored)
            {
                target.gameObject.SetActive(false);

                renderer.color = Color.yellow;

                print("Score;");
                scoreCar2++;

                //defineScore

                isNotColored = true;
            }

            else if (renderer.color == Color.yellow && target.gameObject.tag == "YellowSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar2++;


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
                scoreCar2++;
                //defineScore


                isNotColored = true;

            }

            else if (renderer.color == Color.blue && target.gameObject.tag == "BlueSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar2++;


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
                scoreCar2++;
                //defineScore

                isNotColored = true;

            }

            else if (renderer.color == Color.red && target.gameObject.tag == "RedSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar2++;



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
                scoreCar2++;

                isNotColored = true;

            }

            else if (renderer.color == Color.black && target.gameObject.tag == "BlackSquare")
            {
                target.gameObject.SetActive(false);

                print("Score;");
                scoreCar2++;

                //defnine Score




            }

            else if (renderer.color == Color.black && target.gameObject.tag != "BlackSquare")
            {
                print("Stop");


                Time.timeScale = 0;

                //define gameover

            }



        }//car2



    }
 }
