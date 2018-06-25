using UnityEngine;
using System.Collections;
using Entitas;
public class TopdownCameraSystem : IExecuteSystem
{
    readonly Contexts contexts;
    GameEntity entity;
    public TopdownCameraSystem(Contexts _contexts)
    {
        contexts = _contexts;
        entity = contexts.game.CreateEntity();
        entity.isCamera = true;
        entity.AddCameraProperties(15, 10, 10);
        entity.AddCameraTrans(Camera.main.transform, GameObject.FindGameObjectWithTag("Player").transform);
    }
    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.Camera);
        foreach (GameEntity entity in entities)
        {
            Vector3 tmp_Offset = entity.cameraTrans.targetTransform.position;
            tmp_Offset.y += entity.cameraProperties.height;
            tmp_Offset.z -= entity.cameraProperties.depth;
            entity.cameraTrans.cameraTransform.position = Vector3.Lerp(entity.cameraTrans.cameraTransform.position, tmp_Offset, Time.deltaTime * entity.cameraProperties.followSpeed);
        }
    }
}
