# *** PG24 T4 Pipelines (DevOps) - A3: Tool App ***
---------------------------------------
Rodrigo Ferzuli
August, 2023.

Audio Format Converter Tool App developed as a Windows Forms App using C# and the NAudio NuGet package for the Pipelines (DevOps) course.


## Synopsis
---------------
This audio tool is useful for sound designers and audio team members that have to quickly convert any audio asset to an specific audio format (.mp3, .wav or .ogg).
This tool facilitates audio implementation since middleware like Wwise or FMOD only accept .wav audio assets when importing, making this a useful tool that makes the sound designer workflow faster.


## Motivation (optional)
---------------
As a sound designer myself, this tool was something I wish I had in my previous projects, since making this kind of conversion forces you to open very CPU-demanding apps.


## Contributors (optional)
---------------
Scott Henshaw - Instructor.
David Guzman - Teaching Assistant.


# Download/Install
---------------------------------------
1.- Clone the "PG24Rodrigo_Pipelines_A3" repository on your system. Or download the .zip folder from the link below.

[Download Zip](link to zip) - https://github.com/vfs-sct/PG24Rodrigo_Pipelines_A3/archive/refs/heads/main.zip

URL to GitHub repository - https://github.com/vfs-sct/PG24Rodrigo_Pipelines_A3.git


# *** How to use ***
---------------------------------------
1.- Once the repository is cloned, you can open the .snl and run the program through Visual Studio or go to the following path and run the executable: "...\PG24Rodrigo_Pipelines_A3\AudioFormatConverter\AudioFormatConverter\bin\Debug\net6.0-windows\AudioFormatConverter.exe"
2.- Have an audio file ready (.mp3, .wav or .ogg) and browse to it through the "Select File" button.
3.- Select any of the three available audio formats to convert to through the combo box / options list at the right side of the app.
4.- Press the "Convert!" button and your file should be converted to the desired audio format.


## API / Packages Reference
---------------
NAudio NuGet package - https://www.nuget.org/packages/NAudio/


# *** Caveats ***
---------------------------------------

.ogg format "VorbisWriter" method deprecated.
