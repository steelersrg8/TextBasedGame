using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Texture img1;
    public Texture img2;
    public Texture img3;
    public Texture img4;
    public Texture img5;
    public Texture img6;
    public Texture img7;
    public Texture img8;
    public Texture img9;
    public Texture img10;
    public Texture img11;
    public Texture img12;
    int stageNum = 1;
    int health = 40;
  

    void OnGUI()
    {

        if (stageNum == 1)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img1);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 100), "Personailty Test");
            if (GUI.Button(new Rect((Screen.width / 2) -50, (Screen.height / 2) - 20, 80, 40), "Next"))
            {
                stageNum = 2;
            }
        }

        if (stageNum == 2)
        {
            GUI.contentColor = Color.black;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img2);
            if (GUI.Button(new Rect((Screen.width / 2) - 40, (Screen.height / 2) - 20, 80, 40), "Start"))
            {
                stageNum = 3;
            }
        }


        if (stageNum == 3)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img3);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 100), "Q: Bike or Drive");

            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Bike"))
            {
                stageNum = 4;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Drive"))
            {
                stageNum = 5;
                health -= 30;
            }
        }


        if (stageNum == 4)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img4);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2)-50,120,100), "Q:Stairs Or Elevator");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Stairs"))
            {
                stageNum = 6;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Elevator"))
            {
                stageNum = 7;
                health -= 30;
            }
        }


        if (stageNum == 5)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img5);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2)-50 ,120, 60), "Q: Show or Movie ");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Show"))
            {
                stageNum = 8;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Movie"))
            {
                stageNum = 9;
                health -= 30;
            }
        }


        if (stageNum == 6)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img6);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2)-50, 120, 100), "Q: Good or Bad");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Good"))
            {
                stageNum = 10;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Bad"))
            {
                stageNum = 10;
                health -= 30;
            }
        }
        if (stageNum == 7)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img7);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2 )-50, 120, 100), "Q: Hero or Villan");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Hero"))
            {
                stageNum = 10;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Villan"))
            {
                stageNum = 10;
                health -= 30;
            }
        }
       
        if (stageNum == 8)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img8);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2)-50, 120, 100), "Q: Water or Fire");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Water"))
            {
                stageNum = 10;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Fire"))
            {
                stageNum = 10;
                health -= 30;
            }
        }


        if (stageNum == 9)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img9);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 50, 120, 25), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2)-50, 120, 100), "Q: Earth or Space");
            if (GUI.Button(new Rect((Screen.width / 2) - -10, (Screen.height / 2) - 20, 80, 40), "Earth"))
            {
                stageNum = 10;
                health += 10;
            }
            if (GUI.Button(new Rect((Screen.width / 2) - 90, (Screen.height / 2) - 20, 80, 40), "Space"))
            {
                stageNum = 10;
                health -= 30;
            }
        }
        if (stageNum == 10)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img10);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 60, 120, 50), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 60, 120,120), "You have a healthy personality");
            if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 2) - -5, 100,50), "Restart"))
            {
                health = 40;
                stageNum = 1;
            }
        }

        if (stageNum == 11)
        {
            GUI.contentColor = Color.white;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), img12);
            GUI.DrawTexture(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 60, 120, 50), img11);
            GUI.Label(new Rect((Screen.width / 2) - 60, (Screen.height / 2) - 60, 120, 120), "You Have a Unhealthy Personality");
            if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 2) - -5, 100, 50), "Restart"))
            {
                health = 40;
                stageNum = 1;
            }
        }
        GUI.contentColor = Color.white;
        GUI.DrawTexture(new Rect(20, 30, 120, 40), img11);
        GUI.Label(new Rect(20, 50, 120, 40),"Health:" + health);
        GUI.Label(new Rect(20, 30, 120, 40),"Stage:" + stageNum);
       
       
        if (health <= 0)
        {
            stageNum = 11;
        }
    }
    void Start()
    {

    }
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () 
    {
       
	}
}
