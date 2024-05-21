using SplashKitSDK;

// Define the color Forest Green
Color myColor = SplashKit.ColorForestGreen();

// Open a window
Window window = SplashKit.OpenWindow("Forest Green Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
