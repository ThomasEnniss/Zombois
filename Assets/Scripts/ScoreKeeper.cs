using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text TextBox;
    public int zombiesKilled;

	// Use this for initialization
	void Start () {
        zombiesKilled = 0;
        SetScore();
    }
       
    void SetScore() {
        TextBox.text = "Zombies Killed:" + zombiesKilled.ToString();
    }

    public void ZombieKilled() {
        zombiesKilled+=1;
        SetScore();
    }
}
