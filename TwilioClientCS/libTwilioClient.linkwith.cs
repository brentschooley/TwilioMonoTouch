using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTwilioClient.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
[assembly: LinkWith ("libssl.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
[assembly: LinkWith ("libcrypto.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
