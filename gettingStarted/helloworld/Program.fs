open System

[<EntryPoint>]
let main (arg: string[]) =
    let person =
        if arg.Length > 0 then
            arg.[0]
        else
            "Anonimous world here"
    for i in 0..arg.Length-1 do
        let person2 = arg.[i]
        printfn " Hello %s from f#" person2
    printfn "Nice to meet you, %s?" person
    0


