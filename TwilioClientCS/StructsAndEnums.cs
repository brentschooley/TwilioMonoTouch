using System;

namespace TwilioClientCS
{
	public enum TCConnectionState /*: [unmapped: unexposed: Elaborated]*/ {
		Pending, // = 0,
		Connecting,
		Connected,
		Disconnected
	}

	public enum TCDeviceState /*: [unmapped: unexposed: Elaborated]*/ {
		Offline, // = 0,
		Ready,
		Busy
	}

	public enum Foo
	{
		FLa,
		Ble
	}
}

