/**
 *Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers.
 */

var number = [3, 9, 100, 35, 12, 89, 22, -5, 5, 333];


findMaxAndMin(number);

function findMaxAndMin(param) {
    var min = 0, max = 0;
    for (var n = 0; n < param.length; n++) {
        if (min > param[n]) {
            min = param[n];
        }
        if (max < param[n]) {
            max = param[n];
        }
    }
    console.log("minimal number: " + min);
    console.log("maximum number: " + max)
}