

module View
open Types
open Browser.Dom

open Fable.React
open Fable.React.Props
open Fable.Core
open Hero
open Header
open Banners
open Experience
open Projects




let content =
  let style = [BackgroundColor "white";Width "100%";Top 60;Position PositionOptions.Absolute]  
  div [Style style] [hero;banners;experience;projects]





let view (model:Model) dispatch =
  div [Style [Color "White";FontSize 20]]
      [header dispatch;content]

