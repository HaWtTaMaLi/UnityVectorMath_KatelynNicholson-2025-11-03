using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    //SCENE 2

    //expose variable float step
    public float step = 1;
    //vector3 called startPos (set it to gameobjects starting pos) in start()


    void Start()
    {
        
    }

    void Update()
    {
        //every frame set the game objects positon to its startPos * the scalar
        //pressing w or s should increase or decrease by step value
        //only detect when key is pressed not every frame
    }

}
