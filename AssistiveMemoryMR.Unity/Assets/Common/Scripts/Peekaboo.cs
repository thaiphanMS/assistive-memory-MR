using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peekaboo : MonoBehaviour
{
    [Tooltip("The gameObject you want to hide")]
    public GameObject thingToHide;
    [Tooltip("Time in seconds to disappear")]
    public float timeToDisappear = 2f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.MakeInvisible();
    }

    // Update is called once per frame
    void Update()
    {
        this.timer -= Time.deltaTime;
        if (this.timer <= 0f)
        {
            this.timer = 0f;
            this.MakeInvisible();
        }
        else
        {
            this.MakeVisible();
        }
    }

    private void MakeInvisible()
    {
        this.thingToHide.SetActive(false);
    }

    private void MakeVisible()
    {
        this.thingToHide.SetActive(true);
    }

    public void GazeHovered()
    {
        this.timer = this.timeToDisappear;
    }
}
