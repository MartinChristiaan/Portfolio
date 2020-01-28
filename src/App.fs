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
    model
// VIEW (rendered with React)
      

// App
Program.mkSimple init update view
//|> Program.withConsoleTrace
|> Program.withReactSynchronous "elmish-app"
|> Program.run
