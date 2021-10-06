using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public GameObject Cube6;
    public GameObject Cube7;
    public GameObject Cube8;
    public GameObject Cube9;

    private int turnCounter;

    // Start is called before the first frame update
    void Start()
    {
        Cube1.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube2.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube3.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube4.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube5.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube6.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube7.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube8.GetComponent<MeshRenderer>().material.color = Color.white;
        Cube9.GetComponent<MeshRenderer>().material.color = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        //check if red wins
        CheckRedWinCondition();

        //check if green wins
        CheckGreenWinCondition();

        //get user input

        //1st row
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //check if cube is white
            if (Cube1.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube1.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube1.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                //increase the turn counter
                turnCounter++;

            }


        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            //check if cube is white
            if (Cube2.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube2.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube2.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            //check if cube is white
            if (Cube3.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube3.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube3.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        //2nd row
        else if (Input.GetKeyDown(KeyCode.A))
        {
            //check if cube is white
            if (Cube4.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube4.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube4.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            //check if cube is white
            if (Cube5.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube5.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube5.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            //check if cube is white
            if (Cube6.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube6.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube6.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        //3rd row
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            //check if cube is white
            if (Cube7.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube7.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube7.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            //check if cube is white
            if (Cube8.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube8.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube8.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            //check if cube is white
            if (Cube9.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //check turnCounter for even number
                if (turnCounter % 2 == 0)
                {
                    //change to red
                    Cube9.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    //change to green
                    Cube9.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                turnCounter++;
            }

        }

    }   
        private void CheckRedWinCondition()
        {
         //horizontal win condition for red
            if (Cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
                Cube2.GetComponent<MeshRenderer>().material.color == Color.red &&
                Cube3.GetComponent<MeshRenderer>().material.color == Color.red)
            {
             print("Red wins");

            }

        else if (Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        else if (Cube7.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube8.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        //vertical win condition for red
        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube7.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        else if (Cube2.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        //diagonal win condition for red
        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
            Cube7.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red wins");

        }

    }

    private void CheckGreenWinCondition()
    {
        //horizontal win condition for green
        if (Cube1.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube2.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube3.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        else if (Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        else if (Cube7.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube8.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        //vertical win condition for green
        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube4.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube7.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        else if (Cube2.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube8.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube6.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        //diagonal win condition for red
        else if (Cube1.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube9.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

        else if (Cube3.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube5.GetComponent<MeshRenderer>().material.color == Color.green &&
            Cube7.GetComponent<MeshRenderer>().material.color == Color.green)
        {
            print("Green wins");

        }

    }

}

