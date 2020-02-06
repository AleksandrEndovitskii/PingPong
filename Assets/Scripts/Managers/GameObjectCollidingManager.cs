using GameObjects;
using GameObjects.Field;
using UnityEngine;

namespace Managers
{
    public class GameObjectCollidingManager : MonoBehaviour
    {
        public void Initialize()
        {
            //
        }

        public void AnalyzeCollidedObjects(BallView ballView, WallView wallView)
        {
            //AnalyzeCollidedObjects(BallView ballView, wallView);
        }

        public void AnalyzeCollidedObjects(BallView ballView, RepellentWallView repellentWallView)
        {
            ballView.BounceInOppositeDirection();
        }

        public void AnalyzeCollidedObjects(BallView ballView, GateWallView gateWallView)
        {
            //
        }
    }
}
