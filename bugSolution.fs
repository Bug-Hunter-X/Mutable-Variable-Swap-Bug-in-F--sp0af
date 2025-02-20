let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    (y, temp)

let (x, y) = swap x y
printf "%d %d" x y // Output: 20 10