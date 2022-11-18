# xamarin-webview

Based on: https://learn.microsoft.com/en-us/xamarin/android/user-interface/controls/web-view

**Just in case you'll end up looking for an example on how to use WebView in Xamarin - DON'T!
This is, likely, the worst possible approach to displaying web content in your app. Beware!**

How to deploy to the hardware device:
- use bundletool
- generate aab
- `bundletool build-apks --bundle="xyz.abb" -- output="app.apks"`
- plug in device in with usb debug enabled
- `bundletool install-apks --apks=app.apks`