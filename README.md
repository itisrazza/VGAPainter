# Raresh's VGA Painter

[![WTFPL](http://www.wtfpl.net/wp-content/uploads/2012/12/wtfpl-badge-2.png)](http://www.wtfpl.net/)

This is nothing but a simple and barebones application (which I've quickly written in WinForms because I don't know any other application framework which allows me to get a project up and going like this) which lets me make graphics for games and applications running in VGA 256-color mode (aka `INT 10h`).

It uses it's own format, which you read about in the `SaveImage_Click` function in [MainForm.cs](VGAPainter/MainForm.cs). It has a header (`TGRV`), followed by two 16-bit integers (`ushort`) for width and height, finally the raw binary data.

You can use it for drawing true to platform limits artwork and export it into a PNG (but why would you do that when you have Photoshop, Paint.net and GIMP?)

It's not as feature complete as I'd like, but below is a wishlist of quality features I'd like to add.

## Wishlist

* Continuous integration (I want to use this on my laptop where there is no Visual Studio)
* Using alternate 256-color palettes (could come up with an alternate `TGRP` format for storing palettes)
* More shortcut keys (I forgot to add them for the tools)
* More tools (flood fill isn't implemented, I also want rectangles and lines)
* Undo, Redo (This was covered in COMP103, I want to see how it's done in C#.NET)

## Closing Notes

I've got a build in Releases, but it's very rough around the edges.

I also don't care about this project. Any issues will only be dealt with if I have time.
