using System;
using MonoTouch.Foundation;

namespace TwilioClientCS
{
	public partial class TCDevice
	{
		public TCConnection Connect (NSDictionary parameters, TCConnectionDelegate d)
		{
			return new TCConnection ( Connect_ (parameters, d));
		}
	}
}

