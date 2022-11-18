# xamarin-webview

Based on: https://learn.microsoft.com/en-us/xamarin/android/user-interface/controls/web-view

How to deploy to the hardware device:
- use bundletool
- generate aab
- `bundletool build-apks --bundle="xyz.abb" -- output="app.apks"`
- plug in device in with usb debug enabled
- `bundletool install-apks --apks=app.apks`