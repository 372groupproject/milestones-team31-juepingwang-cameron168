// Learn more about F# at http://fsharp.org
(*
    Team: 31
    Name: Jueping Wang
    Name: Cameron R. Kazmierski
*)

open FSharp.Data

let md4 = "col-md-4"
let md5 = "col-md-5"

(* 
    Description: 
        Test the input strings are equal to "col-md-4" or "col-md-5"

        Parameter: 
            str: string type data

        Return: it will true if the input string is equal to "col-md-5" or "col-md-4"

    Type signature: 
        isInfoClass: string -> bool
*)
let isMdClass str =
    match str with
    | "" -> false
    | str when str = md5 -> true
    | str when str = md4 -> true
    | _ -> false


(*
    Description:
        This function will find all html nodes from a given HtmlDocument source that have the same 
        intput anchor tag, attribute and the value of attribute. The condition function will help 
        to disregard the irrelevant html nodes by the value of attribute.
            
         Parameter: 
            condition: a function returns boolean type. If the html mactches the value of attribute,
                       It will returns true; Otherwise, returns false

            anchorTags: a string type html of anchor tag
            attribute : a string type html of html attribute

        Return: it will return a list of HtmlNode * string typle. The first element from tuple represents 
                the node has right anchor tag, attribute and the value of attribute, and the second element
                from tuple is the value of attribute of the current node.

        Example of HTML node: 
            <div class="region region-page-top">
                ...
            </div>
        In this example, anchor tag is "div", attribute is "class" and the value of attribute is 
        region region-page-top

        Real Example:
        let t = getHtmlNodes isMdClass "div" "class" 
        Function t will return a list of tuple. The the first element of the tuple has HtmlNode type and it represents a 
        html node with right anchor, such as tag - "div", attribute - "class", and the value of attribute - "col-md-5".
        The second element of the tuple has the attribute value from the current node, In this case, it will have "col-md-5"

    Type signature: 
       getHtmlNodes: (String -> bool) -> string -> string -> list<HtmlNode * string>
*) 
let getHtmlNodes condition (root:HtmlDocument) (anchorTags:string) (attr: string)  = 
    root.Descendants [anchorTags]
    |> Seq.choose (fun x -> 
           x.TryGetAttribute(attr)
           |> Option.map (fun a -> x, a.Value())
    )
    |> Seq.toList
    // filter the results that have the value of attribute
    |> List.filter (fun x -> (condition (snd x)))


(*
    Description:
        Given a list of nodes that contains col-md-4 class or col-md-5 class. Find the right 
        versions from this list and retrun a list of nodes that contains the right version.


        Parameter: 
            version: a string type of version. For example, "col-md-5"

            nodes: a list of <HtmlNode * string> 

        Return:
            returns a list of <HtmlNode * string> that contains the right version. 
            
        Example:
           getMDClasses "col-md-4" list, where list has <HtmlNode * string> type.
           In this case, it will return a list of <HtmlNode * string> that for every 
           HtmlNode has the value of attribute - "col-md-4".

    Type signature: 
       getHtmlNodes: (String -> bool) -> string -> string -> list<HtmlNode * string>
*)
let getMDClasses (version : string ) (nodes: list<HtmlNode * string>) : list<HtmlNode * string> =
    let mutable md4List = [];
    for node in nodes do
        if ((snd node) = version) then 
            md4List <- node :: md4List
        else 
             md4List <- md4List
    List.rev md4List


(*
    Description:
        maintainAtTail will maintian a string list that always has n elements. If a 
        list has exactly n elements, it will return itself. If a list has more than 
        n elements, then it will remove element at the end. Otherwise, it will add 
        empty string at the end.

    Parameter: 
        num : a integer
        str : a string list 

    Return:
        a list of string only has n elements

    Type signature: 
        val maintainAtTail: int-> list<string> -> list<string>
*)
let rec maintainAtTailHelper (num : int) (strList : list<string>): list<string> = 
    match strList with 
    | strList when (List.length strList) = num -> strList
    | strList when (List.length strList) > num -> maintainAtTailHelper num (List.tail strList)
    | _ -> maintainAtTailHelper num ("" :: strList)

let maintainAtTail (num : int)  (info : list<string>) =
    (List.rev info)
    |> maintainAtTailHelper num
    |> List.rev


