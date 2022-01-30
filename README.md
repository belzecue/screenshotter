# screenshotter

Takes a screenshot at intervals and saves to .png.  Intended for making a timelapse video of desktop activity, by combining the pngs into a video with ffmpeg.

Windows only.  Solution coded circa 2018.

# Instructions

- Run the prog
- Hit "browse" and set the target directory for the snapshot images
- leave all defaults as is.
- Click START

![1](https://user-images.githubusercontent.com/1931303/151686643-a62b1845-242d-4ef2-8d0e-0071de07afd4.png)

# Explanation

- When you press start, the prog will create a subfolder under the chosen directory.  The subfolder name will be the current datetime in the format "yymmdd-hhmmss".  Screenshots will go here and be named per above.  The naming format is important and gives the order for converting the images into a movie.

- Option "increment number from last" means whenever the prog starts, it will check all subfolders under the chosen directory to find the highest numbered file and will start the current session capture from that number (plus 1).  This means you can capture stuff across days, into the separate subfolders, then later combine all files into one folder and they will all be sequentially named, with no number gaps, and can be easily converted to a continuous movie.

# How to create a movie of images

- Place the ffmpeg.exe executable into your c:\windows folder, so that you can call the program from any directory.
- Start a command prompt (console)
- In the console, drill down to your folder containing your image files
- Paste this into the console at the prompt:

ffmpeg -framerate 15 -i image-%06d.png -vf scale=-1:720 -r 15 -c:v libx264 -crf 20 -pix_fmt yuv420p out.mp4

and hit enter to activate it.

You should see a bunch of output showing it is processing the images into a movie.  When done, the movie file will be called "out.mp4".

Breaking down the command...

![Screenshot at 2022-01-30 12-32-09](https://user-images.githubusercontent.com/1931303/151686713-f91ee89e-498d-4cac-924e-40e04191b3e1.png)

# IMPORTANT!

Hit the STOP button before doing anything sensitive -- like checking your email or doing anything that puts private stuff on the screen that will be captured.  If you post a time-lapse video online, guaranteed someone will frame-by-frame through it looking for an inadvertent screen capture showing passwords or sensitive info!!  Review your collection of images before you convert them to a movie.
