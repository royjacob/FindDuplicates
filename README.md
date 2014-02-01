FindDuplicates

==============

Find, log and move tiresome itunes duplicates

Select source and destination folders.
Recurses through the source folder.
Duplicates folder structure in destination folder.
A duplicate is anything with a number on the end:
MusicSource\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven.mp3
MusicSource\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven 1.mp3   <-- duplicate
MusicSource\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven 2.mp3   <-- duplicate

If the destination is TooScaredToDelete

After a move :
MusicSource\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven.mp3


TooScaredToDelete\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven 1.mp3
TooScaredToDelete\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven 2.mp3

TODO:
1. Make it find duplicates accross folders for example: 

  MusicSource\Led Zeppelin\Led Zeppelin IV\Stairway to Heaven.mp3

  MusicSource\LedZeppelin\LedZeppelinIV\Stairway to Heaven.mp3   <-- duplicate
  MusicSource\LedZeppelin\LedZeppelin4\Stairway to Heaven.mp3   <-- duplicate

2. Select individual, files, and folders for removal.

3. Read MP3 tags as well as file names to detect duplicates.
