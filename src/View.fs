

module View
open Types
open Browser.Dom

open Fable.React
open Fable.React.Props
open Fable.Core


let linkStyle = Style [Padding 10; PaddingRight 15]

let headerTextNav =
  let headerTextStyle = [FontSize 25;Display DisplayOptions.Flex;Width 500;
                    ]

  div[Style headerTextStyle][
    a[linkStyle][str "Home"];
    a[linkStyle][str "Experience"];
    a[linkStyle][str "Projects"];
    a[linkStyle][str "Resume"] ]
  
let headerIcons = 
  let containerstyle = [Display DisplayOptions.Flex; FlexDirection "row-reverse"; Float Right]
  div[][i [Class "fa fa-linkedin"][];i [Class "fa fa-youtube"][];i[Class "fa fa-github"][];]



let header = 
  let style = [BackgroundColor "black"; Height 100;Display DisplayOptions.Flex;Padding 5;]
  div [Style style] [headerTextNav;headerIcons]


//let banner text =
  

let banners = 
  let style = [BackgroundColor "green"]
  div [Style style] [h1[][str "Banners"]]

let experience = 
  let style = [BackgroundColor "blue"]
  div [Style style] [h1[][str "Experience"]]

let projects = 
  let style = [BackgroundColor "red"] 
  div [Style style] [h1[][str "Projects"]]

let content =
  let style = [BackgroundColor "cyan";]  
  div [Style style] [banners;experience;projects]


let view (model:Model) dispatch =
  div []
      [header;content]

