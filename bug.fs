let mutable x = 10

let addOne x = x + 1

let y = addOne x

printf "%d %d" x y // Output is 10 11, not 11 11 as one might expect

//The reason is that addOne x does not modify the mutable variable x. Instead, it creates a new value by adding 1 to x and returns this new value.  The original value of x remains unchanged.