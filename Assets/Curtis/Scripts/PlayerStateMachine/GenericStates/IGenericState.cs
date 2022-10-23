using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IGenericState
{
    void stateEntered();
    void stateExit();
    void updateState();
    void checkState();
    void switchState();

}
