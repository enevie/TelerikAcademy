/**
 * Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */


var arr = [3, 5, 7, 9, 7, 2, 3, 1],
    position = 3;

findNumberAt(arr, position);


function findNumberAt(arr, position) {
    if (arr[position - 1] < arr[position] && arr[position + 1] < arr[position]) {
        return console.log("The number at position " + position + " is bigger than its neighbours");
    }
    return console.log(-1);
}
