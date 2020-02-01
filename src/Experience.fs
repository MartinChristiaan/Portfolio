module Experience
open Fable.React
open Fable.React.Props
open Hero
open Header
let buttonstyle = [BorderRadius 20
                   FontSize 20
                   BackgroundImage mainGradient
                   Color "White"
                   Width 200
                   Height 50
                   Margin 10
                  ]

let experienceELement imsource title subtexts =
    let containerstyle = [Display DisplayOptions.Grid;
                          GridTemplateColumns "repeat(auto-fit, minmax(500px, 1fr))" //";"
                          GridColumnGap 20]
    let imgstyle = Style [Display DisplayOptions.Block;Width 800;Margin "auto"]
    let img = img [Src imsource;imgstyle]
    let title = h1[ Style[FontSize 30]][str title]
    let titles = ["Goal";"Challenges";"Solutions";"Used Skills"]|> List.map (fun s -> h1[Style [FontSize 25;FontStyle "italic"]][str s])
    let subtextElements = subtexts|>List.map (fun t -> p[][str t]) 
    
    let learnbutton = button[Style buttonstyle][str "Learn More"]
    let textyElements = List.zip titles subtextElements |> List.collect (fun (a,b)-> [a;b])
    

    let textcontainer = div[]([title]@textyElements@[learnbutton])
    


    div[Style containerstyle][img;textcontainer]



let experience = 
  let style = [Color "black";TextAlign TextAlignOptions.Center]
  let subtexts = ["Remove Artefacts from motion compensated videos using Deep learning."
                  "Data imbalance, complexity, visual perception"
                  "..."
                  "Python, Tensorflow, Pytorch , C++, Matlab"]  

  let subtexts2 = ["Accelerate Deep learning algorithms using FPGAs."
                   "Production time, investment risk."
                   "Synthesize solutions using Xilinx Edge AI framework"
                   "FPGAs, C++ , Python, Tensorflow"]  

  let subtexts3 = ["Accelerate machine learning based signal processing algorithms for optical fiber communication systems."
                   "Trade-off between algorithm complexity and accuracy."
                   "Analysis based on effective vizualisation of algorithm outputs"
                   "GPUs, Cuda, Python, Numba"]

  div [Style style] [h1[Style [FontSize 40; Padding 100]][str "Experience"];
        experienceELement "motionexample.jpg" "V-Silicon Internship" subtexts;
        experienceELement "edgeai.png" "TNO Internship" subtexts2;
        experienceELement "MIMO.gif" "Research Student Assistant" subtexts3]
  
