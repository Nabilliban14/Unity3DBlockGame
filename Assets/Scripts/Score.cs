using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "0";
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = ((int) player.position.z + 4950).ToString();
	}
}
