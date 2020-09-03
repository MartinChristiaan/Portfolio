module Projects
open Fable.React
open Fable.React.Props
open Header
open Experience

open Types
let projects (model:Model) dispatch = 
  let style = [Color "black";TextAlign TextAlignOptions.Center;GlobalMaxWidth;Margin "auto"]
  
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
  let playitsafeimsource = "PlayItSafe.gif"

  let terrainGeneration = "Procedural Terrain Generation"
  let terrainGenerationsubtexts = ["Generate realistic looking terrain for use in various games";
                            "Balance between control and required effort, Performance";
                            "Use Hierarchical Perlin Noise maps to allow the user to control important high level features. Implemented using compute shaders on the gpu to allow for real-time editing of large worldspaces";
                            "C#, Unity, GPU, Compute Shaders"]
  let terrainGenerationimsource = "TerrainGeneration.gif"
  
  let maintextVHM = "Blood flow in the skin plays a role in determining skin color, as for example evident by the reddening of the skin when someone is blushing. Likewise, blood circulation triggers a similar yet far more subtle change in color. Thanks to some advanced signal and video processing, it is possible to measure a heart rate using a webcam or some other camera attached to a computer. 

https://github.com/MartinChristiaan/PythonVideoPulserateV2
"
  let maintextPlayItSafe = "Growing up I always loved the game guitar hero. In this game you have to play the notes of a certain song, essentially playing the guitarist of the band. However, I always found the roster to be limiting. Of course hand labeling all of these notes is tedious and time consuming. So I decided to try and create a procedural version. By combining the onset detector from the Librosa audio analysis library with frequency decomposition I was able to recover the notes being played in the songs quite accurately. Furthermore, additional screen shake and particle effects can be enhanced based on the current energy in the song."
  let maintextTerrainGen = "The variety of in game content largely determines how long a certain game stays enjoyable and therefore can have a substantial impact on the quality of the game. However, hand crafting a large variety of in game content is very time consuming. Consequently, procedural content generation has the potential to dramatically increase the efficiency in game production. 

Procedural Terrain generation has been demonstrated in games like Minecraft and No Mans Sky to be a great application, providing players with endless worlds to explore. Nevertheless, these systems work completely autonomously without any control from either the player or a designer. In this repository I have created a method that allows a controlled generation of a believable terrain at real-time. 

The generation of the terrain is based on special hierarchical layering of perlin noise maps. The designer of the map is able to create biomes like beaches,cliffs and mountains by specifying height and how rough the terrain is .These biomes are then combined using bigger more coarse noise maps . With this approach terrains can be generated at ease while still giving designers a desirable amount of control. This method can also easily leveredge the massively parallel computing power the gpu has to offer.
"

  
  div [Style style; Id "Projects"] [h1[Style [FontSize 40; Padding 20]][str "Projects"];
        experienceELement vhmimsource RTVHMTitle subtexts maintextVHM model.ExperienceElementStates.[3] dispatch 3 ;
        experienceELement playitsafeimsource playitsafe playitsafesubtexts maintextPlayItSafe model.ExperienceElementStates.[4] dispatch 4;
        experienceELement terrainGenerationimsource terrainGeneration terrainGenerationsubtexts maintextTerrainGen model.ExperienceElementStates.[5] dispatch 5]
  




