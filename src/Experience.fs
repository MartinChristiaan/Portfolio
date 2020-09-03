module Experience
open Fable.React
open Fable.React.Props
open Hero
open Header
open Types
let buttonstyle = [BorderRadius 20
                   FontSize 20
                   BackgroundImage mainGradient
                   Color "White"
                   Width 200
                   Height 50
                   Margin "auto"
                   
                  ]




let experienceELement imsource title subtexts bigtext state dispatch idx =
    let containerstyle = [Display DisplayOptions.Grid;
                          GridTemplateColumns "repeat(auto-fit, minmax(500px, 1fr))" //";"
                          GridColumnGap 20;
                          Padding 15;]
    let imgstyle = Style [Display DisplayOptions.Block;Width 800;Margin "auto"]
    let img = img [Src imsource;imgstyle]
    let title = h1[ Style[FontSize 30]][str title]
    let titles = ["Goal";"Challenges";"Solutions";"Used Skills"]|> List.map (fun s -> h1[Style [FontSize 25;FontStyle "italic"]][str s])
    let subtextElements = subtexts|>List.map (fun t -> p[][str t]) 
    let modal = div [Class "modal"][str "Some text"]
    let learnbutton = button[Style buttonstyle; OnClick (fun x -> dispatch (ToggleMainText idx) )][str "Learn More"]
    
    let textContainer =
      if state.MainTextShowing then
        let textcontainer = p[][str bigtext]
        div[Style containerstyle][title;textcontainer;learnbutton]

      else
        
        let textyElements = List.zip titles subtextElements |> List.collect (fun (a,b)-> [a;b])
        div[]([title]@textyElements@[learnbutton])
 
    div[Style containerstyle][img;textContainer]



let experience (model:Model) dispatch = 
  let style = [Color "black";TextAlign TextAlignOptions.Center;GlobalMaxWidth;Margin "auto"]
  let subtexts = ["Remove Artefacts from motion compensated videos using low-profile convolutional neural networks."
                  "Computational complexity, training intermediate CNNs"
                  "Focus AI efforts on crucial intermediate problem,Train with procedural generation"
                  "Python, Tensorflow, Pytorch , C++, Matlab"]  

  let subtexts2 = ["Accelerate Deep learning algorithms using FPGAs."
                   "Production time, investment risk."
                   "Synthesize solutions using the Xilinx Edge AI framework"
                   "FPGAs, C++ , Python, Tensorflow, Keras"]  

  let subtexts3 = ["Accelerate machine learning based signal processing algorithms for optical fiber communication systems."
                   "Trade-off between algorithm complexity and accuracy."
                   "Analysis based on effective vizualisation of algorithm outputs"
                   "GPUs, Cuda, Python, Numba"]


  
  let MEMCMainText = "At V-Silicon I explored opportunities to use AI in frame rate upconversion systems. Existing deep learning based approaches such as Nvidia’s Super Slomo have excessive computational demands which make them difficult to implement for consumer electronics. For my thesis, I designed a robust frame rate upconversion by combining convolutional neural networks with traditional computer vision algorithms. By limiting the application of AI to a particularly difficult subproblem the complexity of the system remained limited whereas the image quality of the resulting frames could be improved." 
  let TNOMaintext = "The application of AI on edge devices such as cameras and robots remains a challenge due to the large computational demands. While GPUs can offer the needed computational capacity, they often consume too much power. Therefore, I explored the potential for field-programmable gate arrays (FPGAs) at TNO since these devices can achieve higher efficiencies with configurations adapted to the task at hand. As high development times can be a major drawback of FPGAs, I investigated the Edge AI framework which automatically synthesized AI applications. During this project, I implemented the YOLO-V3 network on the FPGA, which is capable of detecting and localizing objects within images. Additionally, I investigated memory and compute bottlenecks using the roofline model. While my implementation was able to beat an embedded GPU both in terms of energy consumption and performance, I uncovered some inefficiencies in the compiler with my analysis."
  let ECOMainText = "At Electro communications I researched methods to improve the signal processing chain for optical fiber communication systems. My task was to create prototypes of various filtering methods to explore trade-offs between robustness and complexity. By implementing a crucial component of the chain, the MIMO, on the GPU I was able to speed up lab experiments substantially. 
"

  div [Style style; Id "Experience"] [h1[Style [FontSize 40; Padding 40]][str "Experience"];
        experienceELement "demoimg.png" "V-Silicon Internship" subtexts MEMCMainText model.ExperienceElementStates.[0]  dispatch 0 ;
        experienceELement "fpgademo.jpg" "TNO Internship" subtexts2 TNOMaintext model.ExperienceElementStates.[1]  dispatch 1;
        experienceELement "MIMO.gif" "Research Student Assistant" subtexts3 ECOMainText model.ExperienceElementStates.[2] dispatch 2] 
  
