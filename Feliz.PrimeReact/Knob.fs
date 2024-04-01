namespace Feliz.PrimeReact

open Fable.Core
open Fable.Core.JsInterop

type KnobOnChangeEvent = { value: float  }

[<Erase>]
type knob =
    static member inline value(value: float) = Interop.mkKnobAttr "value" value
    static member inline value(value: int)     = Interop.mkKnobAttr "value" value
    static member inline min(value: float)   = Interop.mkKnobAttr "min" value
    static member inline min(value: int)       = Interop.mkKnobAttr "min" value
    static member inline max(value: float)   = Interop.mkKnobAttr "max" value
    static member inline max(value: int)       = Interop.mkKnobAttr "max" value
    static member inline step(value: float)  = Interop.mkKnobAttr "step" value
    static member inline step(value: int)      = Interop.mkKnobAttr "step" value
    static member inline size(value: float)  = Interop.mkKnobAttr "size" value
    static member inline size(value: int)      = Interop.mkKnobAttr "size" value

    static member inline onChange(handler: float -> unit) = Interop.mkKnobAttr "onChange" (fun (e: KnobOnChangeEvent) -> handler e.value)
    static member inline onChange(handler: int -> unit) = Interop.mkKnobAttr "onChange" (fun (e: KnobOnChangeEvent) -> handler (int e.value))

