using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScript : MonoBehaviour {
    bool isTweening = false;
    float toX = 0;
    float toY = 0;
    int speed = 3000;
    
    public void startTween(float X, float Y) {
        toX = X;
        toY = Y;

        isTweening = true;
    }

    public void startTween(GameObject Obj) {
        toX = Obj.transform.position.x;
        toY = Obj.transform.position.y;

        isTweening = true;
    }

    public bool getState() {

        return isTweening;
    }

    // Update is called once per frame
    void Update () {
        if (isTweening) {
            float step = speed * Time.deltaTime;

            Vector2 currentLocation = gameObject.transform.position;
            gameObject.transform.position = Vector2.MoveTowards(currentLocation, new Vector2(toX, toY), step);

            if (gameObject.transform.position.x == toX && gameObject.transform.position.y == toY) {
                isTweening = false;
            }
        }
	}
}
