using System;

namespace TwilioClientCS
{
	public enum TCConnectionState {
		Pending = 0,
		Connecting,
		Connected,
		Disconnected
	}

	public enum TCDeviceState  {
		Offline = 0,
		Ready,
		Busy
	}
}

