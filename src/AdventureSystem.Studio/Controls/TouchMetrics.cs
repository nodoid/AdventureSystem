namespace AdventureSystem.Studio.Controls;

/// <summary>Sizes for a touch screen (the iPad, Android tablets) and for a mouse (Mac, Windows).</summary>
public static class TouchMetrics
{
    /// <summary>Running on a tablet: fingers rather than a pointer, and no hover.</summary>
    public static bool IsTouch { get; } = DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.Android;

    /// <summary>The smallest comfortable tap target: 44 points (Apple's guideline; Android asks for 48dp).</summary>
    public static double MinTarget => IsTouch ? 44 : 28;

    /// <summary>The mouse size on the desktop, the touch size on the iPad.</summary>
    public static double Pick(double mouse, double touch) => IsTouch ? touch : mouse;
}
