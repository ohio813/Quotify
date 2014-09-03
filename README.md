Quotify
=======

Skype's instant messaging system has a feature in it which allows users to copy-and-paste messages from other users and then quote them in a response. Quotify is a simple program which lets you create fake quotes or edit ones that you have copied to the clipboard.

Compiling
---------

Quotify is written in C# and can be compiled using Visual Studio 2012 or above. No third-party libraries are needed.

Usage
-----

Simply run Quotify.exe after you have compiled it.

To create a new quote, enter a display name to show as the quote's author, select a date for the quote, enter the body of the quote into the textbox, and click the "Copy to Clipboard" button. You can then paste your new quote into Skype's chat box by pressing Ctrl+V.

To edit a quote, first use Skype to copy some text to the clipboard by selecting text, right-clicking, and selecting either "Copy Selection" or "Copy Message". Then, press the "Grab from Clipboard" button in Quotify to pull the quote data from Skype's clipboard. Make changes to the quote as you wish, and then click "Copy to Clipboard" to put it back on the clipboard. You should then be able to paste the modified quote into Skype's chat box.

How It Works
------------

The bulk of Quotify's internals can be found in [SkypeClipboard.cs](https://github.com/amd7/Quotify/blob/master/Quotify/SkypeClipboard.cs) and [SkypeMessageFragment.cs](https://github.com/amd7/Quotify/blob/master/Quotify/SkypeMessageFragment.cs).

Skype copies quote data to the clipboard by storing XML-encoded quote information in the custom clipboard format "SkypeMessageFragment". By manipulating this part of the clipboard, quotes can be edited or created. (A locale for the message and a plaintext version of the quote are also stored; see [SkypeClipboard.cs](https://github.com/amd7/Quotify/blob/master/Quotify/SkypeClipboard.cs) for the details.)

For example, XML-encoded data of a user named John Doe saying "Hey!" might look like this:
```
<quote author="john.doe" authorname="John Doe" conversation="john.doe" guid="x000102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f" timestamp="1409769274"><legacyquote>[2:34:34 PM] John Doe: </legacyquote>Hey!<legacyquote>

&lt;&lt;&lt; </legacyquote></quote>
```
XML quote data is structured as follows:
* `<quote>` tag: The root element.
  * *author* - The username of the quote's author
  * *authorname* - The author's display name
  * *conversation* - The conversation's internal name
  * *guid* - The GUID of the message
  * *timestamp* - Unix timestamp for the message
* `<legacyquote>` tag: Used to store a text-only "legacy" representation of the quote.

When creating quotes, Quotify omits the *author*, *conversation*, and *guid* attributes because they are not necessary.
