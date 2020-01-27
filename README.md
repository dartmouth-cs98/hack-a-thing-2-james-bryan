
# 3D Spatializer Sound Demo

Short description of what you attempted to build
* We build an application that demos realistic 3D sound of Grieg's "In the Hall of the Mountain King" soundtrack we created using FL studio, with added resonance sound effects.

Who did what/What you learned
* Bryan practiced the basics of unity, especially on how to integrate 3D audio sounds and manipulate audio settings. He learned how to incorporate multiple audio files, since we plan to simulate an orchestra with many instruments in our final product. He also explored the most efficient ways of creating audio files using a MIDI keyboard that could be imported into Unity. He created the demo soundtrack for Grieg's piece.
* James also practiced the basics of unity, and how to create 3D spatial effects on audio that changes based on distance and user orientation. For example, user rotation will cause one ear to pick up a sound better than another. He also worked with the Resonance Audio SDK to create different resonance effects based on room material. We plan to implement these resonance effects and give users options to change resonance settings in the final product.
* Both Bryan and James gained alot of experience in coordinating a github repo for Unity between two people who were working on the same Scene. This was very difficult, as working simultaneously on the same scene created copious merge conflicts. We ended up solving this issue by having only one person work on the scene at a time, and then pushing those changes, while the other worked on non-scene related tasks such as scripting. This way, changes could be more easily merged. 

How does this hack-a-thing inspire you or relate to your possible project ideas?
* A lot of what we did will be used in our project. Since our project will be created in Unity, we needed to learn how Unity handles sound physics in 3D. In addition, our final app will rely heavily on creating a orchestral accompaniment that sounds realistic. This was done by adding 3D spatial settings for sounds, so that user location and orientation affects how they perceive the accompaniment. Lastly, we will rely heavily on sound engineering tools like VCV Rack and FL Studio to create our synth accompaniment sounds and sountracks.

What didnt' work
* We tried to implement ambisonic audio, which gives a much more accurate sense of 3D audio. However, upon further research, we learned that this requires special equipment to record, and we decided to use our own sound engineering instead.
* Creating sound tracks to import in to Unity was very tough and complicated. At first, we tried to use programs like VCVRack, GarageBand, and Ableton Live Lite (Free version) to create our sound tracks for the music. VCVRack does not work becaues it does not allow for export of sound tracks to mp3 or wav files. Instead, the only way to create a wav/mp3 from VCVRack is to literally record the output sound of my laptop using software like QuickTime Player. This was hugely ineffecient and created problems with sound track alignment. The same issue occured for GarageBand and Ableton Live Lite. We found a solution by using FL Studio, who's free version allows for export to mp3 and wav, which are the only 2 common formats accepted by Unity.
* Creating a realistic string instrument synth sound was extremely difficult. It was way beyond the scope of the 10 hour hackaton, as we think it would require many days/weeks of tediously studying the basics of sound engineering. Thus, we settled with a super basic synth sound that allowed us to successfuly demo the 3D sound physics of Unity. 