(*
    Description:
        maintianAtFront will maintian a string list that always has n elements. If a 
        list has exactly n elements, it will return itself. If a list has more than 
        n elements, then it will remove element at the front. Otherwise, it will add 
        empty string at the front.

    Parameter: 
        num : a integer
        str : a string list 

    Return:
        a list of string only has n elements

    Type signature: 
        val maintianAtFront: int-> list<string> -> list<string>
*)
let maintianAtFront (num : int) (info : list<string>) =
    info
    |> maintainAtTailHelper num


(*
    Description:
        This function will get the name from "col-md-5" class.

    Parameter: 
        node : 
            it has "HtmlNode * string" type. The HtmlNode has attribue "col-md-5"
    Return:
        It returns a string list. The each elemment represents the person's name from
        a HtmlNode that has attribue "col-md-5".

    Type signature: 
        val getName: HtmlNode * string -> list<string>
*)
let getName (node: HtmlNode * string) =  
    (fst node).Descendants ["h4"]
    |> Seq.map (fun x -> x.InnerText().Trim()) 
    |> Seq.toList


(*
    Description:
        This function will get the person's information from "col-md-5" class, such as 
        Title, Office and Interest

    Parameter: 
        node : 
            it has "HtmlNode * string" type. The HtmlNode has attribue "col-md-5"
    Return:
        It returns a string list. The elemments represent the person's information
        from a HtmlNode that has attribue "col-md-5".

    Type signature: 
        val getInfo: HtmlNode * string -> list<string>
*)
let getInfo (node: HtmlNode * string) =  
    (fst node).Descendants ["p"]
    |> Seq.choose (fun x -> 
           x.TryGetAttribute("class")
           |> Option.map (fun a -> x.InnerText(), a.Value())
    )
    |> Seq.toList
    |> List.map (fun x -> (fst x).Trim())
    |> maintainAtTail 3


(*
    Description:
        This function will get the person's information from "col-md-4" class, such as 
        phone number and email address.

    Parameter: 
        node : 
            it has "HtmlNode * string" type. The HtmlNode has attribue "col-md-4"
    Return:
        It returns a string list. The elemment represents the contact information
        from a HtmlNode that has attribue "col-md-4".

    Type signature: 
        val getContact: HtmlNode * string -> list<string>
*)
let getContact (node: HtmlNode * string) =  
    (fst node).Descendants ["div"]
    |> Seq.choose (fun x -> 
           x.TryGetAttribute("class")
           |> Option.map (fun a -> x.InnerText(), a.Value())
    )
    |> Seq.toList
    |> List.map (fun x -> (fst x).Trim())
    |> maintianAtFront 2


(*
    Description:
        This function will return all the information as a list. such as Name,
        Title, Office, Interest, Phone Number, and Email address

    Parameter: 
        md4 : 
            a list of Html nodes that have attributes value "col-md-4"

        md5 : 
            a list of Html nodes that have attributes value "col-md-5"
    
    Return:
        It returns a string type list of list. The inner list represent all the
        information for a person.

    Type signature: 
        val extracrInfoFromMDs: list<HtmlNode * string> -> list<HtmlNode * string> -> list<list<string>>
*)
let extracrInfoFromMDs (md4:list<HtmlNode * string>) (md5:list<HtmlNode * string>) = 
    let mutable md5Info = []
    let mutable md4Info = []
    
    // find name, title, interest
    for md5Node in md5 do 
        let name = getName md5Node
        let info = getInfo md5Node
        let temp = List.append name info
        md5Info <- temp :: md5Info
    md5Info <- List.rev md5Info

    // find Phone Number and Email address
    for md4Node in md4 do
        let contact = getContact md4Node
        md4Info <- contact :: md4Info

    // combine basic info and contact info
    md4Info <- List.rev md4Info
    List.zip md5Info md4Info
    |> List.map (fun x -> List.append (fst x) (snd x))


