using System;
using MonoTouch.Foundation;

namespace TwilioClientCS
{
	public partial class TCDevice
	{
		public TCConnection Connect (NSDictionary parameters, TCConnectionDelegate aDelegate)
		{
			return new TCConnection ( Connect_ (parameters, aDelegate));
		}
	}
}

