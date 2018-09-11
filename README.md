# SignatureScrapper
What and Why:
  The reason for this project was to view signatures from the public web ( from loomis/dhl ) because they were exposed publically.
Goals:
  1.  Complete objective
  2.  Publish to github
  3.  Use Xamarin to do so by testing on UWP and finnaly on Android because I do not care for IOS.

Things I tried:
  1.  Attempt:  ReadLine() to parse XXXX.bmp with web client
      Fail:  Took to long to get the data
      Alternative:  
        a) Async methods 
        b) read in chunks
        c) read it all into a string parse big string
        d) download to file parse file locally
      Solution:  Read data into stream chunks at a time for speed/memory.
      
Things I Learned:
  1.  Reading from a stream into a buffer chunks at a time.
  2.  Xamarin does not like lots of labels use a list instead.
  3.  Make projects short.
  4.  URI, URL, URN were reaserched for naming sake.

Improvements:
  1.  Reading more than 1 chunk
  2.  Putting signatures into a list
  3.  Progress spinner while getting data
  4.  Removing blue bg.  Signature is black.
  5.  Size of image is tiny quality is crap maybe convert to svg?
  6.  Use skiasharp instead of image.
