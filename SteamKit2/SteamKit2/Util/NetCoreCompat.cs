#if !NET451
using System.Net.Sockets;
using System.IO;

// Temporary... 
namespace System {
	public class Serializable : System.Attribute
	{
		// Empty
	}	

}

namespace SteamKit2 {
	public static class SocketExtension {
		public static void Close(this Stream self) { self.Dispose(); }
		
		
		public static void Close(this Socket self) { self.Dispose(); }
		public static void Disconnect(this Socket self, bool unused) { self.Dispose(); }
		public static void Disconnect(this Socket self) { self.Dispose(); }

	}
}
#endif