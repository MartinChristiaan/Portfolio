module Banners
open Fable.React
open Fable.React.Props
let iconWithText imsource title text =
  let style = Style [AlignItems AlignItemsOptions.Center;Padding 40]
  let iconstyle = Style [Display DisplayOptions.Block;Width 150;Height 150;Margin "auto"]
  let icon = img [Src imsource;iconstyle]
  
  let textStyle =  [Color "Black"; TextAlign TextAlignOptions.Center]
  
  let title = h1 [Style (textStyle @[FontSize 30])][str title]
  
  let text = p [Style (textStyle@[FontSize 20])][str text]
  
  div [style] [icon;title;text]

let banners = 
  let style = [Display DisplayOptions.Grid;
               GridTemplateColumns "repeat(auto-fit, minmax(300px, 1fr))" //";"
               GridColumnGap 20
               GridRowGap 20]

  let experienceBanner = iconWithText "diploma.svg" "Experience you can trust" "2+ years of experience working on cutting edge research projects in the fields of machine learning, computer vision and signal processing."
  let experienceBannerAI = iconWithText "artificial-intelligence.svg" "Empowered by AI" "Leveraged machine learning to solve some of the most challenging problems in signal processing and computer vision"
  
  let experienceBannerPython = iconWithText "diploma.svg" "Excellence in Programming" "A demonstrated ability to use Python, and other languages to their full potential."
  let internationalBanner = iconWithText "cup.svg" "Trained by the best" "Experienced working in multicultural teams and worked abroad at the Heart of AI in Silicon Valley."
 //The Best of both Worlds
  let banners = [experienceBanner;experienceBannerAI;experienceBannerPython;internationalBanner]
  div [Style style] banners
