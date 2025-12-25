namespace App.Rive.Runtime.Kotlin.Fonts;

public sealed partial class Fonts
{
    public sealed partial class Weight
    {
        public int CompareTo(Java.Lang.Object o)
        {
            if (o is global::App.Rive.Runtime.Kotlin.Fonts.Fonts.Weight weight)
                return CompareTo(weight);
            return 1;
        }
    }
}