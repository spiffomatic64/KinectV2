# KinectV2

Forked from liamisbest/KinectDemoRoom

It just the KinectV2 Plugin part.

I modify the original project because I meet some troubles when I build my game in shipping
mode. I expect the initialization is more slower in UE4 editor. But in shipping mode
the kinect was is not available and you have to put some delay before to use it.

To solve that, I add the availability event, directly connected to the same feature
from the SDK.

Some improvements:
* add event for kinect availability
* add function to test availability