(*
    Description:
        This function can return all the personal data from a given URL link
        Basically, This function encapsulates the function getHtmlNodes, getMDClasses
        and extracrInfoFromMDs as one function that has higher level.

    Parameter: 
        url : 
            a string type 
            For example, "https://www.cs.arizona.edu/about/faculty"
    
    Return:
        It returns a string type list of list. The inner list represent all the
        information for a person.

    Type signature: 
        val extracrInfoFromMDs: list<HtmlNode * string> -> list<HtmlNode * string> -> list<list<string>>
*)
let getDataFromURL (url:string) =
    let page = HtmlDocument.Load(url)
    let pageNodes = getHtmlNodes isMdClass page "div" "class"
    let pageMD4 = pageNodes |> getMDClasses md4  
    let pageMD5 = pageNodes |> getMDClasses md5 
    extracrInfoFromMDs pageMD4 pageMD5 
    |> List.map(fun x -> x |> List.map(fun a -> ("\"" + a + "\"")))


// Get all the facluty info from UofA cs facluty link 
let facultyData = getDataFromURL "https://www.cs.arizona.edu/about/faculty"

// Get all the staff info from UofA cs staff link 
let staffData = getDataFromURL "https://www.cs.arizona.edu/about/staff"

// Get all the graduate students info from UofA cs Graduate Students link 
let graduateStudentsData = getDataFromURL "https://www.cs.arizona.edu/about/graduate-students"


(* 
    Description: 
        merge the facultyData, staffData and graduateStudentsData

    Return:
        2D-string array  
*)
let rawData = 
    let temp = List.append facultyData staffData
    List.append temp graduateStudentsData
    |>List.map(fun x -> (List.toArray x))
    |>List.toArray


(*
    Description:
        This function can will find the GS floors from the rawData
    
    Return:
        It returns a string array that contains the possible floors
*)
let getFloors = 
    let mutable gsFloors = []
    for i in 0 .. rawData.Length - 1 do
        // represent each person
        let inner = (Array.get (Array.get rawData i) 2).Split ' '
        let len   = inner.Length
        // find the office room
        let room  = Array.get inner (len - 1)
        // save the first number from the room number to a list
        gsFloors <- room.[0..0] :: gsFloors
        // reformat the offfice location
        let newRoom = "\"GS " + room  
        Array.set (Array.get rawData i) 2 newRoom
        // remove the duplicate elements from the list 
        gsFloors <- List.distinct gsFloors
    List.toArray gsFloors


(*
    Description:
       Rearrange the raw data by floor and sort the data by name for
       each floor.  
    
    Return:
        It returns a array and each element is a list of list. 
*)
let dataCleaned =
    let mutable data = []
    for i in 0 .. getFloors.Length - 1 do
        // find all the people are in the current floor
        let mutable floor = []
        for j in 0 .. rawData.Length - 1 do
            let person = Array.toList (Array.get rawData j)
            let inner = (Array.get (Array.get rawData j) 2).Split ' '
            let len   = inner.Length
            let room  = Array.get inner (len - 1) 
            // fisrt digir room number matches the floor number
            if (room.[0..0] = (Array.get getFloors i)) then
                floor <- person :: floor
            // not in the current floor
            else 
                floor <- floor
        // save the people who are in the current floor
        data <- floor :: data
    // sort poeple by thier name
    data
    |> List.rev
    |> List.map (fun x -> x |> List.sort)
    |> List.toArray


// csv header
let header = "Name,Title,Office,Interests,Phone,Email\n"

(*
    Description:
       convert the dataCleaned to a string type that satisfies the csv format.
    
    Return:
        a string represents the final data.
*)
let finalData = 
    let mutable data = ""
    for i in 0 .. dataCleaned.Length - 1 do
        // floor information and header 
        data <- data + "\n\"GS: " + (Array.get getFloors i) + "th floor\"\n\n" + header
        // convert all the infomation to a string by floor
        for person in (Array.get dataCleaned i) do
            let mutable temp = ""
            for info in person do
                temp <- temp + info.Trim() + ","
            temp <- temp.[0..((String.length temp) - 2)] + "\n"
            data <- data + temp
    data.Trim()


// write the csv file and display on the Console.
open System
open System.IO 
printfn "Processing..."
File.WriteAllText("ua-cs-directory.csv", finalData)
printfn ""
printfn "Finished:"
printfn "CS departement has %d faculties." (List.length facultyData)
printfn "CS departement has %d staff." (List.length staffData)
printfn "CS departement has %d graduate students." (List.length graduateStudentsData)
printfn "The ua-cs-directory.csv file location: %s" Environment.CurrentDirectory
