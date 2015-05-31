/**
 * Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

var inputArray = [1, 2, 3, 4, 5, 5, 5, 6, 66];
var searchValue = 3;


var arrayLength = inputArray.length;
var arrayCurrent = inputArray;
var currentIndex = arrayLength;


function binarySearch() {
    currentIndex = Math.floor(arrayCurrent.length / 2);
    if (searchValue == arrayCurrent[currentIndex]) {
        var x=currentIndex;
        return x;
    } else if (searchValue > arrayCurrent[currentIndex]) {
        arrayCurrent = arrayCurrent.slice(currentIndex + 1);
        return binarySearch();//recursive call

    } else if (searchValue < arrayCurrent[currentIndex]) {
        arrayCurrent = arrayCurrent.slice(0, currentIndex);
        return binarySearch();//recursive call
    }

}
var found=binarySearch();
console.log("the index of the searched value is: " + found);