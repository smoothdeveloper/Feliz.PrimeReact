module App.Index

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (activeIndex, setActiveIndex) = React.useState (0)

    Html.div [
        Prime.tabView [
            tabView.activeIndex activeIndex
            tabView.onTabChange setActiveIndex
            tabView.children [
                Prime.tabPanel [
                    tabPanel.header "Data Tables"
                    tabPanel.children [ DataTable.Index() ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Dialog"
                    tabPanel.children [ Dialog.Index() ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Input Text"
                    tabPanel.children [ InputText.Index() ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Input Number"
                    tabPanel.children [
                        InputNumber.Index()
                    ]
                ]

                Prime.tabPanel [
                    tabPanel.header "Knob"
                    tabPanel.children [
                        Knob.Index()
                    ]
                ]
            ]
        ]
    ]