using UnityEngine;
using PathCreation;

public class PathFollower : MonoBehaviour
{
   public PathCreator pathCreator;
   public EndOfPathInstruction end;
   public float speed;
   float dstTravelled;

   void Update()
   {
      dstTravelled += speed * Time.deltaTime;
      transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end);
      transform.rotation = pathCreator.path.GetRotationAtDistance(dstTravelled, end);
      transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0);
   }
}