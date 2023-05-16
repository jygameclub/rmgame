using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public static class ItemOrientationExtensions
    {
        // Methods
        public static Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation Opposite(Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation orientation)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation val_1 = orientation + 1;
            var val_3 = (val_1 < 0) ? (orientation + 2) : (orientation + 1);
            val_3 = val_3 & 4294967294;
            orientation = val_1 - val_3;
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation)orientation;
        }
    
    }

}
