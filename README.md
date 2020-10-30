# Stick-Control-Metronome
The vision for this program is to be a Windows desktop practice metronome for drummers with features intended to make practicing excercises from books such as George Stone's "Stick Control" (thus the project name) more productive and make using click and backing tracks for live performance simpler to manage on stage. These features are:

Practice
--------
- counts repetitions of groups of one or more measures 
- configurable number of count-in beats
- waits until the first note is struck before the counter the starts counting (e-kit required)

Live Performance
----------------
Set list manager. Used to build set lists where each element of the list can contain:
- tempo, including beat detection to automatically calculate the tempo
- perfomance notes / PDF song charts
- audio source for the song
- audio source for backing tracks

Performance manager. Used during live performance to navigate and control set list elements, generate a click track, and individually route audio content to one or more sound devices. For instance, the backing tracks could be routed to the sound device that feeds signal to the Front of House sound system, while the click track could be routed to a sound device that feeds into the drummer's monitor mix.

This project was entirely made for myself and was never intended for public consumption. I threw it together and got the basic metronome and audio functions working so I could use it for personal practice. None of the other features mentioned above have been added yet.

TODO
----
- Add a stopwatch / countdown timer to the metronome
- Build a MIDI device selection tool so that drummer can specify a MIDI device and channel to monitor for the counter auto-start triggering 
- Build a set list manager so that the drummer can create and edit set lists
- Build a tool for editing a set list entry so that the drummer can specify the song metadata
- Build a beat detection feature into the set list entry editing tool so that when an audio file is specified for the song, the tempo is automatically filled in 
- Build a performance manager so that the drummer can control execution of set lists
- Build an audio routing framework so that the performance manager can assign audio streams to one or more audio devices
- Design a proper user interface
- Create unit tests for existing and future functionality
