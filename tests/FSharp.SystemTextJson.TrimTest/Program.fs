open System.Text.Json
open System.Text.Json.Serialization
open Xunit

[<Fact>]
let ``Regression #77`` () =
    let options = JsonSerializerOptions()
    options.Converters.Add(JsonFSharpConverter())
    Assert.Equal<int>([1; 2; 3], JsonSerializer.Deserialize<int list>("[1,2,3]", options))

[<EntryPoint>]
let main args = Xunit.ConsoleClient.Program.Main args