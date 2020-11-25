//#pragma strict
//using Ovr;
//function Start () {
//		var HMD = OVR.Hmd.GetHmd();
//		ovrTrackingState ss = HMD.GetTrackingState();      
//		bool isConnected = (ss.StatusFlags & (uint)ovrStatusBits.ovrStatus_HmdConnected) != 0;
//
//
//		OVR.Hmd hmd = OVR.Hmd.GetHmd();
//		if(hmd != null)
//		{
//		   OVR.ovrTrackingState trackingState = hmd.GetTrackingState();
//		   //NOTE: There's probably a proper constant to use instead of this literal 2
//		   if((trackingState.StatusFlags & 2) == 0)
//		   {
//		      //lost tracking
//		      Debug.Log ("No DK2 connected");
//		   }
//		   else
//		   {
//		      //currently tracking DK2
//		      Debug.Log ("DK2 detected");
//		   }
