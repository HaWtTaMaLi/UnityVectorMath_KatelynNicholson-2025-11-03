using UnityEngine;

public class EnemyAndPlayer : MonoBehaviour
{
    //SCENE 3

    public GameObject Player; //add a child 
    public GameObject Enemy;
    //set the positions of enemy and player close but can still escale
    //Vector3 = enemyDir (set each frame) direction towards enemy
    public float playerDotEnemyDir; //each frame set to do product of the players forward vector and the enemyDir vector
    //use normalized vectors

    void Start()
    {
        //set child to cubesPos + player transform forward vector

    }

    //player move W(forward) S(backward)

    void Update()
    {
        
    }

}
