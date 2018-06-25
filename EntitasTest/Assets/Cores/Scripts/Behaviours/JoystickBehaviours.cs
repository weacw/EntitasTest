using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Entitas;
public class JoystickBehaviours : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Contexts m_Context;
    private GameEntity entity;
    private Systems systems;


    [SerializeField] private Image m_JoystickBackground;
    [SerializeField] private Image m_JoystickHandler;
    private void Awake()
    {


        m_Context = Contexts.sharedInstance;
        systems = new Feature("Joystick System").Add(new JoystickSystem(m_Context)).Add(new PlayerFeatures(m_Context));


        entity = m_Context.game.CreateEntity();
        entity.AddJoyStickState(JoystickStateType.None);
        entity.AddJoyStickDirection(Vector2.zero);
        entity.AddJoyStickRectTransform(m_JoystickBackground.rectTransform, m_JoystickHandler.rectTransform);
        entity.AddJoyStickPointerData(null);
        entity.isJoyStick = true;

        entity.AddPlayer(GameObject.Find("Cube"));
        entity.AddMovement(Vector2.zero);
        entity.AddPlayerProperties(5, 5, 30,LayerMask.GetMask("Player"),PlayerState.None);
        entity.AddPlayerUnity(
            entity.player.character.GetComponent<CapsuleCollider>(),
            entity.player.character.GetComponent<Rigidbody>(),
            entity.player.character.GetComponentInChildren<Animator>(),
            entity.player.character.transform);
    }


    public void OnDrag(PointerEventData eventData)
    {
        entity.ReplaceJoyStickPointerData(eventData);
        entity.ReplaceJoyStickState(JoystickStateType.OnDrag);
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        entity.ReplaceJoyStickPointerData(eventData);
        entity.ReplaceJoyStickState(JoystickStateType.OnDown);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        entity.ReplaceJoyStickPointerData(eventData);
        entity.ReplaceJoyStickState(JoystickStateType.OnUp);
        systems.Execute();
    }

    private void OperaterPointerComponent(PointerEventData eventData)
    {
        if (entity.hasJoyStickPointerData)
        {
            entity.ReplaceJoyStickPointerData(eventData);
        }
        else
        {
            entity.AddJoyStickPointerData(eventData);
        }
    }

    private void Update()
    {
        systems.Execute();
    }
}
