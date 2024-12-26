using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public void OnHoverEntered() => print(gameObject.name + " - OnHoverEntered");
    public void OnHoverExit() => print(gameObject.name + " - OnHoverExited");
    public void OnSelectEntered() => print(gameObject.name + " - OnSelectEntered()");
    public void OnSelectExited() => print(gameObject.name + " - OnSelectedExited()");
    public void OnActivated() => print(gameObject.name + " - OnActivated()");
    public void OnDeactivated() => print(gameObject.name + " - OnDeactivated()");
}