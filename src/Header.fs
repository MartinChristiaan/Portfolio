module Header
open Fable.React
open Fable.React.Props
open Types
let linkStyle = Style [Padding 10;
                       PaddingRight 15;
                       Color "White"
                       
                       ]

let headerTextNav dispatch =
  let headerTextStyle = [FontSize 25;Display DisplayOptions.Flex;Width "50%";
                    ]

  div[Style headerTextStyle][
    a[linkStyle][str "Home"];
    a[linkStyle][str "Experience"];
    a[linkStyle; OnClick (fun x -> dispatch ScrollToProjects )][str "Projects"];
    a[linkStyle][str "Resume"] ]
  
let headerIcons = 
  let containerstyle = [Display DisplayOptions.Flex;
   FlexDirection "row-reverse"; 
   Width "50%"
  ]
  let iconstyle = [
    FontSize 30
    Padding 20
    Color "White"
  ]
  div[Style containerstyle] [i [Class "fa fa-linkedin";Style iconstyle][];
   i [Class "fa fa-youtube";Style iconstyle][];
   i[Class "fa fa-github";Style iconstyle][]]

let mainGradient = "linear-gradient(to right, #5516A5 , #1F44A5)"
let buttonGradient = "linear-gradient(to right, #5516A5 , #1F44A5)"

let header dispatch = 
  let style = 
    [BackgroundImage mainGradient;
     Height 70;
     Display DisplayOptions.Flex;
     Padding 5;
     Width "100%";
     Position PositionOptions.Fixed
     ZIndex 1]

  div [Style style] [headerTextNav dispatch;headerIcons]

