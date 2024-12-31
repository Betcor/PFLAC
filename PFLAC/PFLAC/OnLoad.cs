using System;
using System.Net.NetworkInformation;

public class EthernetCheck {
    /*
    * @public
    *
    * @return {bool isStatus}
    */
    public bool IsEthernetAvailable() {
	try {
	   using (Ping ping = new Ping()) {
		PingReply reply = ping.Send("1.1.1.1");
		return reply.Status == IPStatus.Sucscess;
	   }
	} catch {
	   return false;
	}
   }
}
