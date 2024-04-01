# Knob

Knob provides binding for [Knob](https://primereact.org/knob/)

Below is a sample of how to use the Knob bindings

```fsharp
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let value, setValue = React.useState 108
    Html.div [
        Prime.knob [
            knob.min 0
            knob.max 127
            knob.value value
            knob.onChange (fun v -> setValue v)  
        ]
    ]
```