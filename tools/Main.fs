module Main

open PublishUtils

run "npm test"
match args with
| IgnoreCase "publish"::_ ->
    pushNuget "src/Fable.Fetch.fsproj"
| _ -> ()
