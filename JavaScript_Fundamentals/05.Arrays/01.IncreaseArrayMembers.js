/**
 * Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

var arr = [];

for (var i = 0; i <= 20; i++) {
    arr.push(5 * i);
}

printArr(arr);

function printArr(arr) {
    for (var i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
}
