# Raresh's VGA Painter

[![License: WTFPL](https://img.shields.io/github/license/thegreatrazz/VGAPainter?style=flat-square)](LICENSE.txt)
[![Travis Build Status](https://img.shields.io/travis/thegreatrazz/VGAPainter?style=flat-square)](https://travis-ci.org/thegreatrazz/VGAPainter)
[![Download](https://img.shields.io/github/downloads/thegreatrazz/VGAPainter/total?style=flat-square)](https://github.com/thegreatrazz/VGAPainter/releases)

This is nothing but a simple and barebones application (which I've quickly written in WinForms because I don't know any other application framework which allows me to get a project up and going like this) which lets me make graphics for games and applications running in VGA 256-color mode (aka `INT 10h`).

It uses it's own format, which you read about in the `SaveImage_Click` function in [MainForm.cs](VGAPainter/MainForm.cs). It has a header (`TGRV`), followed by two 16-bit integers (`ushort`) for width and height, finally the raw binary data.

You can use it for drawing true to platform limits artwork and export it into a PNG (but why would you do that when you have Photoshop, Paint.net and GIMP?)

It's not as feature complete as I'd like, but below is a wishlist of quality features I'd like to add.

## Wishlist

* Using alternate 256-color palettes (could come up with an alternate `TGRP` format for storing palettes)
* More tools (flood fill isn't implemented, I also want rectangles and lines)