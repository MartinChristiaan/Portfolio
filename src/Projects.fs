module Projects
open Fable.React
open Fable.React.Props
open Header
open Experience
let projects = 
  let style = [Color "black";TextAlign TextAlignOptions.Center]
  
  let RTVHMTitle = "Real-Time Video Hearbeat Monitors"
  let subtexts = ["Extract pulse rate information from color signals originating from the face. ";
                    "Motion induced disturbance.";
                    "Motion tracking, Skin detection ,algorithms exploiting relevant color features of the blood pulse signal ";
                    "Python, OpenCV, Javascript, F# (Fable)"]
  let vhmimsource = "images/skinClassified.gif"
  
  let playitsafe = "Play it safe (Procedural Guitar Hero)"
  let playitsafesubtexts = ["Generate a guitar-hero clone that works with every song.";
                    "Synthesize accurate note timings and frequencies from mp3 files,performance, scalability";
                    "Use Onset detection as well as frequency analysis to synthesize notes ";
                    "Python, Javascript, Typescript, RxJs"]
  let playitsafeimsource = "images/skinClassified.gif"

  
  
  div [Style style] [h1[Style [FontSize 40; Padding 100]][str "Projects"];
        experienceELement vhmimsource RTVHMTitle subtexts;
        experienceELement playitsafeimsource playitsafe playitsafesubtexts]
  




