using UnityEngine;

namespace Playtica
{
    public static class ToolZ
    {
        public static void SetXPosition(this Transform t, float x)
        {
            var position = t.position;
            position = new Vector3(x, position.y, position.z);
            t.position = position;
        }

        public static void AddXToPosition(this  Transform t, float x)
        {
            var position = t.position;
            position += new Vector3(position.x + x, position.y, position.z);
            t.position = position;
        }
    } 
}