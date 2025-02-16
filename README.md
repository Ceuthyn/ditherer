# ditherer

## purpose

to reduce the color palette of any given image to a user defined one, be it for stylistic purposes or to decrease file size

## usage

1. import an image using the select image button
2. add/remove colors from the palette using the add/remove color buttons
3. adjust brightness and contrast if necessary
4. save the resulting image using the save image button
![example](/ditheringnightmare/img/example.png)

## known issues
- input and output image possibly in the window, saved image unaffected
- high contrast values cause heavy distortion, perhaps visually interesting but not a thing that should happen
- small overall variation in the palette, for example, black and another rather dark color, causes distortion due to the quantized error in the dithering algorithm not being compensated for
- brigthness and contrast sliders moving causes the image to be redrawn, causing considerable slow-down if the user attempts to make large changed by smoothly dragging them
- higher color counts in the palette are horizontally squished in the palette display

## possible future additions
- optional image rescaling in cases of large/small input images
- option to right-click a color in the palette to remove it instead of having to repeatedly remove the following colors
- exporting of the quantized error as its own image as it has shown to be visually interesting
- support for other image file types
- gif support
