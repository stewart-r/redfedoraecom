module WriteXml

open ReadFile
open System
open System.Xml

let writeElem (xml:XmlWriter) i (prod:Product) = 
    
    xml.WriteStartElement("item")
    xml.WriteElementString("id",sprintf "100-%d" i)
    xml.WriteElementString("name",prod.Name)
    xml.WriteElementString("description",prod.Descriprion)
    xml.WriteElementString("category",prod.Category)
    xml.WriteElementString("colour",prod.Colour)
    if prod.Material.IsSome then xml.WriteElementString("material",prod.Material.Value)
    xml.WriteStartElement("attributes")
    prod.Attributes
    |> Seq.iter(fun a -> xml.WriteElementString("attribute",a))
    xml.WriteEndElement()
    xml.WriteElementString("brand",prod.Brand)
    xml.WriteElementString("price",prod.Price.ToString())
    xml.WriteElementString("rrp",prod.Rrp.ToString())
    xml.WriteEndElement()

let writeProds (prods:seq<Product>) =
    let settings = new XmlWriterSettings()
    settings.Indent <- true
    settings.IndentChars <- "  "
    use xml = XmlWriter.Create("redfedorafeed.xml", settings)
    xml.WriteStartDocument()
    xml.WriteStartElement("products")
    prods 
    |> Seq.sortBy(fun p -> 
        if p.Category.Contains("edora") then Guid.NewGuid().ToString() else "x"+ Guid.NewGuid().ToString() )
    |> Seq.iteri (fun i e -> writeElem xml i e)
    xml.WriteEndElement()
    xml.WriteEndDocument()