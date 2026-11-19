using Foundation;
using ObjCRuntime;
using UIKit;

namespace AdventureSystem.Player;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	/// <summary>
	/// The macOS app menu holds a single command, Quit, which ends the Player. The template's About, Services,
	/// Hide and "Quit and Keep Windows" items are no use to someone playing a game.
	/// </summary>
	public override void BuildMenu(IUIMenuBuilder builder)
	{
		base.BuildMenu(builder);
		if (builder.System != UIMenuSystem.MainSystem) return;
		var quit = UIKeyCommand.Create(new NSString("Quit"), null, new Selector("quitPlayer:"),
			new NSString("q"), UIKeyModifierFlags.Command, new NSString("quit"));
		builder.ReplaceChildrenOfMenu(UIMenuIdentifier.Application.GetConstant()!.ToString(), _ => new UIMenuElement[] { quit });
	}

	[Export("quitPlayer:")]
	public void QuitPlayer(UICommand sender) => Environment.Exit(0);
}
