module Header
open Fable.React
open Fable.React.Props
open Types
let linkStyle = Style [Padding 10;
                       PaddingRight 15;
                       Color "White"
                       
                       ]
let GlobalMaxWidth = MaxWidth "70rem"

let headerTextNav dispatch =
  let headerTextStyle = [FontSize 25;Display DisplayOptions.Flex;Width "50%";
                    ]
  let getOnClick divId = OnClick (fun x -> dispatch (ScrollToDiv divId) )
  div[Style headerTextStyle][
    a[linkStyle; getOnClick "Home" ][str "Home"];
    a[linkStyle; getOnClick "Experience"][str "Experience"];
    a[linkStyle; getOnClick "Projects"][str "Projects"];
    a[linkStyle; Href "/Resume.pdf"][str "Resume"] ]
  
let headerIcons = 
  let containerstyle = [Display DisplayOptions.Flex;
   FlexDirection "row-reverse"; 
   Width "50%"
  ]
  let iconstyle = [
    FontSize 30
    Padding 10
    Color "White"
  ]
  div[Style containerstyle] [a [Class "fa fa-linkedin";
                                Href "https://www.linkedin.com/in/martin-van-leeuwen-3a3119186/" ;
                                Style iconstyle][];
  
   a [Class "fa fa-github"; Href "https://github.com/MartinChristiaan";Style iconstyle][]]

let mainGradient = "linear-gradient(to right, #5516A5 , #1F44A5)"
let buttonGradient = "linear-gradient(to right, #5516A5 , #1F44A5)"

let header dispatch = 
  let style = 
    [BackgroundImage mainGradient;
     
    
     Width "100%";
     Position PositionOptions.Fixed
     ZIndex 1]
  let contentstyle = [     Display DisplayOptions.Flex;Height 70; Padding 5;Width "100%";GlobalMaxWidth;Margin "auto"]

  div [Style style] [div[Style contentstyle][headerTextNav dispatch;headerIcons]]

