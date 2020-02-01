module Types

open Fable.Core
open Elmish
open Elmish.React
open Fable.React
open Browser.Dom

open Fable.Core.JsInterop // needed to call interop tools

type Page = Main | Contact

type Model = {
  CurrentPage : Page
}

type Msg =
| ToContact
| ScrollToProjects

let init() : Model = {CurrentPage=Main}
                  
                    // 
                    // mdl