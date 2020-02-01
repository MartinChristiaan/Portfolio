module Hero
open Fable.React
open Fable.React.Props
open Header

let buttonstyle = [BorderRadius 20
                   FontSize 20
//                   FontWeight "bold"
                  ]

let hero = 
  let style = [BackgroundImage mainGradient;Height 300]
  let herotextStyle = [TextAlign TextAlignOptions.Center]
  let mynameStyle = Style (herotextStyle @ [FontSize 40])
  let myDescriptionStyle = Style (herotextStyle @ [FontSize 30])
  let name = p[mynameStyle][str "Martin Christiaan van Leeuwen"]
  let text = p[myDescriptionStyle][str "Machine learning specialist and programming enthusiast"]



  let buttonstyle = 
    Style([Display DisplayOptions.Block;
    MarginLeft "auto";MarginRight "Auto";
    Width 200; Height 40; Top 100;
    Position PositionOptions.Relative;] @ buttonstyle)


  div [Style style] [name;text;button[buttonstyle][str "Contact"]]