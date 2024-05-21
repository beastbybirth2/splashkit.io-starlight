using SplashKitSDK;

// Define the color Sienna
Color myColor = SplashKit.ColorSienna();

// Open a window
Window window = SplashKit.OpenWindow("Sienna Example", 400, 400);

// Draw a filled circle on the screen using the color from above
SplashKit.ClearScreen();
SplashKit.FillCircle(myColor, 200, 200, 100);
SplashKit.RefreshScreen();

// Keep the window open for 5 seconds
SplashKit.Delay(5000);

// Close the window
SplashKit.CloseWindow(window);
