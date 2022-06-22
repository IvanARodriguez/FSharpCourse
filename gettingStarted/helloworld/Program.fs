open System

[<EntryPoint>]
let main arg =
    let person =
        if arg.Length > 0 then
            arg.[0]
        else
            "Anonimous world here"
    printf "Hello %s from the F# world!" person
    0
