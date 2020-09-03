module Banners
open Fable.React
open Fable.React.Props
open Header
let iconWithText imsource title text =
  let style = Style [AlignItems AlignItemsOptions.Center;Padding 40; ]
  let iconstyle = Style [Display DisplayOptions.Block;Width 110;Height 110;Margin "auto"]
  let icon = img [Src imsource;iconstyle]
  
  let textStyle =  [Color "Black"; TextAlign TextAlignOptions.Center;PaddingTop 30]
  
  let title = h1 [Style (textStyle @[FontSize 30])][str title]
  
  let text = p [Style (textStyle@[FontSize 20])][str text]
  
  div [style] [icon;title;text]

let banners = 
  let style = [Display DisplayOptions.Grid;
               GridTemplateColumns "repeat(auto-fit, minmax(300px, 1fr))" //";"
               GridColumnGap 20
               GridRowGap 20;
               GlobalMaxWidth;
               Margin "auto"]

  let experienceBanner = iconWithText "diploma.svg" "Experience you can trust" "2+ years of experience working on cutting edge research projects in the fields of machine learning, computer vision and signal processing."
  let experienceBannerAI = iconWithText "hammer.svg" "The right tool for the job" "Extensive knowledge of crucial Python libraries and frameworks such as Pytorch, Tensorflow, Numpy, OpenCV and Pandas."  
  let experienceBannerPython = iconWithText "sport-team.svg" "Adapts quickly" "Thrives in multicultural teams and international settings."
  //let internationalBanner = iconWithText "cup.svg" "Trained by the best" "Experienced working in multicultural teams and worked abroad at the Heart of AI in Silicon Valley."
 //The Best of both Worlds
  let banners = [experienceBanner;experienceBannerAI;experienceBannerPython]
  div [Style style] banners
