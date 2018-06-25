
using UnityEngine;
using Entitas;
public class GravitySystem : IExecuteSystem
{
    readonly Contexts contexts;
    public GravitySystem(Contexts _contexts)
    {
        contexts = _contexts;
    }
    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.PlayerUnity);
        foreach (GameEntity entity in entities)
        {
            IsGround(entity);
        }
    }


    private bool IsGround(GameEntity _entity)
    {
        //Vector3 tmp_OringinalPos = _entity.playerUnity.transform.position;
        //tmp_OringinalPos.y += .6f;
        //Vector3 tmp_Direction = Vector3.down;

        //Ray tmp_ray = new Ray(tmp_OringinalPos, tmp_Direction);
        //RaycastHit tmp_hit;
        //Debug.DrawRay(tmp_OringinalPos, tmp_Direction, Color.red);

        //if (Physics.Raycast(tmp_ray, out tmp_hit, .6f))
        //{
        //    _entity.playerUnity.transform.position = tmp_hit.point;
        //    return true;
        //}
        return false;
    }
}
