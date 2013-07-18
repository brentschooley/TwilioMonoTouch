using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTwilioClient.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "AudioToolbox AVFoundation CFNetwork SystemConfiguration", ForceLoad = true)]
