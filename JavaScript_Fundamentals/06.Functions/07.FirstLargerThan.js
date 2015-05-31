/**
 * Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.

 */


var arr = [10, 6, 6, 6, 7, 33, 13, 15];


findNumberAt(arr);

function findNumberAt(arr) {
    var i;
    for (i = 0; i <= arr.length; i++) {
        if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i]) {
            return console.log("The number at position " + i + " is bigger than its neighbours");
        }
    }
    return console.log(-1);
}