using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // cubes
    public GameObject[] allCubes;
   

    //turns
    private int turnCounter;
    private bool gameActive;

    //UI
    public GameObject Panel;
    public GameObject RedWins;
    public GameObject GreenWins;


    // Start is called before the first frame update
    void Start()
    {
        gameActive = true;

        //white cubes
        for(int i=0; i < allCubes.Length; i++)
        {
            allCubes[i].GetComponent<MeshRenderer>().material.color = Color.white;
        }
        

        //UI set inactive
        Panel.SetActive(false);
        RedWins.SetActive(false);
        GreenWins.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // check for winner
        CheckWinCondition();



        //get user input
        if (gameActive == true)
        {
            //1st row
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //check if cube is white
                if (allCubes[0].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[0].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[0].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    //increase the turn counter
                    turnCounter++;

                }


            }

            else if (Input.GetKeyDown(KeyCode.W))
            {
                //check if cube is white
                if (allCubes[1].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[1].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[1].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            else if (Input.GetKeyDown(KeyCode.E))
            {
                //check if cube is white
                if (allCubes[2].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[2].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[2].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            //2nd row
            else if (Input.GetKeyDown(KeyCode.A))
            {
                //check if cube is white
                if (allCubes[3].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[3].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[3].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                //check if cube is white
                if (allCubes[4].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[4].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[4].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                //check if cube is white
                if (allCubes[5].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[5].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[5].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            //3rd row
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                //check if cube is white
                if (allCubes[6].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[6].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[6].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            else if (Input.GetKeyDown(KeyCode.X))
            {
                //check if cube is white
                if (allCubes[7].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[7].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[7].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }

            }

            else if (Input.GetKeyDown(KeyCode.C))
            {
                //check if cube is white
                if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.white)
                {
                    //check turnCounter for even number
                    if (turnCounter % 2 == 0)
                    {
                        //change to red
                        allCubes[8].GetComponent<MeshRenderer>().material.color = Color.red;
                    }
                    else
                    {
                        //change to green
                        allCubes[8].GetComponent<MeshRenderer>().material.color = Color.green;
                    }

                    turnCounter++;
                }


            }

        }

    }

    private void CheckWinCondition()
    {

        //horizontal win condition 
        if (allCubes[0].GetComponent<MeshRenderer>().material.color == 
            allCubes[1].GetComponent<MeshRenderer>().material.color &&
            allCubes[0].GetComponent<MeshRenderer>().material.color ==
            allCubes[2].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[2].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[2].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        if (allCubes[3].GetComponent<MeshRenderer>().material.color ==
            allCubes[4].GetComponent<MeshRenderer>().material.color &&
            allCubes[3].GetComponent<MeshRenderer>().material.color ==
            allCubes[5].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[5].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[5].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        if (allCubes[6].GetComponent<MeshRenderer>().material.color ==
            allCubes[7].GetComponent<MeshRenderer>().material.color &&
            allCubes[6].GetComponent<MeshRenderer>().material.color ==
            allCubes[8].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        //vertical win condition 
        if (allCubes[0].GetComponent<MeshRenderer>().material.color ==
            allCubes[3].GetComponent<MeshRenderer>().material.color &&
            allCubes[0].GetComponent<MeshRenderer>().material.color ==
            allCubes[6].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[6].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[6].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        if (allCubes[1].GetComponent<MeshRenderer>().material.color ==
            allCubes[4].GetComponent<MeshRenderer>().material.color &&
            allCubes[1].GetComponent<MeshRenderer>().material.color ==
            allCubes[7].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[7].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[7].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        if (allCubes[2].GetComponent<MeshRenderer>().material.color ==
            allCubes[5].GetComponent<MeshRenderer>().material.color &&
            allCubes[2].GetComponent<MeshRenderer>().material.color ==
            allCubes[8].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        //diagonal win condition
        if (allCubes[0].GetComponent<MeshRenderer>().material.color ==
            allCubes[4].GetComponent<MeshRenderer>().material.color &&
            allCubes[0].GetComponent<MeshRenderer>().material.color ==
            allCubes[8].GetComponent<MeshRenderer>().material.color
            )
        {
            if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[8].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }

        if (allCubes[2].GetComponent<MeshRenderer>().material.color ==
           allCubes[4].GetComponent<MeshRenderer>().material.color &&
           allCubes[2].GetComponent<MeshRenderer>().material.color ==
           allCubes[6].GetComponent<MeshRenderer>().material.color
           )
        {
            if (allCubes[6].GetComponent<MeshRenderer>().material.color == Color.red)
            {
                print("Red wins");
                Panel.SetActive(true);
                RedWins.SetActive(true);
                gameActive = false;
            }
            else if (allCubes[6].GetComponent<MeshRenderer>().material.color == Color.green)
            {
                print("Green wins");
                Panel.SetActive(true);
                GreenWins.SetActive(true);
                gameActive = false;
            }
        }
       
    }

}

