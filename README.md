# TouchEffectBug
demonstrates an issue I'm having with Xamarin.CommunityToolkit TouchEffect

This is a Xamarin Forms application I am building and running for Android only.
Development and debugging is done in Visual Studio 2022.

I have implemented a simple button-like control to contain any content, using a Xamarin.Forms.Frame with 
Xamarin.CommunityToolkit TouchEffect attached properties.
The TouchEffect properties animate the frame to look like a button press.

The issue is that most of the time the very first button touch doesn't not animate. The Command for the button does get executed, but without the animation. After the first touch ANYWHERE on the application, all subsequent button touches DO animate.
I find this to be the case running the Visual Studio android emulator or on several android phones, both in debug and release.
