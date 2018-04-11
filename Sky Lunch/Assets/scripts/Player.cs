using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Sprite moving_left;
    public Sprite moving_right;
    public Sprite moving_up;
    public Sprite moving_down;

    public Text score_text;
    public Text highscore_text;

    public int score;
    public int highscore;

    public Rigidbody2D rb2d;

    bool w;
    bool a;
    bool s;
    bool d;

    public SpriteRenderer render;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("hs");
    }

    void Update () {
		if(Input.GetKey("w"))
        {
            w = true;
            
        }
        else if(Input.GetKey("s"))
        {
            s = true;
        }
        else if (Input.GetKey("a"))
        {
            a = true;
        }
        else if(Input.GetKey("d"))
        {
            d = true;
        }
        score_text.text = "score: " + score.ToString();
        if(score > highscore)
        {
            PlayerPrefs.SetInt("hs", score);
        }
        highscore_text.text = "high score: " + highscore.ToString();
	}

    private void FixedUpdate()
    {
        if(w)
        {
            rb2d.AddForce(new Vector2(0,10));
            render.sprite = moving_up;
            w = false;
        }
        if(s)
        {
            rb2d.AddForce(new Vector2(0,-10));
            render.sprite = moving_down;
            s = false;
        }
        if(a)
        {
            rb2d.AddForce(new Vector2(-10, 0));
            render.sprite = moving_left;
            a = false;
        }
        if(d)
        {
            rb2d.AddForce(new Vector2(10,0));
            render.sprite = moving_right;
            d = false;
        }
    }
    public void Kill()
    {
        SceneManager.LoadScene("title_screen");
    }
}
