#include "splashkit.h"

int main()
{
    // Define the color Goldenrod
    color my_color = COLOR_GOLDENROD;

    // Open a window
    open_window("Goldenrod Example", 400, 400);

    // Draw a filled circle on the screen using the color from above
    clear_screen();
    fill_circle(my_color, 200, 200, 100);
    refresh_screen();

    // Keep the window open for 5 seconds
    delay(5000);

    // Close the window
    close_window("Goldenrod Example");

    return 0;
}
