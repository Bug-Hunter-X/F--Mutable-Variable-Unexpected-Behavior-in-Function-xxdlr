let mutable x = 10

let addOne x = 
    x <- x + 1
    x

let y = addOne x

printf "%d %d" x y // Output is 11 11 as expected

//Now, addOne modifies x directly using the <- operator.  This is the correct way to modify mutable variables within functions.