# GuitARtist
People hesitate to invest for daughters to pursue a career in arts.The dearth of tutors and time clashes don't help this cause either. Thus women often experience exclusion in instrumental music education. Our Augmented Reality (AR) app GuitARtist aims to bridge that gap by providing a virtual tutor that allows you to learn at your own leisurely pace and at a place of your convenience.

GuitARtist has multiple methods of teaching to cater the needs of beginners, intermediate learners and professionals by assisting them in the different ways with the finger positions and strumming. The closest existing apps with the same goal as ours all have a preset database of songs which don't give the learners independence to try out their personal favorites. Moreover, they also require the user to concentrate on the app and the instrument, which are far apart, at the same time, causing an unnecessary delay in the learning process.

To overcome these limitations, we propose GuitARtist- an app that lets the learner upload any song they wish to learn and view their instrument through their phone to find the chords to be played highlighted upon the guitar as the song goes on. This nullifies the second problem stated, by superimposing the objects so that the user does not lose time while switching his attention between the app and the instrument.

We plan to use Unity and Vuforia as the main tools to build the app. The user is also free to decide the pitch they would like to play the song at. Once the song is given, our app web scrapes for the audio file corresponding to that particular song-name, downloads it and we obtain the corresponding chords by performing signal processing using constant q transform (CQT). Using the chords thus obtained, we instantiate the corresponding fret positions on top of the existing instrument using Vuforia SDK where the user has to position her/his phone according to the reference frame. The strumming pattern will be specified separately as text at the top right corner of the app. The different finger positions on the fret are color coded to make it easier for the user to identify which finger goes where.

We hope to make this app better by performing analysis on the way the chords are supposed to be played versus how the user plays it, to point out where the user is going wrong, in real time. This would make GuitARtist a complete in-your-pocket tutor!

#Instructions to Run
The google drive link we have provided as the demo link has the working apk file of our GuitARtist app. Since it is a prototype we have hosted a local server for the webscraping and chord recognition part, which is one of the main features which lets the user choose any song to play. Other than this, all other features work without the need for a server.

The app is designed to be intuitive to the user and yet we have made sure to resolve any lingering doubts in the "instructions" part which you can access from the home screen.

Next, to target learners of all expertise levels, the "settings" tab allows the user to choose the speed at which the displayed chords changes to give her/him more time to get accustomed to the frets. We suggest choosing "Beginner" initially to get a feel of the app before moving on to using its full potential.

As a warm-up for the users to get accustomed to the functioning of the app, and as a Basic 101-type level for complete beginners, we have the "Warm-Up" Level where she/he learns the chord positions of 10 basic chords and strumming.

Now we introduce the user to full songs in the "Play" tab where we give the user options to either choose any song ever made or choose one from our pre-existing database. To test the database, click on any of the songs made available and similar to the warm-up level, the chords are displayed, except the user learns the whole song with the verses and choruses. Strumming patterns are displayed at the top right corner.

Finally, to allow the user complete freedom on how and what he wants to learn, we present to you an impressive algorithm which makes use of web scraping and signal processing techniques. To this extent, we have set up a local server for our prototype. We can deploy an online server to handle the calls when we implement the complete app.

NOTE: When the complete app is deployed, the USER WILL NOT have to go through the following steps and can directly use the app, because we would have taken care of setting up the online server and its backend. She/He would just be required to enter the name of the desired song, and the corresponding chords would appear automatically.

For now, however, you will need to do some work to set up the server.

1) Since the sockets on which the app is going to communicate over is different for each local machine and the Wi-Fi it is connected to, you need to make sure that both the phone on which the app is running and the computer which runs the server are connected to the same Wi-Fi/Hotspot.

2) Enter "ipconfig" in your computer's command prompt or "ifconfig" on the terminal to get the ip address.

3) Since the app needs to know the ip address to look for while connecting to the socket, you will be required to rebuild the app with the updated scripts.

4) Once the ip address is known, open the scripts "textSocket.cs" and "streamChords.cs" and change the ip address at the line where we have initialised a new TCP client. You can also look for a comment we have added pointing out the line to be changed.

5) Let's rebuild the app using Unity engine as shown in this video: https://www.youtube.com/watch?v=JFcM6sjBrZI

6) On the server side, you will need to install all the libraries we have used, namely, youtube_dl, beautiful soup, urllib, librosa, numpy and scipy (if you don't already have them). 
    On terminal/command prompt: Type "pip install _______"
    On conda: Type "conda install _______"

7) Now we are all set to check the functioning! REMEMBER to start the server before opening the app.

8) Run the script server.py, open the app and get a taste of freedom!

Thank you for taking this journey with us. Hope you liked our app. Feel free to email us if any issues arise. We would be more than happy to help.
