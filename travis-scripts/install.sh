#! /bin/sh

# Download Unity3D installer into the container
#  The below link will need to change depending on the version, this one is for 5.5.1 (edited to 2018.2.9f1)
#  Refer to https://unity3d.com/get-unity/download/archive and find the link pointed to by Mac "Unity Editor"
echo 'Downloading Unity 2018.2.9f1 pkg:'
curl --retry 5 -o Unity.pkg https://netstorage.unity3d.com/unity/2207421190e9/MacEditorInstaller/Unity-2018.2.9f1.pkg
if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# In Unity 5 they split up build platform support into modules which are installed separately
# By default, only Mac OSX support is included in the original editor package; Windows, Linux, iOS, Android, and others are separate
# In this example we download Windows support. Refer to http://unity.grimdork.net/ to see what form the URLs should take
#echo 'Downloading Unity 2018.2.9f1 Windows Build Support pkg:'
#curl --retry 5 -o Unity_win.pkg http://netstorage.unity3d.com/unity/88d00a7498cd/MacEditorTargetInstaller/UnitySetup-Windows-Support-for-Editor-2018.2.9f1.pkg
#if [ $? -ne 0 ]; then { echo "Download failed"; exit $?; } fi

# Run installer(s)
echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /
#echo 'Installing Unity_win.pkg'
#sudo installer -dumplog -package Unity_win.pkg -target /
