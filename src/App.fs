module App
open Fable.Core
open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
open Browser.Dom

open Types
open Util
open Fable.Core.JsInterop // needed to call interop tools
open View


let update (msg:Msg) (model:Model) =
    match msg with
    | ScrollToDiv divId -> 
        let x = (window.document.getElementById divId).offsetTop
        //console.log(x)
        window.scrollTo  (0.0,x)
        model
    | ToggleGif id -> 
        let newElement = {GifPlaying= not model.ExperienceElementStates.[id].GifPlaying;
                          MainTextShowing = model.ExperienceElementStates.[id].MainTextShowing}
        let listBeforeElement = model.ExperienceElementStates.[..id]
        let listAfterElement = model.ExperienceElementStates.[id+1..]         
        { model with ExperienceElementStates = listBeforeElement @ [newElement] @ listAfterElement}
    | ToggleMainText id -> 
        let newElement = {GifPlaying=  model.ExperienceElementStates.[id].GifPlaying;
                          MainTextShowing = not model.ExperienceElementStates.[id].MainTextShowing}
        let listBeforeElement = model.ExperienceElementStates.[..id-1]
        let listAfterElement = model.ExperienceElementStates.[id+1..]         
        { model with ExperienceElementStates = listBeforeElement @ [newElement] @ listAfterElement}
    | ToggleModal -> {model with ModalOpen = true}
    
// VIEW (rendered with React)
      

// App
Program.mkSimple init update view
//|> Program.withConsoleTrace
|> Program.withReactSynchronous "elmish-app"
|> Program.run
