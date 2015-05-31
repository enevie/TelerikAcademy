/**
 * Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */


var arr = [3, 6, 8, 2, 3, 8, 8, 5];
var numberToFind = 5;


countNumber(arr, numberToFind);

function countNumber(arr, num) {
    var i, counter = 0;

    for (i = 0; i <= arr.length; i++) {
        if (arr[i] == num) {
            counter++;
        }
    }
    if (counter > 0) {
        return console.log("The number " + num + " is found " + counter + " times");
    }
    return console.log("not found");
}
