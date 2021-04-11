using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public int depth;

    [SerializeField]
    private bool lookAt = true;


    public void setTarget(Transform target)
    {
        playerTransform = target;
    }


    // Update is called once per frame
     void Update()
     {

         if (playerTransform != null)
         {
             transform.position = playerTransform.position + new Vector3(0, 2, depth );
         }

         /*// compute rotation
         if (lookAt)
         {
             transform.LookAt(playerTransform);

         }
         else
         {
             Debug.Log("NotLooking");
             transform.rotation = playerTransform.rotation;

         }*/
     }



}