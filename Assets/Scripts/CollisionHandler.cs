using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly bumped.");
                break;
            case "Finish":
                Debug.Log("Finish reached.");
                break;
            default:
                Debug.Log("You crashed.");
                break;
        }
    }
}
