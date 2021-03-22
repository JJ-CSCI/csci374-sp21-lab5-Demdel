module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
   match a with // prod is a function name
   // you need value that contains tree object
     | Node a -> a 
     | _ -> a  
    

let rec map (f:int->int) (t:Tree) :Tree =
    match Tree with 
      | Node(l,r) -> Node(map f(l), map f(r))

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
