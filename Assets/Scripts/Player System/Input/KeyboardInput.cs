using UnityEngine;

namespace WildBall.PlayerSystems 
{
    public class KeyboardInput : BaseInput
    {
        public override InputData GenerateInput() {
            return new InputData
            {
                horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS),
                vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS)
            };
        }
    }
}
