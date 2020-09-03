module Types

open Fable.Core
open Elmish
open Elmish.React
open Fable.React
open Browser.Dom

open Fable.Core.JsInterop // needed to call interop tools

type Page = Main | Contact

type ExperienceElementState = {
  MainTextShowing : bool
  GifPlaying : bool  
}

type Model = {
  CurrentPage : Page
  ModalOpen : bool
  ExperienceElementStates : ExperienceElementState list
}

type Msg =
| ScrollToDiv of string
| GoToPage of string
| ToggleGif of int
| ToggleMainText of int
| ToggleModal

let init() : Model = {CurrentPage=Main;
                      ModalOpen = false
                      ExperienceElementStates = List.init 6 (fun x -> {MainTextShowing = false;GifPlaying = false})
                      }
                   
                    // 
                    // mdl