//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CameraTransComponent cameraTrans { get { return (CameraTransComponent)GetComponent(GameComponentsLookup.CameraTrans); } }
    public bool hasCameraTrans { get { return HasComponent(GameComponentsLookup.CameraTrans); } }

    public void AddCameraTrans(UnityEngine.Transform newCameraTransform, UnityEngine.Transform newTargetTransform) {
        var index = GameComponentsLookup.CameraTrans;
        var component = CreateComponent<CameraTransComponent>(index);
        component.cameraTransform = newCameraTransform;
        component.targetTransform = newTargetTransform;
        AddComponent(index, component);
    }

    public void ReplaceCameraTrans(UnityEngine.Transform newCameraTransform, UnityEngine.Transform newTargetTransform) {
        var index = GameComponentsLookup.CameraTrans;
        var component = CreateComponent<CameraTransComponent>(index);
        component.cameraTransform = newCameraTransform;
        component.targetTransform = newTargetTransform;
        ReplaceComponent(index, component);
    }

    public void RemoveCameraTrans() {
        RemoveComponent(GameComponentsLookup.CameraTrans);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCameraTrans;

    public static Entitas.IMatcher<GameEntity> CameraTrans {
        get {
            if (_matcherCameraTrans == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CameraTrans);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCameraTrans = matcher;
            }

            return _matcherCameraTrans;
        }
    }
}
